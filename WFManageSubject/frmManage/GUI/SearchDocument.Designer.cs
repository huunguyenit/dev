namespace frmManage.GUI
{
    partial class SearchDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDocument));
            this.dgvDocument = new DevExpress.XtraGrid.GridControl();
            this.gvDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbxSearchDocument = new DevExpress.XtraEditors.GroupControl();
            this.btnShowAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.tbxDocument = new DevExpress.XtraEditors.TextEdit();
            this.cbxImportant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxChapter = new DevExpress.XtraEditors.LookUpEdit();
            this.radImportant = new System.Windows.Forms.RadioButton();
            this.radDocument = new System.Windows.Forms.RadioButton();
            this.radChapter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchDocument)).BeginInit();
            this.gbxSearchDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDocument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocument
            // 
            this.dgvDocument.Location = new System.Drawing.Point(3, 172);
            this.dgvDocument.MainView = this.gvDocument;
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.Size = new System.Drawing.Size(824, 175);
            this.dgvDocument.TabIndex = 0;
            this.dgvDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocument});
            // 
            // gvDocument
            // 
            this.gvDocument.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcChapter,
            this.gcDocument,
            this.gcImportant});
            this.gvDocument.GridControl = this.dgvDocument;
            this.gvDocument.Name = "gvDocument";
            this.gvDocument.OptionsView.ShowGroupPanel = false;
            // 
            // gcChapter
            // 
            this.gcChapter.Caption = "Chương";
            this.gcChapter.FieldName = "MaChuong_TL";
            this.gcChapter.Name = "gcChapter";
            this.gcChapter.Visible = true;
            this.gcChapter.VisibleIndex = 0;
            this.gcChapter.Width = 133;
            // 
            // gcDocument
            // 
            this.gcDocument.Caption = "Tài liệu";
            this.gcDocument.FieldName = "TenTL";
            this.gcDocument.Name = "gcDocument";
            this.gcDocument.Visible = true;
            this.gcDocument.VisibleIndex = 1;
            this.gcDocument.Width = 398;
            // 
            // gcImportant
            // 
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 2;
            this.gcImportant.Width = 160;
            // 
            // gbxSearchDocument
            // 
            this.gbxSearchDocument.Controls.Add(this.btnShowAll);
            this.gbxSearchDocument.Controls.Add(this.btnSearch);
            this.gbxSearchDocument.Controls.Add(this.tbxDocument);
            this.gbxSearchDocument.Controls.Add(this.cbxImportant);
            this.gbxSearchDocument.Controls.Add(this.cbxChapter);
            this.gbxSearchDocument.Controls.Add(this.radImportant);
            this.gbxSearchDocument.Controls.Add(this.radDocument);
            this.gbxSearchDocument.Controls.Add(this.radChapter);
            this.gbxSearchDocument.Location = new System.Drawing.Point(3, 3);
            this.gbxSearchDocument.Name = "gbxSearchDocument";
            this.gbxSearchDocument.Size = new System.Drawing.Size(824, 163);
            this.gbxSearchDocument.TabIndex = 1;
            this.gbxSearchDocument.Text = "Tìm kiếm tài liệu";
            // 
            // btnShowAll
            // 
            this.btnShowAll.ImageOptions.Image = global::frmManage.Properties.Resources.if_search_b_44994;
            this.btnShowAll.Location = new System.Drawing.Point(640, 100);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(135, 45);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::frmManage.Properties.Resources.if_search_find_61674;
            this.btnSearch.Location = new System.Drawing.Point(640, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxDocument
            // 
            this.tbxDocument.Location = new System.Drawing.Point(319, 78);
            this.tbxDocument.Name = "tbxDocument";
            this.tbxDocument.Size = new System.Drawing.Size(274, 20);
            this.tbxDocument.TabIndex = 4;
            // 
            // cbxImportant
            // 
            this.cbxImportant.Location = new System.Drawing.Point(319, 119);
            this.cbxImportant.Name = "cbxImportant";
            this.cbxImportant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImportant.Properties.Items.AddRange(new object[] {
            "Đúng",
            "Sai"});
            this.cbxImportant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxImportant.Size = new System.Drawing.Size(274, 20);
            this.cbxImportant.TabIndex = 3;
            // 
            // cbxChapter
            // 
            this.cbxChapter.Location = new System.Drawing.Point(319, 38);
            this.cbxChapter.Name = "cbxChapter";
            this.cbxChapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChapter.Size = new System.Drawing.Size(274, 20);
            this.cbxChapter.TabIndex = 2;
            // 
            // radImportant
            // 
            this.radImportant.AutoSize = true;
            this.radImportant.Location = new System.Drawing.Point(200, 120);
            this.radImportant.Name = "radImportant";
            this.radImportant.Size = new System.Drawing.Size(114, 17);
            this.radImportant.TabIndex = 1;
            this.radImportant.TabStop = true;
            this.radImportant.Text = "Tài liệu quan trọng";
            this.radImportant.UseVisualStyleBackColor = true;
            this.radImportant.CheckedChanged += new System.EventHandler(this.radImportant_CheckedChanged);
            // 
            // radDocument
            // 
            this.radDocument.AutoSize = true;
            this.radDocument.Location = new System.Drawing.Point(200, 80);
            this.radDocument.Name = "radDocument";
            this.radDocument.Size = new System.Drawing.Size(77, 17);
            this.radDocument.TabIndex = 1;
            this.radDocument.TabStop = true;
            this.radDocument.Text = "Tên tài liệu";
            this.radDocument.UseVisualStyleBackColor = true;
            this.radDocument.CheckedChanged += new System.EventHandler(this.radDocument_CheckedChanged);
            // 
            // radChapter
            // 
            this.radChapter.AutoSize = true;
            this.radChapter.Location = new System.Drawing.Point(200, 40);
            this.radChapter.Name = "radChapter";
            this.radChapter.Size = new System.Drawing.Size(63, 17);
            this.radChapter.TabIndex = 0;
            this.radChapter.TabStop = true;
            this.radChapter.Text = "Chương";
            this.radChapter.UseVisualStyleBackColor = true;
            this.radChapter.CheckedChanged += new System.EventHandler(this.radChapter_CheckedChanged);
            // 
            // SearchDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbxSearchDocument);
            this.Controls.Add(this.dgvDocument);
            this.Name = "SearchDocument";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.SearchDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearchDocument)).EndInit();
            this.gbxSearchDocument.ResumeLayout(false);
            this.gbxSearchDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDocument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDocument;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocument;
        private DevExpress.XtraEditors.GroupControl gbxSearchDocument;
        private DevExpress.XtraEditors.SimpleButton btnShowAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit tbxDocument;
        private DevExpress.XtraEditors.ComboBoxEdit cbxImportant;
        private DevExpress.XtraEditors.LookUpEdit cbxChapter;
        private System.Windows.Forms.RadioButton radImportant;
        private System.Windows.Forms.RadioButton radDocument;
        private System.Windows.Forms.RadioButton radChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
    }
}
