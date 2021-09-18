using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class ChangePasswork_GUI : UserControl
    {
        DBAccess db = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-8VBF1B8\SQLEXPRESS;Database=QLKSCN;User ID=sa;Password=sa;");
        string id = "";
        public ChangePasswork_GUI()
        {
            InitializeComponent();
        }


       

        protected void Bind_Data()
        {

            DataRow r = infoUser(frmLogin.mnv);
            txtmanv.Text = r[0].ToString();
            
        }


        private void showtxtnv()
        {
            txtmanv.Enabled =false;
            txtOldPass.Enabled = true;
            txtPass.Enabled = true;
            txtConfirmPass.Enabled = true;
           
        }



        public DataRow infoUser(string IdEmployee)
        {
            string sql = "select IdEmployee, password from Permission where IdEmployee = '" + IdEmployee + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r;
        }

        private void ChangePasswork_GUI_Load(object sender, EventArgs e)
        {
            showtxtnv();
            Bind_Data();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            string sql = "select count(*) from Permission where IdEmployee = N'" + txtmanv.Text + "' and password = '" + txtOldPass.Text + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            errorProvider1.Clear();
            if (r[0].ToString() == "1")
            {
                if(txtPass.Text == txtConfirmPass.Text)
                {
                    string query = "update Permission set password = N'" + txtPass.Text + "' where IdEmployee = N'" + txtmanv.Text + "'";
                    db.ExecuteQuery(query);
                    MessageBox.Show("Đổi mật khẩu thành công");
                }    
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không đúng");
                }    
            }  
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            txtOldPass.Text = "";
            txtPass.Text = "";
            txtConfirmPass.Text = "";


        }

        
        
        

    }
}
