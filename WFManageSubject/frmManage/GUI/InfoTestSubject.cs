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
    public partial class InfoTestSubject : UserControl
    {
        private HocSinh_BLL hocSinhBUS = new HocSinh_BLL();
        private MonHoc_BLL monHocBUS = new MonHoc_BLL();
        private HocSinh_Thi_MonHoc_BLL hocSinh_Thi_MonBUS = new HocSinh_Thi_MonHoc_BLL();
        private bool add = false, update = false;

        private void DelgbxInfo()
        {
            cbxSubject.EditValue = "";
            cbxStudent.EditValue = "";
            tbxScore.EditValue = "";
        }

        private void Binding()
        {
            cbxSubject.DataBindings.Clear();
            cbxSubject.DataBindings.Add("EditValue", dgvInfoTestSubject.DataSource, "MaMH");
            cbxStudent.DataBindings.Clear();
            cbxStudent.DataBindings.Add("EditValue", dgvInfoTestSubject.DataSource, "MaHS");
            tbxScore.DataBindings.Clear();
            tbxScore.DataBindings.Add("Text", dgvInfoTestSubject.DataSource, "DiemThi");
        }

        private HocSinh_Thi_Monhoc_DTO GetInfoTestSubject()
        {
            HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc = new HocSinh_Thi_Monhoc_DTO();
            hocSinh_Thi_Monhoc.MaMH = cbxSubject.EditValue.ToString();
            hocSinh_Thi_Monhoc.MaHS = cbxStudent.EditValue.ToString();
            hocSinh_Thi_Monhoc.DiemThi = Convert.ToInt16(tbxScore.Text);
            return hocSinh_Thi_Monhoc;
        }
        public InfoTestSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            gbxInfoTestSubject.Enabled = true;

            DelgbxInfo();
            tbxScore.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc = GetInfoTestSubject();
            if(MessageBox.Show("Bạn có muốn xoá điểm thi "+cbxSubject.Text+" không? ","Hỏi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.OK)
            {
                hocSinh_Thi_MonBUS.DelTestSubject(hocSinh_Thi_Monhoc);
                InfoTestSubject_Load(sender,e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false; update = true;
            gbxInfoTestSubject.Enabled = true;
            tbxScore.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc = GetInfoTestSubject();
            if(add)
            {
                hocSinh_Thi_MonBUS.AddTestSubject(hocSinh_Thi_Monhoc);
                InfoTestSubject_Load(sender, e);
            }
            if(update)
            {
                hocSinh_Thi_MonBUS.EditTestSubject(hocSinh_Thi_Monhoc);
                InfoTestSubject_Load(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InfoTestSubject_Load(sender, e);
        }

        private void InfoTestSubject_Load(object sender, EventArgs e)
        {
            cbxSubject.Properties.DataSource = monHocBUS.GetSubjectLoad();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";

            cbxStudent.Properties.DataSource = hocSinhBUS.GetStudentLoad();
            cbxStudent.Properties.DisplayMember = "TenHS";
            cbxStudent.Properties.ValueMember = "MaHS";

            dgvInfoTestSubject.DataSource = hocSinh_Thi_MonBUS.GetListTestSubject();
            gbxInfoTestSubject.Enabled = false;
            Binding();
        }
    }
}
