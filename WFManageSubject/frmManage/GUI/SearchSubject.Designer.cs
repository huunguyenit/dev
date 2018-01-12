namespace frmManage.GUI
{
    partial class SearchSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSubject));
            this.dgvSearchSubject = new DevExpress.XtraGrid.GridControl();
            this.gvSearchSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIDChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbxSearchSubject = new DevExpress.XtraEditors.GroupControl();
            this.tbxChapter = new DevExpress.XtraEditors.TextEdit();
            this.btnShowAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.radImportant = new System.Windows.Forms.RadioButton();
            this.radChapter = new System.Windows.Forms.RadioButton();
            this.radIDChapter = new System.Windows.Forms.RadioButton();
            this.cbxImportant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbxIDChapter = new DevExpress.XtraEditors.TextEdit();
            this.radSubject = new System.Windows.Forms.RadioButton();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchSubject)).BeginInit();
            this.gbxSearchSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchSubject
            // 
            this.dgvSearchSubject.Location = new System.Drawing.Point(3, 172);
            this.dgvSearchSubject.MainView = this.gvSearchSubject;
            this.dgvSearchSubject.Name = "dgvSearchSubject";
            this.dgvSearchSubject.Size = new System.Drawing.Size(824, 175);
            this.dgvSearchSubject.TabIndex = 0;
            this.dgvSearchSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSearchSubject});
            // 
            // gvSearchSubject
            // 
            this.gvSearchSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcSubject,
            this.gcIDChapter,
            this.gcChapter,
            this.gcImportant});
            this.gvSearchSubject.GridControl = this.dgvSearchSubject;
            this.gvSearchSubject.Name = "gvSearchSubject";
            this.gvSearchSubject.OptionsView.ShowGroupPanel = false;
            // 
            // gcSubject
            // 
            this.gcSubject.Caption = "Môn";
            this.gcSubject.FieldName = "MaMH_Chuong";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 0;
            this.gcSubject.Width = 84;
            // 
            // gcIDChapter
            // 
            this.gcIDChapter.Caption = "Mã Chương";
            this.gcIDChapter.FieldName = "MaChuong";
            this.gcIDChapter.Name = "gcIDChapter";
            this.gcIDChapter.Visible = true;
            this.gcIDChapter.VisibleIndex = 1;
            this.gcIDChapter.Width = 95;
            // 
            // gcChapter
            // 
            this.gcChapter.Caption = "Tên chương";
            this.gcChapter.FieldName = "TenChuong";
            this.gcChapter.Name = "gcChapter";
            this.gcChapter.Visible = true;
            this.gcChapter.VisibleIndex = 2;
            this.gcChapter.Width = 380;
            // 
            // gcImportant
            // 
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 3;
            this.gcImportant.Width = 132;
            // 
            // gbxSearchSubject
            // 
            this.gbxSearchSubject.Controls.Add(this.tbxChapter);
            this.gbxSearchSubject.Controls.Add(this.btnShowAll);
            this.gbxSearchSubject.Controls.Add(this.btnSearch);
            this.gbxSearchSubject.Controls.Add(this.radImportant);
            this.gbxSearchSubject.Controls.Add(this.radChapter);
            this.gbxSearchSubject.Controls.Add(this.radIDChapter);
            this.gbxSearchSubject.Controls.Add(this.cbxImportant);
            this.gbxSearchSubject.Controls.Add(this.tbxIDChapter);
            this.gbxSearchSubject.Controls.Add(this.radSubject);
            this.gbxSearchSubject.Controls.Add(this.cbxSubject);
            this.gbxSearchSubject.Location = new System.Drawing.Point(3, 3);
            this.gbxSearchSubject.Name = "gbxSearchSubject";
            this.gbxSearchSubject.Size = new System.Drawing.Size(824, 163);
            this.gbxSearchSubject.TabIndex = 1;
            this.gbxSearchSubject.Text = "Tìm kiếm nội dung môn học";
            // 
            // tbxChapter
            // 
            this.tbxChapter.Location = new System.Drawing.Point(260, 92);
            this.tbxChapter.Name = "tbxChapter";
            this.tbxChapter.Size = new System.Drawing.Size(262, 20);
            this.tbxChapter.TabIndex = 11;
            // 
            // btnShowAll
            // 
            this.btnShowAll.ImageOptions.Image = global::frmManage.Properties.Resources.if_filefind_7991;
            this.btnShowAll.Location = new System.Drawing.Point(640, 100);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(135, 45);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::frmManage.Properties.Resources.if_search_find_61674;
            this.btnSearch.Location = new System.Drawing.Point(640, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 45);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radImportant
            // 
            this.radImportant.AutoSize = true;
            this.radImportant.Location = new System.Drawing.Point(150, 120);
            this.radImportant.Name = "radImportant";
            this.radImportant.Size = new System.Drawing.Size(80, 17);
            this.radImportant.TabIndex = 8;
            this.radImportant.TabStop = true;
            this.radImportant.Text = "Quan trọng";
            this.radImportant.UseVisualStyleBackColor = true;
            this.radImportant.CheckedChanged += new System.EventHandler(this.radImportant_CheckedChanged);
            // 
            // radChapter
            // 
            this.radChapter.AutoSize = true;
            this.radChapter.Location = new System.Drawing.Point(150, 95);
            this.radChapter.Name = "radChapter";
            this.radChapter.Size = new System.Drawing.Size(82, 17);
            this.radChapter.TabIndex = 7;
            this.radChapter.TabStop = true;
            this.radChapter.Text = "Tên chương";
            this.radChapter.UseVisualStyleBackColor = true;
            this.radChapter.CheckedChanged += new System.EventHandler(this.radChapter_CheckedChanged);
            // 
            // radIDChapter
            // 
            this.radIDChapter.AutoSize = true;
            this.radIDChapter.Location = new System.Drawing.Point(150, 70);
            this.radIDChapter.Name = "radIDChapter";
            this.radIDChapter.Size = new System.Drawing.Size(78, 17);
            this.radIDChapter.TabIndex = 6;
            this.radIDChapter.TabStop = true;
            this.radIDChapter.Text = "Mã chương";
            this.radIDChapter.UseVisualStyleBackColor = true;
            this.radIDChapter.CheckedChanged += new System.EventHandler(this.radIDChapter_CheckedChanged);
            // 
            // cbxImportant
            // 
            this.cbxImportant.EditValue = "Đúng";
            this.cbxImportant.Location = new System.Drawing.Point(260, 117);
            this.cbxImportant.Name = "cbxImportant";
            this.cbxImportant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImportant.Properties.Items.AddRange(new object[] {
            "Đúng",
            "Sai"});
            this.cbxImportant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxImportant.Size = new System.Drawing.Size(262, 20);
            this.cbxImportant.TabIndex = 5;
            // 
            // tbxIDChapter
            // 
            this.tbxIDChapter.Location = new System.Drawing.Point(260, 67);
            this.tbxIDChapter.Name = "tbxIDChapter";
            this.tbxIDChapter.Size = new System.Drawing.Size(262, 20);
            this.tbxIDChapter.TabIndex = 4;
            // 
            // radSubject
            // 
            this.radSubject.AutoSize = true;
            this.radSubject.Location = new System.Drawing.Point(150, 45);
            this.radSubject.Name = "radSubject";
            this.radSubject.Size = new System.Drawing.Size(65, 17);
            this.radSubject.TabIndex = 3;
            this.radSubject.TabStop = true;
            this.radSubject.Text = "Môn học";
            this.radSubject.UseVisualStyleBackColor = true;
            this.radSubject.CheckedChanged += new System.EventHandler(this.radSubject_CheckedChanged);
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(260, 42);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(262, 20);
            this.cbxSubject.TabIndex = 2;
            // 
            // SearchSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbxSearchSubject);
            this.Controls.Add(this.dgvSearchSubject);
            this.Name = "SearchSubject";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.SearchSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchSubject)).EndInit();
            this.gbxSearchSubject.ResumeLayout(false);
            this.gbxSearchSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSearchSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSearchSubject;
        private DevExpress.XtraEditors.GroupControl gbxSearchSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
        private DevExpress.XtraEditors.ComboBoxEdit cbxImportant;
        private DevExpress.XtraEditors.TextEdit tbxIDChapter;
        private System.Windows.Forms.RadioButton radSubject;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private System.Windows.Forms.RadioButton radChapter;
        private System.Windows.Forms.RadioButton radIDChapter;
        private DevExpress.XtraEditors.SimpleButton btnShowAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.RadioButton radImportant;
        private DevExpress.XtraEditors.TextEdit tbxChapter;
    }
}
