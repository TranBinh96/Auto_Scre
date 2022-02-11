using DevExpress.Data.Camera;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace Auto_Scre
{
    public partial class user_AutoMode : DevExpress.XtraEditors.XtraUserControl
    {
        public user_AutoMode()
        {
            InitializeComponent();
        }

        private void cameraControl_Click(object sender, EventArgs e)
        {

        }

        bool isStopped = false;
        Bitmap img;
        private void user_AutoMode_Load(object sender, EventArgs e)
        {
            img = cameraControl.TakeSnapshot();
            cameraControl.Stop();
            isStopped = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
