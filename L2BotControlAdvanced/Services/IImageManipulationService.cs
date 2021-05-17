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
    public interface IImageManipulationService
    {
        void ResizeMat(Mat input, Mat output, Size newSize);
        void ConvertColor(Mat input, Mat output, Emgu.CV.CvEnum.ColorConversion conversion);
        void ApplyBinaryThreshold(Mat input, Mat output, int threshold);
        void ApplyHSVThreshold(Mat input, Mat output, SavedConfig.HSVConfig hsvThresholds, Mat hOutput = null, Mat sOutput = null, Mat vOutput = null);
    }
}
