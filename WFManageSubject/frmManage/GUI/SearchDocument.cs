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
    public partial class SearchDocument : UserControl
    {
        private TaiLieu_BLL taiLieuBUS = new TaiLieu_BLL();
        private Chuong_BLL chuongBUS = new Chuong_BLL();

        public void DelgbxSearh()
        {
            tbxDocument.Text = "";
            cbxChapter.EditValue = "";
            cbxImportant.EditValue = "";
            tbxDocument.Enabled = false;
            cbxChapter.Enabled = false;
            cbxImportant.Enabled = false;
            cbxChapter.ClosePopup();
            cbxImportant.ClosePopup();
            radDocument.Checked = false;
            radChapter.Checked = false;
            radImportant.Checked = false;
        }
        public SearchDocument()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(radChapter.Checked)
            {
                dgvDocument.DataSource = taiLieuBUS.SearchDocument("MaChuong_TL", cbxChapter.EditValue.ToString());
                DelgbxSearh();
            }
            if (radDocument.Checked)
            {
                dgvDocument.DataSource = taiLieuBUS.SearchDocument("TenTL", tbxDocument.Text);
                DelgbxSearh()
            }
            if (radImportant.Checked)
            {
                dgvDocument.DataSource = taiLieuBUS.SearchDocument("QuanTrong", (cbxImportant.Text == "Đúng") ? "true" : "false");
                DelgbxSearh();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SearchDocument_Load(sender, e);
        }

        private void SearchDocument_Load(object sender, EventArgs e)
        {
            cbxChapter.Properties.DataSource = chuongBUS.GetChapterLoad();
            cbxChapter.Properties.DisplayMember = "TenChuong";
            cbxChapter.Properties.ValueMember = "MaChuong";

            dgvDocument.DataSource = taiLieuBUS.GetListDocument();
            DelgbxSearh();
        }

        private void radChapter_CheckedChanged(object sender, EventArgs e)
        {
            if(radChapter.Checked == true)
            {
                cbxChapter.Enabled = true;
            }
        }

        private void radDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (radDocument.Checked == true)
            {
                tbxDocument.Enabled = true;
            }
        }

        private void radImportant_CheckedChanged(object sender, EventArgs e)
        {
            if (radImportant.Checked == true)
            {
                cbxImportant.Enabled = true;
            }
        }
    }
}
