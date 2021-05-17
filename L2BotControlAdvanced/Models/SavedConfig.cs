using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BotControlAdvanced.Models
{
    public class SavedConfig
    {
        public int CameraIndex { get; set; }
        public LaneDetectionConfig LaneDetection { get; set; }
        public RedLineDetectionConfig RedLineDetection { get; set; }

        public class LaneDetectionConfig
        {
            public enum Methods { BinaryThreshold, HSV }

            public Methods LaneDetectionMethod { get; set; }
            public int BinaryThreshold { get; set; }
            public HSVConfig HSVThresholds { get; set; }
        }

        public class RedLineDetectionConfig
        {
            public HSVConfig HSVThresholds { get; set; }
            public bool SuspendStopCommand { get; set; }
        }

        public class HSVConfig
        {
            public int HMin { get; set; }
            public int HMax { get; set; }
            public int SMin { get; set; }
            public int SMax { get; set; }
            public int VMin { get; set; }
            public int VMax { get; set; }
        }
    }
}
