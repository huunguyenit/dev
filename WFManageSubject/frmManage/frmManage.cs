﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using frmManage.BLL;
using frmManage.DTO;

namespace frmManage
{
    public partial class frmManage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd();
        frmLogin loginform = null;
        GiaoVien_BLL gvBUS = new GiaoVien_BLL();

        public frmManage()
        {
            InitializeComponent();
        }
        #region "Code cho nut Close xtraTabControl"
        // Đóng tab đang focus trên TAb Cha
        private void tcView_CloseButtonClick_1(object sender, EventArgs e)
        {
            tcView.TabPages.RemoveAt(tcView.SelectedTabPageIndex);
        }
        // Khi add vào thì Focus tới ngay Tab vừa Add
        private void tcView_ControlAdded(object sender, ControlEventArgs e)
        {
            tcView.SelectedTabPageIndex = tcView.TabPages.Count - 1;
        }
        #endregion

        #region Hàm xử lý login

        public void Hidebtn(bool logged)
        {
            btnLogin.Enabled = !logged;
            btnChangePassWord.Enabled = logged;
            btnExit.Enabled = logged;
            btnInfoSubject.Enabled = logged;
            btnInfoDocument.Enabled = logged;
            btnInfoTest_Exercise.Enabled = logged;
            //
            btnSearchSubject.Enabled = logged;
            btnSearchDocument.Enabled = logged;
            btnSearchTest_Exercise.Enabled = logged;
            //
            btnReportSubject.Enabled = logged;
            btnReportDocumnet.Enabled = logged;
            btnReportTest_Exercise.Enabled = logged;
        }

        #endregion
        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Khởi tạo biến Continue
            Cont:
            //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
            if (loginform == null || loginform.IsDisposed)
                loginform = new frmLogin();
            if (loginform.ShowDialog() == DialogResult.OK)
            {
                loginform.tbxUserName.Focus();
                string MaGV = loginform.tbxUserName.Text + "     ";
                string MatKhau = loginform.tbxPassWord.Text + "     ";

                //Lấy thông tin nhân viên
                Utilities.user = gvBUS.GetInfoLogin(MaGV);
                //Trường hợp Mã NV không tồn tại
                if (Utilities.user.MaGV != MaGV)
                {
                    // Gán thông báo cho label Thông báo
                    loginform.lblStatusLogin.Text = "Tên Đăng nhập không tồn tại!";
                    goto Cont;
                }
                //Trường hợp Mật khẩu không đúng
                if (Utilities.user.MatKhau != MatKhau)
                {
                    loginform.lblStatusLogin.Text = " Mật khẩu không đúng !";
                    goto Cont;
                }
                //Trường hợp đăng nhập thành công
                //Set lại menu theo quyền  
                Hidebtn(true);
            }
        }

        private void btnChangePassWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tcView.TabPages)
            {
                if (tab.Text == "Cập nhật Mật khẩu")
                {
                    tcView.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.AddTab(tcView, "Cập nhật Mật khẩu", new GUI.ChangePassword());
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Khởi tạo lại biến user dùng chung
            GiaoVien_DTO user = new GiaoVien_DTO();
            // Gọi lại Ẩn menu
            Hidebtn(false);
            //Đóng tất cả các tab đang mở 
            tcView.TabPages.Clear();
            //Mở lại form đăng nhập
            btnLogin_ItemClick(sender, e);
        }
    }
}