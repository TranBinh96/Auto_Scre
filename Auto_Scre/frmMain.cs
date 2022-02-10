using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Localization;
using DevExpress.XtraEditors.Camera;
using DevExpress.Data.Camera;
using DevExpress.Utils;

namespace Auto_Scre
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            user_AutoMode1.BringToFront();
        }

        private void btn_AutoMode_Click(object sender, EventArgs e)
        {
            user_AutoMode1.BringToFront();
        }

        private void btn_ManageData_Click(object sender, EventArgs e)
        {
            user_ManageData1.BringToFront();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Showing += Args_Showing;
            args.Caption = "Message";
            args.Text = "Do you want stop program ?.";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel, DialogResult.Retry };
            XtraMessageBox.Show(args);
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                    //button.Height = 25;
                    switch (button.DialogResult.ToString())
                    {
                        case ("OK"):
                            break;
                        case ("Cancel"):
                            break;
                        case ("Retry"):
                            break;
                    }
                }
            }
        }

        
    }
}