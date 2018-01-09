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
    public partial class ChangePassword : UserControl
    {
        GiaoVien_BLL gvBUS = new GiaoVien_BLL();

        public ChangePassword()
        {
            InitializeComponent();
        }
        

        //Reset textbox
        public void Cleantbx()
        {
            tbxOldPassword.Text = "";
            tbxNewPassword.Text = "";
            tbxReNewPassword.Text = "";
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            tbxOldPassword.Focus();
        }

        //Kiểm tra Mật khẩu
        public bool CheckPassword()
        {
            Cont:
            string oldPass = tbxOldPassword.Text + "     ";
            string newPass = tbxNewPassword.Text + "     ";
            string reNewPass = tbxReNewPassword.Text + "     ";
            //Kiểm tra thông tin nhập trên Form đày đủ chưa
            if (oldPass == "" || newPass == "" || reNewPass == "")
            {
                lblStatusChangePassword.Text = "Bạn chưa điền đầy đủ các thông tin !";
                return false;
                goto Cont;
            }
            if (newPass != reNewPass)
            {
                lblStatusChangePassword.Text = "Mật khẩu mới không khớp nhau !";
                return false;
                goto Cont;
            }

            //Kiểm tra mật khẩu cũ có khớp không
            if (Utilities.user.MatKhau != oldPass)
            {
                lblStatusChangePassword.Text = "Mật khẩu cũ không đúng !";
                return false;
                goto Cont;
            }
            return true;
        }

        private void btnAcceptChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                gvBUS.ChangePassWord(tbxNewPassword.Text);
                lblStatusChangePassword.Text = "Đã đổi mật khẩu thành công !";
                Cleantbx();
            }
        }

        private void btnCancelChangePass_Click(object sender, EventArgs e)
        {
            Cleantbx();
        }
    }
}
