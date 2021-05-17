using Emgu.CV;
using L2BotControlAdvanced.Models;
using L2BotControlAdvanced.Services;
using L2BotControlAdvanced.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2BotControlAdvanced
{
    public partial class Form1 : Form
    {
        private readonly IConfigService _configService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICameraService _cameraService;
        private readonly IImageManipulationService _imageManipulationService;
        
        private Thread _captureThread;

        public Form1(
            IConfigService configService, 
            IServiceProvider serviceProvider,
            ICameraService cameraService,
            IImageManipulationService imageManipulationService
        ) {
            _configService = configService;
            _serviceProvider = serviceProvider;
            _cameraService = cameraService;
            _imageManipulationService = imageManipulationService;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create the image processing thread
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();

            // Create list of lane detection modes:
            foreach (SavedConfig.LaneDetectionConfig.Methods method in Enum.GetValues(typeof(SavedConfig.LaneDetectionConfig.Methods)))
            {
                laneDetectionSelector.Items.Add(method);
                if(_configService.Config.LaneDetection.LaneDetectionMethod == method)
                {
                    laneDetectionSelector.SelectedItem = method;
                }
            }

        }

        private void DisplayWebcam()
        {
            while (_cameraService.IsActive)
            {
                if (_cameraService.SuspendFrameQuery)
                {
                    continue;
                }

                // frame maintenance (get frame from camera and resize frame to fit display)
                Mat frame = _cameraService.QueryFrame();
                _imageManipulationService.ResizeMat(frame, frame, new Size(originalImagePictureBox.Size.Width, originalImagePictureBox.Size.Height));

                // display the source frame image:
                DisplayImageOnForm(originalImagePictureBox, frame);

                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }

        private void DisplayImageOnForm(PictureBox pictureBox, Mat frame)
        {
            Invoke(new Action(() =>
            {
                pictureBox.Image = frame.Bitmap;
            }));
            //Thread.Sleep(50);
        }

        private void laneDetectionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            _configService.Config.LaneDetection.LaneDetectionMethod = 
                (SavedConfig.LaneDetectionConfig.Methods)laneDetectionSelector.Items[laneDetectionSelector.SelectedIndex];
        }

        private void redLineConfigBtn_Click(object sender, EventArgs e)
        {
            /*
             * Opening a secondary windows form would normally be as simple as:
             * var form2 = new BinaryThresholdConfigForm();
             * form2.show();
             * 
             * However, due to Dependency Injection being used, I'm referencing the form via the DI registry.
             */
            var binaryThresholdConfig = _serviceProvider.GetRequiredService<HSVThresholdConfigForm>();
            binaryThresholdConfig.Target = HSVThresholdConfigForm.ConfigTarget.RedLines;
            binaryThresholdConfig.Show();
        }
    }
}
