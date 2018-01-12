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
    public partial class SearchTest_Chapter : UserControl
    {
        private BaiTap_KiemTra_BLL baiTap_KiemTraBUS = new BaiTap_KiemTra_BLL();
        private MonHoc_BLL monHocBUS = new MonHoc_BLL();
        private Chuong_BLL chuongBUS = new Chuong_BLL();

        private void Delgbx()
        {
            tbxIDTest_Chapter.Text = "";
            tbxTestName_Chapter.Text = "";
            cbxChapter.EditValue = "";
            cbxSubject.EditValue = "";
            cbxChapter.ClosePopup();
            cbxSubject.ClosePopup();
            tbxIDTest_Chapter.Enabled = false;
            tbxTestName_Chapter.Enabled = false;
            cbxChapter.Enabled = false;
            cbxSubject.Enabled = false;
        }

        public SearchTest_Chapter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(radIDTest_Chapter.Checked)
            {
                dgvSearchTest_Chapter.DataSource = baiTap_KiemTraBUS.SearchTest_Chapter("MaBT_KT", tbxIDTest_Chapter.Text);
                Delgbx();
            }
            if (radChapter.Checked)
            {
                dgvSearchTest_Chapter.DataSource = baiTap_KiemTraBUS.SearchTest_Chapter("TenBT_KT", tbxIDTest_Chapter.Text);
                Delgbx();
            }
            if (radChapter.Checked)
            {
                dgvSearchTest_Chapter.DataSource = baiTap_KiemTraBUS.SearchTest_Chapter("MaChuongBK", tbxIDTest_Chapter.Text);
                Delgbx();
            }
            if (radSubject.Checked)
            {
                dgvSearchTest_Chapter.DataSource = baiTap_KiemTraBUS.SearchTest_Chapter("MaMH_BK", tbxIDTest_Chapter.Text);
                Delgbx();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SearchTest_Chapter_Load(sender, e);
        }

        private void SearchTest_Chapter_Load(object sender, EventArgs e)
        {
            cbxSubject.Properties.DataSource = monHocBUS.GetSubjectLoad();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";

            cbxChapter.Properties.DataSource = chuongBUS.GetChapterLoad();
            cbxChapter.Properties.DisplayMember = "TenChuong";
            cbxChapter.Properties.ValueMember = "MaChuong";

            dgvSearchTest_Chapter.DataSource = baiTap_KiemTraBUS.GetListTestChapter();
            Delgbx();
        }

        private void radIDTest_Chapter_CheckedChanged(object sender, EventArgs e)
        {
            if(radIDTest_Chapter.Checked==true)
            {
                tbxIDTest_Chapter.Enabled = true;
                tbxTestName_Chapter.Enabled = false;
                cbxChapter.Enabled = false;
                cbxSubject.Enabled = false;
            }
        }

        private void radTestName_Chapter_CheckedChanged(object sender, EventArgs e)
        {
            if (radTestName_Chapter.Checked == true)
            {
                tbxIDTest_Chapter.Enabled = true;
                tbxTestName_Chapter.Enabled = true;
                cbxChapter.Enabled = false;
                cbxSubject.Enabled = false;
            }
        }

        private void radChapter_CheckedChanged(object sender, EventArgs e)
        {
            if (radChapter.Checked == true)
            {
                tbxIDTest_Chapter.Enabled = true;
                tbxTestName_Chapter.Enabled = false;
                cbxChapter.Enabled = true;
                cbxSubject.Enabled = false;
            }
        }

        private void radSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (radIDTest_Chapter.Checked == true)
            {
                tbxIDTest_Chapter.Enabled = true;
                tbxTestName_Chapter.Enabled = false;
                cbxChapter.Enabled = false;
                cbxSubject.Enabled = true;
            }
        }
    }
}
