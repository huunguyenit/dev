using DevExpress.XtraBars;

namespace frmManage
{
    partial class frmManageSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubject));
            this.rbcMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfoSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfoDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfoTest_Exercise = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportTest_Exercise = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportDocumnet = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchTest_Exercise = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.btnInfoChapter = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportChapter = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfoTest = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportTest = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchTest = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSearch = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tcView = new DevExpress.XtraTab.XtraTabControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcView)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMenu
            // 
            this.rbcMenu.BackColor = System.Drawing.Color.Red;
            this.rbcMenu.ExpandCollapseItem.Id = 0;
            this.rbcMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMenu.ExpandCollapseItem,
            this.btnLogin,
            this.btnChangePassWord,
            this.btnExit,
            this.btnInfoSubject,
            this.btnInfoDocument,
            this.btnInfoTest_Exercise,
            this.btnReportTest_Exercise,
            this.btnReportDocumnet,
            this.btnReportSubject,
            this.btnSearchSubject,
            this.btnSearchDocument,
            this.btnSearchTest_Exercise,
            this.barHeaderItem1,
            this.btnInfoChapter,
            this.btnReportChapter,
            this.btnInfoTest,
            this.btnReportTest,
            this.btnSearchTest});
            this.rbcMenu.Location = new System.Drawing.Point(0, 0);
            this.rbcMenu.MaxItemId = 20;
            this.rbcMenu.Name = "rbcMenu";
            this.rbcMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHome,
            this.rbpReport,
            this.rbpSearch});
            this.rbcMenu.Size = new System.Drawing.Size(854, 149);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgChangeKey;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Caption = "Đổi mật khẩu";
            this.btnChangePassWord.Enabled = false;
            this.btnChangePassWord.Id = 2;
            this.btnChangePassWord.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgChangPass;
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassWord_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Enabled = false;
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgLogout;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnInfoSubject
            // 
            this.btnInfoSubject.Caption = "Thông tin môn học";
            this.btnInfoSubject.Enabled = false;
            this.btnInfoSubject.Id = 4;
            this.btnInfoSubject.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgSubject;
            this.btnInfoSubject.Name = "btnInfoSubject";
            // 
            // btnInfoDocument
            // 
            this.btnInfoDocument.Caption = "Thông tin tài liệu";
            this.btnInfoDocument.Enabled = false;
            this.btnInfoDocument.Id = 5;
            this.btnInfoDocument.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgfolderdocument;
            this.btnInfoDocument.Name = "btnInfoDocument";
            this.btnInfoDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfoDocument_ItemClick);
            // 
            // btnInfoTest_Exercise
            // 
            this.btnInfoTest_Exercise.Caption = "Bài tập, bài kiểm tra";
            this.btnInfoTest_Exercise.Enabled = false;
            this.btnInfoTest_Exercise.Id = 6;
            this.btnInfoTest_Exercise.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgTestColor;
            this.btnInfoTest_Exercise.Name = "btnInfoTest_Exercise";
            this.btnInfoTest_Exercise.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfoTest_Exercise_ItemClick);
            // 
            // btnReportTest_Exercise
            // 
            this.btnReportTest_Exercise.Caption = "Bài tập, bài kiểm tra";
            this.btnReportTest_Exercise.Enabled = false;
            this.btnReportTest_Exercise.Id = 7;
            this.btnReportTest_Exercise.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgTestColor;
            this.btnReportTest_Exercise.Name = "btnReportTest_Exercise";
            // 
            // btnReportDocumnet
            // 
            this.btnReportDocumnet.Caption = "Tài liệu";
            this.btnReportDocumnet.Enabled = false;
            this.btnReportDocumnet.Id = 8;
            this.btnReportDocumnet.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgfolderdocument;
            this.btnReportDocumnet.Name = "btnReportDocumnet";
            // 
            // btnReportSubject
            // 
            this.btnReportSubject.Caption = "Chương";
            this.btnReportSubject.Enabled = false;
            this.btnReportSubject.Id = 9;
            this.btnReportSubject.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgSubject1;
            this.btnReportSubject.Name = "btnReportSubject";
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.Caption = "Môn học";
            this.btnSearchSubject.Enabled = false;
            this.btnSearchSubject.Id = 10;
            this.btnSearchSubject.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgSearchSubject;
            this.btnSearchSubject.Name = "btnSearchSubject";
            // 
            // btnSearchDocument
            // 
            this.btnSearchDocument.Caption = "Tài liệu";
            this.btnSearchDocument.Enabled = false;
            this.btnSearchDocument.Id = 11;
            this.btnSearchDocument.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgSearchChapter;
            this.btnSearchDocument.Name = "btnSearchDocument";
            // 
            // btnSearchTest_Exercise
            // 
            this.btnSearchTest_Exercise.Caption = "Bài kiểm tra, bài tập";
            this.btnSearchTest_Exercise.Enabled = false;
            this.btnSearchTest_Exercise.Id = 12;
            this.btnSearchTest_Exercise.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgSearchTest;
            this.btnSearchTest_Exercise.Name = "btnSearchTest_Exercise";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 13;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // btnInfoChapter
            // 
            this.btnInfoChapter.Caption = "Thông tin chương";
            this.btnInfoChapter.Enabled = false;
            this.btnInfoChapter.Id = 15;
            this.btnInfoChapter.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgChaterBook;
            this.btnInfoChapter.Name = "btnInfoChapter";
            this.btnInfoChapter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfoChapter_ItemClick);
            // 
            // btnReportChapter
            // 
            this.btnReportChapter.Caption = "Chương";
            this.btnReportChapter.Enabled = false;
            this.btnReportChapter.Id = 16;
            this.btnReportChapter.Name = "btnReportChapter";
            // 
            // btnInfoTest
            // 
            this.btnInfoTest.Caption = "Bài thi";
            this.btnInfoTest.Enabled = false;
            this.btnInfoTest.Id = 17;
            this.btnInfoTest.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgPen;
            this.btnInfoTest.Name = "btnInfoTest";
            this.btnInfoTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfoTest_ItemClick);
            // 
            // btnReportTest
            // 
            this.btnReportTest.Caption = "Bài thi";
            this.btnReportTest.Enabled = false;
            this.btnReportTest.Id = 18;
            this.btnReportTest.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgPen;
            this.btnReportTest.Name = "btnReportTest";
            // 
            // btnSearchTest
            // 
            this.btnSearchTest.Caption = "Bài thi";
            this.btnSearchTest.Enabled = false;
            this.btnSearchTest.Id = 19;
            this.btnSearchTest.ImageOptions.LargeImage = global::frmManage.Properties.Resources.imgPen1;
            this.btnSearchTest.Name = "btnSearchTest";
            // 
            // rbpHome
            // 
            this.rbpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbpHome.ImageOptions.Image = global::frmManage.Properties.Resources.imgPageHome;
            this.rbpHome.Name = "rbpHome";
            this.rbpHome.Text = "Trang chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassWord);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfoChapter);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfoDocument);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfoTest_Exercise);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfoTest);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý";
            // 
            // rbpReport
            // 
            this.rbpReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpReport.Name = "rbpReport";
            this.rbpReport.Text = "Báo cáo - Thống kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReportSubject);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReportDocumnet);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReportTest_Exercise);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReportTest);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpSearch
            // 
            this.rbpSearch.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpSearch.Name = "rbpSearch";
            this.rbpSearch.Text = "Tìm kiếm";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchSubject);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchDocument);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchTest_Exercise);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchTest);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // tcView
            // 
            this.tcView.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tcView.Appearance.Options.UseBackColor = true;
            this.tcView.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.tcView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcView.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.tcView.Location = new System.Drawing.Point(0, 149);
            this.tcView.Name = "tcView";
            this.tcView.Size = new System.Drawing.Size(854, 386);
            this.tcView.TabIndex = 1;
            this.tcView.CloseButtonClick += new System.EventHandler(this.tcView_CloseButtonClick_1);
            this.tcView.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tcView_ControlAdded);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // frmManageSubject
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.tcView);
            this.Controls.Add(this.rbcMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSubject";
            this.Ribbon = this.rbcMenu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nội dung môn học";
            ((System.ComponentModel.ISupportInitialize)(this.rbcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePassWord;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnInfoSubject;
        private DevExpress.XtraBars.BarButtonItem btnInfoDocument;
        private DevExpress.XtraBars.BarButtonItem btnInfoTest_Exercise;
        private DevExpress.XtraBars.BarButtonItem btnReportTest_Exercise;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnReportDocumnet;
        private DevExpress.XtraBars.BarButtonItem btnReportSubject;
        private DevExpress.XtraBars.BarButtonItem btnSearchSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnSearchDocument;
        private DevExpress.XtraBars.BarButtonItem btnSearchTest_Exercise;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraTab.XtraTabControl tcView;
        private BarButtonItem btnInfoChapter;
        private BarButtonItem btnReportChapter;
        private BarButtonItem btnInfoTest;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private BarButtonItem btnReportTest;
        private BarButtonItem btnSearchTest;
    }
}

