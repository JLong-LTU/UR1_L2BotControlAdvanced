using Emgu.CV;
using L2BotControlAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace L2BotControlAdvanced.Services
{
    public class CameraService : ICameraService
    {
        public bool IsActive
        {
            get
            {
                return _cameraSet;
            }
        }
        public List<string> Cameras
        {
            get
            {
                return _cameras;
            }
        }
        public bool SuspendFrameQuery
        {
            get
            {
                return _suspendFrameQuery;
            }
        }

        private readonly IConfigService _configService;

        private List<string> _cameras = new List<string>();
        private VideoCapture _capture;
        private bool _cameraSet = false;
        private bool _suspendFrameQuery = false;
        private int _cameraIndex = 0;

        public CameraService(IConfigService configService)
        {
            _configService = configService;

            LoadCameraList();

            if(_cameras.Count > 0)
            {
                var camIndex = 0;

                if(_cameras.Count >= _configService.Config.CameraIndex)
                {
                    camIndex = _configService.Config.CameraIndex;
                }

                ConnectToCamera(camIndex);
            }
        }

        public Mat QueryFrame()
        {
            if (_suspendFrameQuery)
            {
                return new Mat();
            }

            if (_cameraSet && _capture.IsOpened)
            {
                return _capture.QueryFrame();
            }

            throw new Exception("Unable to query for frame when camera is not active");
        }

        public void ConnectToCamera(int cameraIndex)
        {
            if (_cameras.Count >= cameraIndex)
            {
                _cameraIndex = cameraIndex;
                _configService.Config.CameraIndex = cameraIndex;
            }
            else
            {
                throw new Exception($"Attempted to load camera {cameraIndex} while only {_cameras.Count} cameras were found");
            }

            _suspendFrameQuery = true;

            if(_capture != null && _capture.IsOpened)
            {
                _capture.Stop();
            }
            _capture = new VideoCapture(cameraIndex);
            _cameraSet = _capture.IsOpened;

            _suspendFrameQuery = false;
        }

        private void LoadCameraList()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            {
                foreach (var device in searcher.Get())
                {
                    _cameras.Add(device["Caption"].ToString());
                }
            }
        }
    }
}
