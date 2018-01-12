namespace frmManage.GUI
{
    partial class SearchTest_Chapter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTest_Chapter));
            this.gbxSearchTest_Chapter = new DevExpress.XtraEditors.GroupControl();
            this.radIDTest_Chapter = new System.Windows.Forms.RadioButton();
            this.radTestName_Chapter = new System.Windows.Forms.RadioButton();
            this.radChapter = new System.Windows.Forms.RadioButton();
            this.radSubject = new System.Windows.Forms.RadioButton();
            this.tbxIDTest_Chapter = new DevExpress.XtraEditors.TextEdit();
            this.tbxTestName_Chapter = new DevExpress.XtraEditors.TextEdit();
            this.cbxChapter = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAll = new DevExpress.XtraEditors.SimpleButton();
            this.dgvSearchTest_Chapter = new DevExpress.XtraGrid.GridControl();
            this.gvSearchTest_Chapter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTypeTest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIDSemester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTestGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIDTest = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchTest_Chapter)).BeginInit();
            this.gbxSearchTest_Chapter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDTest_Chapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTestName_Chapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTest_Chapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchTest_Chapter)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearchTest_Chapter
            // 
            this.gbxSearchTest_Chapter.Controls.Add(this.btnShowAll);
            this.gbxSearchTest_Chapter.Controls.Add(this.btnSearch);
            this.gbxSearchTest_Chapter.Controls.Add(this.cbxSubject);
            this.gbxSearchTest_Chapter.Controls.Add(this.cbxChapter);
            this.gbxSearchTest_Chapter.Controls.Add(this.tbxTestName_Chapter);
            this.gbxSearchTest_Chapter.Controls.Add(this.tbxIDTest_Chapter);
            this.gbxSearchTest_Chapter.Controls.Add(this.radSubject);
            this.gbxSearchTest_Chapter.Controls.Add(this.radChapter);
            this.gbxSearchTest_Chapter.Controls.Add(this.radTestName_Chapter);
            this.gbxSearchTest_Chapter.Controls.Add(this.radIDTest_Chapter);
            this.gbxSearchTest_Chapter.Location = new System.Drawing.Point(3, 3);
            this.gbxSearchTest_Chapter.Name = "gbxSearchTest_Chapter";
            this.gbxSearchTest_Chapter.Size = new System.Drawing.Size(824, 163);
            this.gbxSearchTest_Chapter.TabIndex = 0;
            this.gbxSearchTest_Chapter.Text = "Tìm kiếm bài tập, bài kiểm tra";
            // 
            // radIDTest_Chapter
            // 
            this.radIDTest_Chapter.AutoSize = true;
            this.radIDTest_Chapter.Location = new System.Drawing.Point(200, 40);
            this.radIDTest_Chapter.Name = "radIDTest_Chapter";
            this.radIDTest_Chapter.Size = new System.Drawing.Size(56, 17);
            this.radIDTest_Chapter.TabIndex = 0;
            this.radIDTest_Chapter.TabStop = true;
            this.radIDTest_Chapter.Text = "Mã bài";
            this.radIDTest_Chapter.UseVisualStyleBackColor = true;
            this.radIDTest_Chapter.CheckedChanged += new System.EventHandler(this.radIDTest_Chapter_CheckedChanged);
            // 
            // radTestName_Chapter
            // 
            this.radTestName_Chapter.AutoSize = true;
            this.radTestName_Chapter.Location = new System.Drawing.Point(200, 65);
            this.radTestName_Chapter.Name = "radTestName_Chapter";
            this.radTestName_Chapter.Size = new System.Drawing.Size(60, 17);
            this.radTestName_Chapter.TabIndex = 1;
            this.radTestName_Chapter.TabStop = true;
            this.radTestName_Chapter.Text = "Tên bài";
            this.radTestName_Chapter.UseVisualStyleBackColor = true;
            this.radTestName_Chapter.CheckedChanged += new System.EventHandler(this.radTestName_Chapter_CheckedChanged);
            // 
            // radChapter
            // 
            this.radChapter.AutoSize = true;
            this.radChapter.Location = new System.Drawing.Point(200, 90);
            this.radChapter.Name = "radChapter";
            this.radChapter.Size = new System.Drawing.Size(63, 17);
            this.radChapter.TabIndex = 1;
            this.radChapter.TabStop = true;
            this.radChapter.Text = "Chương";
            this.radChapter.UseVisualStyleBackColor = true;
            this.radChapter.CheckedChanged += new System.EventHandler(this.radChapter_CheckedChanged);
            // 
            // radSubject
            // 
            this.radSubject.AutoSize = true;
            this.radSubject.Location = new System.Drawing.Point(200, 115);
            this.radSubject.Name = "radSubject";
            this.radSubject.Size = new System.Drawing.Size(65, 17);
            this.radSubject.TabIndex = 1;
            this.radSubject.TabStop = true;
            this.radSubject.Text = "Môn học";
            this.radSubject.UseVisualStyleBackColor = true;
            this.radSubject.CheckedChanged += new System.EventHandler(this.radSubject_CheckedChanged);
            // 
            // tbxIDTest_Chapter
            // 
            this.tbxIDTest_Chapter.Location = new System.Drawing.Point(285, 40);
            this.tbxIDTest_Chapter.Name = "tbxIDTest_Chapter";
            this.tbxIDTest_Chapter.Size = new System.Drawing.Size(251, 20);
            this.tbxIDTest_Chapter.TabIndex = 2;
            // 
            // tbxTestName_Chapter
            // 
            this.tbxTestName_Chapter.Location = new System.Drawing.Point(285, 65);
            this.tbxTestName_Chapter.Name = "tbxTestName_Chapter";
            this.tbxTestName_Chapter.Size = new System.Drawing.Size(251, 20);
            this.tbxTestName_Chapter.TabIndex = 3;
            // 
            // cbxChapter
            // 
            this.cbxChapter.Location = new System.Drawing.Point(285, 90);
            this.cbxChapter.Name = "cbxChapter";
            this.cbxChapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChapter.Size = new System.Drawing.Size(251, 20);
            this.cbxChapter.TabIndex = 4;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(285, 115);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(251, 20);
            this.cbxSubject.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::frmManage.Properties.Resources.if_search_find_61674;
            this.btnSearch.Location = new System.Drawing.Point(640, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.ImageOptions.Image = global::frmManage.Properties.Resources.if_search_b_44994;
            this.btnShowAll.Location = new System.Drawing.Point(640, 100);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(135, 45);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvSearchTest_Chapter
            // 
            this.dgvSearchTest_Chapter.Location = new System.Drawing.Point(3, 172);
            this.dgvSearchTest_Chapter.MainView = this.gvSearchTest_Chapter;
            this.dgvSearchTest_Chapter.Name = "dgvSearchTest_Chapter";
            this.dgvSearchTest_Chapter.Size = new System.Drawing.Size(824, 178);
            this.dgvSearchTest_Chapter.TabIndex = 8;
            this.dgvSearchTest_Chapter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSearchTest_Chapter});
            // 
            // gvSearchTest_Chapter
            // 
            this.gvSearchTest_Chapter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcChapter,
            this.gcSubject,
            this.gcTypeTest,
            this.gcScore,
            this.gcStudent,
            this.gcGroup,
            this.gcIDSemester,
            this.gcTestGroup,
            this.gcIDTest});
            this.gvSearchTest_Chapter.GridControl = this.dgvSearchTest_Chapter;
            this.gvSearchTest_Chapter.Name = "gvSearchTest_Chapter";
            this.gvSearchTest_Chapter.OptionsView.ShowGroupPanel = false;
            // 
            // gcChapter
            // 
            this.gcChapter.Caption = "Chương";
            this.gcChapter.FieldName = "MaChuong_BK";
            this.gcChapter.Name = "gcChapter";
            this.gcChapter.Visible = true;
            this.gcChapter.VisibleIndex = 1;
            this.gcChapter.Width = 65;
            // 
            // gcSubject
            // 
            this.gcSubject.Caption = "Môn học";
            this.gcSubject.FieldName = "MaMH_BK";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 0;
            this.gcSubject.Width = 56;
            // 
            // gcTypeTest
            // 
            this.gcTypeTest.Caption = "Loại";
            this.gcTypeTest.FieldName = "BaiTap";
            this.gcTypeTest.Name = "gcTypeTest";
            this.gcTypeTest.Visible = true;
            this.gcTypeTest.VisibleIndex = 4;
            this.gcTypeTest.Width = 76;
            // 
            // gcScore
            // 
            this.gcScore.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcScore.Caption = "Điểm";
            this.gcScore.FieldName = "DiemBT_KT";
            this.gcScore.Name = "gcScore";
            this.gcScore.Visible = true;
            this.gcScore.VisibleIndex = 8;
            this.gcScore.Width = 81;
            // 
            // gcStudent
            // 
            this.gcStudent.Caption = "Học sinh";
            this.gcStudent.FieldName = "MaHS_BK";
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Visible = true;
            this.gcStudent.VisibleIndex = 7;
            this.gcStudent.Width = 62;
            // 
            // gcGroup
            // 
            this.gcGroup.Caption = "Nhóm";
            this.gcGroup.FieldName = "MaNhom_BK";
            this.gcGroup.Name = "gcGroup";
            this.gcGroup.Visible = true;
            this.gcGroup.VisibleIndex = 6;
            this.gcGroup.Width = 63;
            // 
            // gcIDSemester
            // 
            this.gcIDSemester.Caption = "Tên bài";
            this.gcIDSemester.FieldName = "TenBT_KT";
            this.gcIDSemester.Name = "gcIDSemester";
            this.gcIDSemester.Visible = true;
            this.gcIDSemester.VisibleIndex = 3;
            this.gcIDSemester.Width = 141;
            // 
            // gcTestGroup
            // 
            this.gcTestGroup.Caption = "Bài nhóm";
            this.gcTestGroup.FieldName = "BaiNhom";
            this.gcTestGroup.Name = "gcTestGroup";
            this.gcTestGroup.Visible = true;
            this.gcTestGroup.VisibleIndex = 5;
            this.gcTestGroup.Width = 73;
            // 
            // gcIDTest
            // 
            this.gcIDTest.Caption = "Mã bài";
            this.gcIDTest.FieldName = "MaBT_KT";
            this.gcIDTest.Name = "gcIDTest";
            this.gcIDTest.Visible = true;
            this.gcIDTest.VisibleIndex = 2;
            this.gcIDTest.Width = 74;
            // 
            // SearchTest_Chapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvSearchTest_Chapter);
            this.Controls.Add(this.gbxSearchTest_Chapter);
            this.Name = "SearchTest_Chapter";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.SearchTest_Chapter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchTest_Chapter)).EndInit();
            this.gbxSearchTest_Chapter.ResumeLayout(false);
            this.gbxSearchTest_Chapter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDTest_Chapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTestName_Chapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTest_Chapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchTest_Chapter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxSearchTest_Chapter;
        private System.Windows.Forms.RadioButton radTestName_Chapter;
        private System.Windows.Forms.RadioButton radIDTest_Chapter;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private DevExpress.XtraEditors.LookUpEdit cbxChapter;
        private DevExpress.XtraEditors.TextEdit tbxTestName_Chapter;
        private DevExpress.XtraEditors.TextEdit tbxIDTest_Chapter;
        private System.Windows.Forms.RadioButton radSubject;
        private System.Windows.Forms.RadioButton radChapter;
        private DevExpress.XtraEditors.SimpleButton btnShowAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl dgvSearchTest_Chapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSearchTest_Chapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcTypeTest;
        private DevExpress.XtraGrid.Columns.GridColumn gcScore;
        private DevExpress.XtraGrid.Columns.GridColumn gcStudent;
        private DevExpress.XtraGrid.Columns.GridColumn gcGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDSemester;
        private DevExpress.XtraGrid.Columns.GridColumn gcTestGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDTest;
    }
}
