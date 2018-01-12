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
    public partial class SearchSubject : UserControl
    {
        private MonHoc_BLL monHocBUS = new MonHoc_BLL();
        private Chuong_BLL chuongBUS = new Chuong_BLL();

        private void Delgbx()
        {
            radSubject.Checked = false;
            radIDChapter.Checked = false;
            radChapter.Checked = false;
            radImportant.Checked = false;
            cbxSubject.EditValue = "";
            tbxIDChapter.Text = "";
            tbxChapter.Text = "";
            cbxImportant.EditValue = "";
            cbxSubject.Enabled = false;
            cbxImportant.Enabled = false;
            tbxIDChapter.Enabled = false;
            tbxChapter.Enabled = false;
        }
        public SearchSubject()
        {
            InitializeComponent();
        }

        private void SearchSubject_Load(object sender, EventArgs e)
        {
            cbxSubject.Properties.DataSource = monHocBUS.GetSubjectLoad();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";

            dgvSearchSubject.DataSource = chuongBUS.GetListChapter();
            Delgbx();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radSubject.Checked)
            {
                dgvSearchSubject.DataSource = chuongBUS.SearchChapter("MaMH_Chuong", cbxSubject.EditValue.ToString());
                Delgbx();
            }
            if (radIDChapter.Checked)
            {
                dgvSearchSubject.DataSource = chuongBUS.SearchChapter("MaChuong", tbxIDChapter.Text);
                Delgbx();
            }
            if (radChapter.Checked)
            {
                dgvSearchSubject.DataSource = chuongBUS.SearchChapter("TenChuong", tbxChapter.Text);
                Delgbx();
            }
            if (radImportant.Checked)
            {
                dgvSearchSubject.DataSource = chuongBUS.SearchChapter("QuanTrong", (cbxImportant.Text == "Đúng") ? "true" : "false");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SearchSubject_Load(sender, e);
        }

        private void radSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (radSubject.Checked == true)
            {
                cbxSubject.Enabled = true;
                cbxImportant.Enabled = false;
                tbxIDChapter.Enabled = false;
                tbxChapter.Enabled = false;
            }
        }

        private void radIDChapter_CheckedChanged(object sender, EventArgs e)
        {
            if (radIDChapter.Checked == true)
            {
                tbxIDChapter.Enabled = true;
                cbxSubject.Enabled = false;
                cbxImportant.Enabled = false;
                tbxChapter.Enabled = false;
            }
        }

        private void radChapter_CheckedChanged(object sender, EventArgs e)
        {
            if (radChapter.Checked == true)
            {
                tbxChapter.Enabled = true;
                cbxSubject.Enabled = false;
                cbxImportant.Enabled = false;
                tbxIDChapter.Enabled = false;
            }
        }

        private void radImportant_CheckedChanged(object sender, EventArgs e)
        {
            if (radImportant.Checked == true)
            {
                cbxImportant.Enabled = true;
                cbxSubject.Enabled = false;
                tbxIDChapter.Enabled = false;
                tbxChapter.Enabled = false;
            }
        }
    }
}
