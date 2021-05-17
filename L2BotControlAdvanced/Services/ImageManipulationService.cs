using Emgu.CV;
using L2BotControlAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BotControlAdvanced.Services
{
    public class ImageManipulationService : IImageManipulationService
    {
        /// <summary>
        /// Shortcut function to resize images while respecting the apsect ratio of the original image.
        /// </summary>
        /// <param name="input">The input Mat, will be read from</param>
        /// <param name="output">The output Mat reference, the resized image data will be written to this referenced object</param>
        /// <param name="outputMaxDimensions">The max width and height of the output frame, will be treated as the extreme max size when calculating resize ratio</param>
        public void ResizeMat(Mat input, Mat output, Size outputMaxDimensions)
        {
            int newHeight = (input.Size.Height * outputMaxDimensions.Width) / input.Size.Width;
            Size newSize = new Size(outputMaxDimensions.Width, newHeight);
            CvInvoke.Resize(input, output, newSize);
        }

        public void ConvertColor(Mat input, Mat output, Emgu.CV.CvEnum.ColorConversion conversion)
        {
            CvInvoke.CvtColor(input, output, conversion);
        }
        
        public void ApplyBinaryThreshold(Mat input, Mat output, int threshold)
        {

        }

        public void ApplyHSVThreshold(Mat input, Mat output, SavedConfig.HSVConfig hsvThresholds, Mat hOutput = null, Mat sOutput = null, Mat vOutput = null)
        {

        }
    }
}
