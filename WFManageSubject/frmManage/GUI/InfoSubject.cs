using System.Windows.Forms;
using frmManage.BLL;
using frmManage.DTO;

namespace frmManage.GUI
{
    public partial class InfoSubject : UserControl
    {
        private Chuong_BLL cBUS = new Chuong_BLL();
        private MonHoc_BLL mhBUS = new MonHoc_BLL();

        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void Deltbx()
        {
            cbxImportant.TabIndex = 1;
            tbxIdChapter.Text = "";
            tbxChapter.Text = "";
            cbxSubject.TabIndex = 1;
        }

        //Binding dữ liệu
        public void Binding()
        {
            tbxChapter.DataBindings.Clear();
            tbxChapter.DataBindings.Add("Text", dgvChapter.DataSource, "gcChapter");
            cbxImportant.DataBindings.Clear();
            cbxImportant.DataBindings.Add("EditValue", dgvChapter.DataSource, "gcImportant");
        }

        //Lấy Thông tin Chuong
        private Chuong_DTO GetInfoChapter()
        {
            Chuong_DTO c = new Chuong_DTO();
            c.MaChuong = tbxIdChapter.Text;
            c.TenChuong = tbxChapter.Text;
            c.MaMH_Chuong = cbxSubject.EditValue.ToString();
            c.QuangTrong = (cbxImportant.Text == "Đúng") ? 1 : 0;
            return c;
        }

        private void InfoSubject_Load(object sender, System.EventArgs e)
        {
            //Load combobox Môn học
            cbxSubject.Properties.DataSource = mhBUS.GetListSubject();
            cbxSubject.Properties.DisplayMember = "TenMH";
            cbxSubject.Properties.ValueMember = "MaMH";

            //Load combobox dgvChapter
            dgvChapter.DataSource = cBUS.GetListChapter();
            gbxFunction.Enabled = false;
            Binding();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            add = true; update = false;
            gbxFunction.Enabled = true;
            //Load NextID len tbxIDChapter
            tbxIdChapter.Text = cBUS.NextID();
            Deltbx();
            tbxChapter.Focus();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá Chương : "+tbxChapter.Text + "không?","Hỏi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cBUS.DelChapter(tbxIdChapter.Text);
                InfoSubject_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            update = true; add = false;
            gbxFunction.Enabled = true;
            tbxChapter.Focus();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Chuong_DTO c = GetInfoChapter();
            if(add)
            {
                cBUS.AddChapter(c);
                InfoSubject_Load(sender, e);
            }
            if(update)
            {
                cBUS.EditChapter(c);
                InfoSubject_Load(sender, e);

            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            InfoSubject_Load(sender, e);
        }

        public InfoSubject()
        {
            InitializeComponent();
        }
    }
}
