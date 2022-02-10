using DevExpress.XtraEditors;
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
    }
}