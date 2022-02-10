using DevExpress.Data.Camera;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
