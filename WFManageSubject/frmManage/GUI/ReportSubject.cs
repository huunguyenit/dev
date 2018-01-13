using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmManage.BLL;
using frmManage.DTO;

namespace frmManage.GUI
{
    public partial class ReportSubject : UserControl
    {
        MonHoc_BLL monHocBUS = new MonHoc_BLL();
        Chuong_BLL chuongBUS = new Chuong_BLL();

        private Chuong_DTO GetInfoChapter()
        {
            Chuong_DTO chuong = new Chuong_DTO();
            chuong.MaMH_Chuong = cbxSubject.EditValue.ToString();
            return chuong;
        }
        public ReportSubject()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Chuong_DTO chuong = GetInfoChapter();

            dgvChapter.DataSource = chuongBUS.GetListChapterRP(chuong);
            tbxSumChapter.Text = Convert.ToString(gvChapter.DataRowCount);
        }

        private void ReportSubject_Load(object sender, EventArgs e)
        {
            cbxSubject.Properties.DataSource = monHocBUS.GetSubjectLoad();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";
        }
    }
}
