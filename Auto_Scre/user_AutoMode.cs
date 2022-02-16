using DevExpress.Data.Camera;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Auto_Scre
{
    public partial class user_AutoMode : DevExpress.XtraEditors.XtraUserControl
    {
        public user_AutoMode()
        {
            InitializeComponent();
        }

        public void cameraControl_Click(object sender, EventArgs e)
        {
            camera();
        }

        public void camera()
        {
            List<CameraDeviceInfo> deviceInfoList = CameraControl.GetDevices();

            if (deviceInfoList != null && deviceInfoList.Count > 0)
            {
                foreach (CameraDeviceInfo deviceInfo in deviceInfoList)
                {
                    CameraDevice device = CameraControl.GetDevice(deviceInfo);
                    ImageComboBoxItem item = new ImageComboBoxItem(); 
                    item.Description = device.Name; 
                    item.Value = device;
                }
             }
            this.cameraControl.AutoStartDefaultDevice = false; 
            this.cameraControl.ShowSettingsButton = false; 


        }
       
        public void user_AutoMode_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
