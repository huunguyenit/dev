using DevExpress.Utils;

namespace frmManage.GUI
{
    partial class InfoChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoChapter));
            this.gbxFunction = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gbxInfoChapter = new DevExpress.XtraEditors.GroupControl();
            this.cbxImportant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIdChapter = new DevExpress.XtraEditors.TextEdit();
            this.tbxChapter = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblIDChapter = new DevExpress.XtraEditors.LabelControl();
            this.lblChapter = new DevExpress.XtraEditors.LabelControl();
            this.lblImportant = new DevExpress.XtraEditors.LabelControl();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.dgvColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvChapter = new DevExpress.XtraGrid.GridControl();
            this.gvChapter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcIDChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).BeginInit();
            this.gbxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoChapter)).BeginInit();
            this.gbxInfoChapter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIdChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapter)).BeginInit();
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
            this.gbxFunction.TabIndex = 1;
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
            // gbxInfoChapter
            // 
            this.gbxInfoChapter.Controls.Add(this.cbxImportant);
            this.gbxInfoChapter.Controls.Add(this.cbxSubject);
            this.gbxInfoChapter.Controls.Add(this.label1);
            this.gbxInfoChapter.Controls.Add(this.tbxIdChapter);
            this.gbxInfoChapter.Controls.Add(this.tbxChapter);
            this.gbxInfoChapter.Controls.Add(this.btnCancel);
            this.gbxInfoChapter.Controls.Add(this.btnSave);
            this.gbxInfoChapter.Controls.Add(this.lblIDChapter);
            this.gbxInfoChapter.Controls.Add(this.lblChapter);
            this.gbxInfoChapter.Controls.Add(this.lblImportant);
            this.gbxInfoChapter.Controls.Add(this.lblSubject);
            this.gbxInfoChapter.Enabled = false;
            this.gbxInfoChapter.Location = new System.Drawing.Point(209, 3);
            this.gbxInfoChapter.Name = "gbxInfoChapter";
            this.gbxInfoChapter.Size = new System.Drawing.Size(618, 166);
            this.gbxInfoChapter.TabIndex = 2;
            this.gbxInfoChapter.Text = "Thông tin môn học";
            // 
            // cbxImportant
            // 
            this.cbxImportant.Location = new System.Drawing.Point(378, 83);
            this.cbxImportant.Name = "cbxImportant";
            this.cbxImportant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImportant.Properties.Items.AddRange(new object[] {
            "Đúng",
            "Sai"});
            this.cbxImportant.Size = new System.Drawing.Size(221, 20);
            this.cbxImportant.TabIndex = 8;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(378, 40);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(221, 20);
            this.cbxSubject.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(*)";
            // 
            // tbxIdChapter
            // 
            this.tbxIdChapter.Enabled = false;
            this.tbxIdChapter.Location = new System.Drawing.Point(90, 40);
            this.tbxIdChapter.Name = "tbxIdChapter";
            this.tbxIdChapter.Size = new System.Drawing.Size(221, 20);
            this.tbxIdChapter.TabIndex = 4;
            // 
            // tbxChapter
            // 
            this.tbxChapter.Location = new System.Drawing.Point(90, 83);
            this.tbxChapter.Name = "tbxChapter";
            this.tbxChapter.Size = new System.Drawing.Size(221, 20);
            this.tbxChapter.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::frmManage.Properties.Resources.imgExit;
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
            // lblIDChapter
            // 
            this.lblIDChapter.Location = new System.Drawing.Point(15, 43);
            this.lblIDChapter.Name = "lblIDChapter";
            this.lblIDChapter.Size = new System.Drawing.Size(55, 13);
            this.lblIDChapter.TabIndex = 2;
            this.lblIDChapter.Text = "Mã Chương";
            // 
            // lblChapter
            // 
            this.lblChapter.Location = new System.Drawing.Point(15, 86);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(38, 13);
            this.lblChapter.TabIndex = 2;
            this.lblChapter.Text = "Chương";
            // 
            // lblImportant
            // 
            this.lblImportant.Location = new System.Drawing.Point(317, 86);
            this.lblImportant.Name = "lblImportant";
            this.lblImportant.Size = new System.Drawing.Size(55, 13);
            this.lblImportant.TabIndex = 0;
            this.lblImportant.Text = "Quan trọng";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(317, 43);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(41, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Môn Học";
            // 
            // dgvColID
            // 
            this.dgvColID.Name = "dgvColID";
            // 
            // dgvColSubject
            // 
            this.dgvColSubject.Caption = "Tên môn";
            this.dgvColSubject.FieldName = "TenMH";
            this.dgvColSubject.Name = "dgvColSubject";
            this.dgvColSubject.Visible = true;
            this.dgvColSubject.VisibleIndex = 0;
            // 
            // dgvColTeacher
            // 
            this.dgvColTeacher.Caption = "Giáo viên";
            this.dgvColTeacher.FieldName = "TenGV";
            this.dgvColTeacher.Name = "dgvColTeacher";
            this.dgvColTeacher.Visible = true;
            this.dgvColTeacher.VisibleIndex = 1;
            // 
            // dgvChapter
            // 
            this.dgvChapter.Location = new System.Drawing.Point(3, 175);
            this.dgvChapter.MainView = this.gvChapter;
            this.dgvChapter.Name = "dgvChapter";
            this.dgvChapter.Size = new System.Drawing.Size(824, 172);
            this.dgvChapter.TabIndex = 3;
            this.dgvChapter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChapter});
            // 
            // gvChapter
            // 
            this.gvChapter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcIDChapter,
            this.gcChapter,
            this.gcSubject,
            this.gcImportant});
            this.gvChapter.GridControl = this.dgvChapter;
            this.gvChapter.Name = "gvChapter";
            this.gvChapter.OptionsView.ShowGroupPanel = false;
            // 
            // gcIDChapter
            // 
            this.gcIDChapter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcIDChapter.Caption = "Mã chương";
            this.gcIDChapter.FieldName = "MaChuong";
            this.gcIDChapter.Name = "gcIDChapter";
            this.gcIDChapter.Visible = true;
            this.gcIDChapter.VisibleIndex = 0;
            this.gcIDChapter.Width = 65;
            // 
            // gcChapter
            // 
            this.gcChapter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcChapter.Caption = "Tên Chương";
            this.gcChapter.FieldName = "TenChuong";
            this.gcChapter.Name = "gcChapter";
            this.gcChapter.Visible = true;
            this.gcChapter.VisibleIndex = 2;
            this.gcChapter.Width = 453;
            // 
            // gcSubject
            // 
            this.gcSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcSubject.Caption = "Mã MH";
            this.gcSubject.FieldName = "MaMH_Chuong";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 1;
            this.gcSubject.Width = 62;
            // 
            // gcImportant
            // 
            this.gcImportant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 3;
            this.gcImportant.Width = 112;
            // 
            // InfoChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvChapter);
            this.Controls.Add(this.gbxInfoChapter);
            this.Controls.Add(this.gbxFunction);
            this.Name = "InfoChapter";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.InfoSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoChapter)).EndInit();
            this.gbxInfoChapter.ResumeLayout(false);
            this.gbxInfoChapter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIdChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gbxFunction;
        private DevExpress.XtraEditors.GroupControl gbxInfoChapter;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit tbxChapter;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblChapter;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColID;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColSubject;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColTeacher;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lblImportant;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cbxImportant;
        private DevExpress.XtraEditors.TextEdit tbxIdChapter;
        private DevExpress.XtraEditors.LabelControl lblIDChapter;
        private DevExpress.XtraGrid.GridControl dgvChapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDChapter;
    }
}
