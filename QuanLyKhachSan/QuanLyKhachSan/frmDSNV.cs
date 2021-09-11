using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.DAL;
using Microsoft.Reporting.WinForms;

namespace QuanLyKhachSan
{
    public partial class frmDSNV : DevExpress.XtraEditors.XtraForm
    {
        DBAccess db = new DBAccess();
        public frmDSNV()
        {
            InitializeComponent();
        }
        private DataTable getdata()
        {
            string sql = @"select IdEmployee,NamePosition,NameEmployee,DateOfBirth,GenderEmployee,PhoneNumber,IdCardEmployee,AddressEmployee,EmailEmployee
                        from Employee, Position
                        where Employee.IdPosition = Position.IdPosition";
            DataTable dtb = db.getDS(sql);
            return dtb;
        }

        private void bind()
        {
            rpvDSNV.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.ReportDSNV.rdlc";
            rpvDSNV.LocalReport.DataSources.Clear();
            ReportDataSource rpDataSource = new ReportDataSource("DataSetNhanVien", getdata());
            rpvDSNV.LocalReport.DataSources.Add(rpDataSource);
            rpvDSNV.RefreshReport();
        }
        private void frmDSNV_Load(object sender, EventArgs e)
        {
            bind();
            this.rpvDSNV.RefreshReport();
        }
    }
}