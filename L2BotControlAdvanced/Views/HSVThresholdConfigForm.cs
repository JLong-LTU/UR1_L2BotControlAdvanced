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
using Emgu.CV;
using L2BotControlAdvanced.Models;
using L2BotControlAdvanced.Services;

namespace L2BotControlAdvanced.Views
{
    public partial class HSVThresholdConfigForm : Form
    {
        public enum ConfigTarget { RedLines, LaneLines }

        public ConfigTarget Target { get; set; }

        private readonly IConfigService _configService;
        private readonly ICameraService _cameraService;
        private readonly IImageManipulationService _imageManipulationService;
        
        private Thread _captureThread;
        private SavedConfig.HSVConfig _stagedConfiguration = new SavedConfig.HSVConfig();

        public HSVThresholdConfigForm(
            IConfigService configService,
            ICameraService cameraService,
            IImageManipulationService imageManipulationService
        ) {
            _configService = configService;
            _cameraService = cameraService;
            _imageManipulationService = imageManipulationService;

            InitializeComponent();
        }

        private void HSVThresholdConfigForm_Load(object sender, EventArgs e)
        {
            // create the image processing thread
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();

            copyHSVConfigToStaging();
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

        private void DisplayImageOnForm(PictureBox pictureBox, Mat frame)
        {
            Invoke(new Action(() =>
            {
                pictureBox.Image = frame.Bitmap;
            }));
            //Thread.Sleep(50);
        }

        private void copyHSVConfigToStaging()
        {
            var temp = new SavedConfig.HSVConfig();

            if(Target == ConfigTarget.LaneLines)
            {
                temp = _configService.Config.LaneDetection.HSVThresholds;
            }
            else if(Target == ConfigTarget.RedLines)
            {
                temp = _configService.Config.RedLineDetection.HSVThresholds;
            }

            _stagedConfiguration.HMin = temp.HMin;
            _stagedConfiguration.HMax = temp.HMax;
            _stagedConfiguration.SMin = temp.SMin;
            _stagedConfiguration.SMax = temp.SMax;
            _stagedConfiguration.VMin = temp.VMin;
            _stagedConfiguration.VMax = temp.VMax;
        }

        private void copyStagingToHSVConfig()
        {
            // This works due to complex objections being pass-by-reference as opposed to by-value
            // When we update outputRef, we're updating the same memory location as the one in the ConfigService
            var outputRef = new SavedConfig.HSVConfig();

            if (Target == ConfigTarget.LaneLines)
            {
                outputRef = _configService.Config.LaneDetection.HSVThresholds;
            }
            else if (Target == ConfigTarget.RedLines)
            {
                outputRef = _configService.Config.RedLineDetection.HSVThresholds;
            }

            outputRef.HMin = _stagedConfiguration.HMin;
            outputRef.HMax = _stagedConfiguration.HMax;
            outputRef.SMin = _stagedConfiguration.SMin;
            outputRef.SMax = _stagedConfiguration.SMax;
            outputRef.VMin = _stagedConfiguration.VMin;
            outputRef.VMax = _stagedConfiguration.VMax;
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            copyStagingToHSVConfig();
            Close();
        }

        private void cancelChangesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HSVThresholdConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
    }
}
