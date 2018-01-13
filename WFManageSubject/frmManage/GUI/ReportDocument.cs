using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmManage.DTO;
using frmManage.BLL;

namespace frmManage.GUI
{
    public partial class ReportDocument : UserControl
    {
        private TaiLieu_BLL taiLieuBUS = new TaiLieu_BLL();
        private Chuong_BLL chuongBUS = new Chuong_BLL();

        private TaiLieu_DTO GetInfoDocument()
        {
            TaiLieu_DTO taiLieu = new TaiLieu_DTO();
            taiLieu.MaChuong_TL = cbxChapter.EditValue.ToString();
            return taiLieu;
        }

        public ReportDocument()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           TaiLieu_DTO taiLieu = GetInfoDocument();

            dgvDocument.DataSource = taiLieuBUS.GetListDocumentRP(taiLieu);
            tbxSumDocument.Text = Convert.ToString(gvDocument.DataRowCount);
        }

        private void ReportDocument_Load(object sender, EventArgs e)
        {
            cbxChapter.Properties.DataSource = chuongBUS.GetChapterLoad();
            cbxChapter.Properties.DisplayMember = "TenChuong";
            cbxChapter.Properties.ValueMember = "MaChuong";
        }
    }
}
