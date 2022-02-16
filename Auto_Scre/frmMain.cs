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
using Auto_Scre.Data.EF.Context;
using System.Data.SqlClient;
using System.Data.Common;
using Auto_Scre.Data.EF;
using sun.security.util;

namespace Auto_Scre
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        static AppDbContext sql = new AppDbContext();
        static SqlConnection connection = sql.Connectiondb();

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
            args.Buttons = new DialogResult[] { DialogResult.No, DialogResult.Cancel, DialogResult.Yes };
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

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnTestConnectDB_Click(object sender, EventArgs e)
        {

            connection.Open();
            string info = "";

            // Dùng SqlCommand thi hành SQL  - sẽ  tìm hiểu sau
            using (DbCommand command = connection.CreateCommand())
            {
                // Câu truy vấn SQL
                command.CommandText = "select top(5) * from customer";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info += ($"{reader["name"],3} {reader["address"]}\n");
                }
            }
            MessageBox.Show(info);

            // Lấy thống kê và in số liệu thống kê
            string report = "";
            Console.WriteLine("Thông tin thống kê các tương tác đã thực hiện trên kết nôis");
            var dicStatics = connection.RetrieveStatistics();
            foreach (var key in dicStatics.Keys)
            {
                report += ($"{key,17} : {dicStatics[key]}\n");
            }
            MessageBox.Show(report);

            // Không dùng đến kết nối thì phải đóng lại (giải phóng)
            connection.Close();


        }

        private void btnMachine_Setup_Click(object sender, EventArgs e)
        {
            try
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.PasswordChar = '*';
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Check Pass";
                args.Prompt = "Entrez la quantité";
                args.Editor = textEdit;
                var password = null;
                password = XtraInputBox.Show(args).ToString();
                string pass = password.ToString();
                string passAdmin = "lge";
                if (pass == passAdmin)  
                    use_Machine_Setup1.BringToFront();
                else
                    user_AutoMode1.BringToFront();
            }catch(Exception ex)
            {
                user_AutoMode1.BringToFront();
            }

        }
    }
}