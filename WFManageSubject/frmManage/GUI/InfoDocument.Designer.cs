namespace frmManage.GUI
{
    partial class InfoDocument
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
            this.gbxFunction = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gbxInfoDocument = new DevExpress.XtraEditors.GroupControl();
            this.cbxChapter = new DevExpress.XtraEditors.LookUpEdit();
            this.tbxDocument = new System.Windows.Forms.TextBox();
            this.cbxImportant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblChapter = new DevExpress.XtraEditors.LabelControl();
            this.lblImportant = new DevExpress.XtraEditors.LabelControl();
            this.lblDocument = new DevExpress.XtraEditors.LabelControl();
            this.dgvDocument = new DevExpress.XtraGrid.GridControl();
            this.gvDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcIDChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).BeginInit();
            this.gbxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoDocument)).BeginInit();
            this.gbxInfoDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFunction
            // 
            this.gbxFunction.Controls.Add(this.btnEdit);
            this.gbxFunction.Controls.Add(this.btnDelete);
            this.gbxFunction.Controls.Add(this.btnAdd);
            this.gbxFunction.Location = new System.Drawing.Point(3, 3);
            this.gbxFunction.Name = "gbxFunction";
            this.gbxFunction.Size = new System.Drawing.Size(200, 166);
            this.gbxFunction.TabIndex = 2;
            this.gbxFunction.Text = "Chức năng";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = global::frmManage.Properties.Resources.imgChangePass;
            this.btnEdit.Location = new System.Drawing.Point(58, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::frmManage.Properties.Resources.imgTrash;
            this.btnDelete.Location = new System.Drawing.Point(58, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::frmManage.Properties.Resources.imgAddPlus;
            this.btnAdd.Location = new System.Drawing.Point(58, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxInfoDocument
            // 
            this.gbxInfoDocument.Controls.Add(this.cbxChapter);
            this.gbxInfoDocument.Controls.Add(this.tbxDocument);
            this.gbxInfoDocument.Controls.Add(this.cbxImportant);
            this.gbxInfoDocument.Controls.Add(this.label1);
            this.gbxInfoDocument.Controls.Add(this.btnCancel);
            this.gbxInfoDocument.Controls.Add(this.btnSave);
            this.gbxInfoDocument.Controls.Add(this.lblChapter);
            this.gbxInfoDocument.Controls.Add(this.lblImportant);
            this.gbxInfoDocument.Controls.Add(this.lblDocument);
            this.gbxInfoDocument.Enabled = false;
            this.gbxInfoDocument.Location = new System.Drawing.Point(209, 3);
            this.gbxInfoDocument.Name = "gbxInfoDocument";
            this.gbxInfoDocument.Size = new System.Drawing.Size(618, 166);
            this.gbxInfoDocument.TabIndex = 3;
            this.gbxInfoDocument.Text = "Thông tin tài liệu";
            // 
            // cbxChapter
            // 
            this.cbxChapter.Location = new System.Drawing.Point(78, 40);
            this.cbxChapter.Name = "cbxChapter";
            this.cbxChapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChapter.Size = new System.Drawing.Size(221, 20);
            this.cbxChapter.TabIndex = 10;
            // 
            // tbxDocument
            // 
            this.tbxDocument.Location = new System.Drawing.Point(78, 83);
            this.tbxDocument.Name = "tbxDocument";
            this.tbxDocument.Size = new System.Drawing.Size(221, 21);
            this.tbxDocument.TabIndex = 9;
            // 
            // cbxImportant
            // 
            this.cbxImportant.Location = new System.Drawing.Point(375, 40);
            this.cbxImportant.Name = "cbxImportant";
            this.cbxImportant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImportant.Properties.Items.AddRange(new object[] {
            "Đúng",
            "Sai"});
            this.cbxImportant.Size = new System.Drawing.Size(221, 20);
            this.cbxImportant.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(*)";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::frmManage.Properties.Resources.imgStop;
            this.btnCancel.Location = new System.Drawing.Point(526, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::frmManage.Properties.Resources.imgSave;
            this.btnSave.Location = new System.Drawing.Point(418, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblChapter
            // 
            this.lblChapter.Location = new System.Drawing.Point(19, 43);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(38, 13);
            this.lblChapter.TabIndex = 2;
            this.lblChapter.Text = "Chương";
            // 
            // lblImportant
            // 
            this.lblImportant.Location = new System.Drawing.Point(314, 43);
            this.lblImportant.Name = "lblImportant";
            this.lblImportant.Size = new System.Drawing.Size(55, 13);
            this.lblImportant.TabIndex = 0;
            this.lblImportant.Text = "Quan trọng";
            // 
            // lblDocument
            // 
            this.lblDocument.Location = new System.Drawing.Point(19, 86);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(33, 13);
            this.lblDocument.TabIndex = 0;
            this.lblDocument.Text = "Tài liệu";
            // 
            // dgvDocument
            // 
            this.dgvDocument.Location = new System.Drawing.Point(3, 175);
            this.dgvDocument.MainView = this.gvDocument;
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.Size = new System.Drawing.Size(824, 172);
            this.dgvDocument.TabIndex = 4;
            this.dgvDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocument});
            // 
            // gvDocument
            // 
            this.gvDocument.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcIDChapter,
            this.gcDocument,
            this.gcImportant});
            this.gvDocument.GridControl = this.dgvDocument;
            this.gvDocument.Name = "gvDocument";
            this.gvDocument.OptionsView.ShowGroupPanel = false;
            // 
            // gcIDChapter
            // 
            this.gcIDChapter.Caption = "Mã chương";
            this.gcIDChapter.FieldName = "MaChuong_TL";
            this.gcIDChapter.Name = "gcIDChapter";
            this.gcIDChapter.Visible = true;
            this.gcIDChapter.VisibleIndex = 0;
            this.gcIDChapter.Width = 120;
            // 
            // gcDocument
            // 
            this.gcDocument.Caption = "Tên tài liệu";
            this.gcDocument.FieldName = "TenTL";
            this.gcDocument.Name = "gcDocument";
            this.gcDocument.Visible = true;
            this.gcDocument.VisibleIndex = 1;
            this.gcDocument.Width = 447;
            // 
            // gcImportant
            // 
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 2;
            this.gcImportant.Width = 125;
            // 
            // InfoDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvDocument);
            this.Controls.Add(this.gbxInfoDocument);
            this.Controls.Add(this.gbxFunction);
            this.Name = "InfoDocument";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.InfoDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoDocument)).EndInit();
            this.gbxInfoDocument.ResumeLayout(false);
            this.gbxInfoDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxFunction;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl gbxInfoDocument;
        private DevExpress.XtraEditors.ComboBoxEdit cbxImportant;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblChapter;
        private DevExpress.XtraEditors.LabelControl lblImportant;
        private DevExpress.XtraEditors.LabelControl lblDocument;
        private System.Windows.Forms.TextBox tbxDocument;
        private DevExpress.XtraEditors.LookUpEdit cbxChapter;
        private DevExpress.XtraGrid.GridControl dgvDocument;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
    }
}
