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
    public interface ICameraService
    {
        bool IsActive { get; }
        bool SuspendFrameQuery { get; }
        List<string> Cameras { get; }

        Mat QueryFrame();
        void ConnectToCamera(int cameraIndex);
    }
}
