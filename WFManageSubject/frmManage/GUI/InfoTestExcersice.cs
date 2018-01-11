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
    public partial class InfoTestExcersice : UserControl
    {
        private HocSinh_BLL hocSinhBUS = new HocSinh_BLL();
        private MonHoc_BLL monHocBUS = new MonHoc_BLL();
        private NhomHocSinh_BLL nhomHocSinhBUS = new NhomHocSinh_BLL();
        private Bai_Nhom_BLL bai_NhomBUS = new Bai_Nhom_BLL();
        private Bai_CaNhan_BLL bai_CaNhanBUS = new Bai_CaNhan_BLL();
        private BaiTap_KiemTra_BLL baiTap_KiemTraBUS = new BaiTap_KiemTra_BLL();
        private Chuong_BLL chuongBUS = new Chuong_BLL();

        private bool add = false, update = false;

        //Binding dữ liệu
        public void Binding()
        {
            cbxSubject.DataBindings.Clear();
            cbxSubject.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "MaMH_BK");
            cbxChapter.DataBindings.Clear();
            cbxChapter.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "MaChuong_BK");
            tbxIDTest.DataBindings.Clear();
            tbxIDTest.DataBindings.Add("Text", dgvInfoTest.DataSource, "MaBT_KT");
            cbxTest.DataBindings.Clear();
            cbxTest.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "BaiTap");
            cbxTestGroup.DataBindings.Clear();
            cbxTestGroup.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "BaiNhom");
            tbxNameTest.DataBindings.Clear();
            tbxNameTest.DataBindings.Add("Text", dgvInfoTest.DataSource, "TenBT_KT");
            cbxStudent.DataBindings.Clear();
            cbxStudent.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "MaHS_BK");
            tbxScore.DataBindings.Clear();
            tbxScore.DataBindings.Add("Text", dgvInfoTest.DataSource, "DiemBT_KT");
            cbxNameGroup.DataBindings.Clear();
            cbxNameGroup.DataBindings.Add("EditValue", dgvInfoTest.DataSource, "MaNhom_BK");
        }

        #region Lấy thông tin bài kiểm tra và bài tập
        //Bài trong từng chương
        private BaiTap_KiemTra_DTO GetInfoTest_Chapter()
        {
            BaiTap_KiemTra_DTO baiTap_KiemTra = new BaiTap_KiemTra_DTO();

            baiTap_KiemTra.MaBT_KT = tbxIDTest.EditValue.ToString();
            baiTap_KiemTra.TenBT_KT = tbxNameTest.Text;
            baiTap_KiemTra.MaChuong_BK = cbxChapter.EditValue.ToString();
            if (tbxScore.Text == "")
            {
                tbxScore.Text = "1";
            }

            baiTap_KiemTra.DiemBT_KT = Convert.ToInt16(tbxScore.Text);
            baiTap_KiemTra.MaMH_BK = cbxSubject.EditValue.ToString();
            baiTap_KiemTra.MaHS_BK = cbxStudent.EditValue.ToString();
            baiTap_KiemTra.MaNhom_BK = cbxNameGroup.EditValue.ToString();
            if(baiTap_KiemTra.MaNhom_BK=="")
            {
                baiTap_KiemTra.MaNhom_BK = "null";
            }
            else
            {
                string temp = baiTap_KiemTra.MaNhom_BK;
                temp = "'" + temp + "'";
                baiTap_KiemTra.MaNhom_BK = temp;
            }
            baiTap_KiemTra.BaiNhom = (cbxTest.Text == "Nhóm") ? 1 : 0;
            baiTap_KiemTra.BaiTap = (cbxTestGroup.Text == "Bài tập") ? 1 : 0;

            return baiTap_KiemTra;
        }
        #endregion
        public InfoTestExcersice()
        {
            InitializeComponent();
        }

        private void InfoTest_Load(object sender, EventArgs e)
        {
            cbxSubject.Properties.DataSource = monHocBUS.GetSubjectLoad();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";

            cbxChapter.Properties.DataSource = chuongBUS.GetChapterLoad();
            cbxChapter.Properties.DisplayMember = "TenChuong";
            cbxChapter.Properties.ValueMember = "MaChuong";

            cbxNameGroup.Properties.DataSource = nhomHocSinhBUS.GetGroupLoad();
            cbxNameGroup.Properties.DisplayMember = "TenNhom";
            cbxNameGroup.Properties.ValueMember = "MaNhom";

            cbxStudent.Properties.DataSource = hocSinhBUS.GetStudentLoad();
            cbxStudent.Properties.DisplayMember = "TenHS";
            cbxStudent.Properties.ValueMember = "MaHS";

            dgvInfoTest.DataSource = baiTap_KiemTraBUS.GetListTestChapter_Load();
            gbxInfoTestExersice.Enabled = false;
            Binding();
        }

        public void DelgbxInfo()
        {
            cbxSubject.Text = "";
            cbxChapter.Text = "";
            cbxTest.Text = "";
            cbxTestGroup.Text = "";
            cbxNameGroup.Text = "";
            tbxNameTest.Text = "";
            cbxStudent.Text = "";
            tbxScore.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            gbxInfoTestExersice.Enabled = true;

            tbxIDTest.Text = baiTap_KiemTraBUS.NextID();
            DelgbxInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BaiTap_KiemTra_DTO baiTap_KiemTra = GetInfoTest_Chapter();

            if (MessageBox.Show("Bạn có muốn xoá Chương : " + tbxNameTest.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baiTap_KiemTraBUS.DelTest_Chapter(baiTap_KiemTra);
                InfoTest_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            gbxInfoTestExersice.Enabled = true;
            tbxNameTest.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BaiTap_KiemTra_DTO baiTap_KiemTra = GetInfoTest_Chapter();
            if (add)
            {
                baiTap_KiemTraBUS.AddTest_Chapter(baiTap_KiemTra);
                InfoTest_Load(sender, e);
            }
            if (update)
            {
                baiTap_KiemTraBUS.EditTest_Chapter(baiTap_KiemTra);
                InfoTest_Load(sender, e);

            }
        }

        private void tbxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InfoTest_Load(sender, e);
        }
    }
}
