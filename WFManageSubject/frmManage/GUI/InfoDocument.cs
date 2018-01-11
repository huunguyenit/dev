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
    public partial class InfoDocument : UserControl
    {
        private Chuong_BLL cBUS = new Chuong_BLL();
        private TaiLieu_BLL tlBUS = new TaiLieu_BLL();

        private bool add = false, update = false;

        public void Deltbx()
        {
            tbxDocument.Text = "";
            cbxImportant.Text = "";
        }

        public void Binding()
        {
            cbxChapter.DataBindings.Clear();
            cbxChapter.DataBindings.Add("EditValue", dgvDocument.DataSource, "MaChuong_TL");
            tbxDocument.DataBindings.Clear();
            tbxDocument.DataBindings.Add("Text", dgvDocument.DataSource, "TenTL");
            cbxImportant.DataBindings.Clear();
            cbxImportant.DataBindings.Add("EditValue", dgvDocument.DataSource, "QuanTrong");
        }

        private TaiLieu_DTO GetInfoDocument()
        {
            TaiLieu_DTO tl = new TaiLieu_DTO();
            tl.TenTL = tbxDocument.Text;
            tl.MaChuong_TL = cbxChapter.EditValue.ToString();
            tl.QuanTrong = (cbxImportant.Text == "Đúng") ? 1 : 0;
            return tl;
        }
        public InfoDocument()
        {
            InitializeComponent();
        }

        private void InfoDocument_Load(object sender, EventArgs e)
        {
            cbxChapter.Properties.DataSource = cBUS.GetChapterLoad();
            cbxChapter.Properties.DisplayMember = "TenChuong";
            cbxChapter.Properties.ValueMember = "MaChuong";

            dgvDocument.DataSource = tlBUS.GetListDocument();
            gbxInfoDocument.Enabled = false;
            Binding();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            gbxInfoDocument.Enabled = true;
            //Load NextID len tbxIDChapter
            Deltbx();
            tbxDocument.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TaiLieu_DTO tl = GetInfoDocument();

            if (MessageBox.Show("Bạn có muốn xoá Chương : " + tbxDocument.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tlBUS.DelDocument(tl);
                InfoDocument_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            gbxInfoDocument.Enabled = true;
            tbxDocument.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaiLieu_DTO tl = GetInfoDocument();
            if (add)
            {
                tlBUS.AddDocument(tl);
                InfoDocument_Load(sender, e);
            }
            if (update)
            {
                tlBUS.EditDocument(tl);
                InfoDocument_Load(sender, e);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InfoDocument_Load(sender, e);
        }
    }
}
