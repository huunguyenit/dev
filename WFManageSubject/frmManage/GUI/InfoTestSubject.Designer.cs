namespace frmManage.GUI
{
    partial class InfoTestSubject
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
            this.gbxInfoTestSubject = new DevExpress.XtraEditors.GroupControl();
            this.tbxScore = new DevExpress.XtraEditors.TextEdit();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxStudent = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblStudent = new DevExpress.XtraEditors.LabelControl();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.dgvInfoTestSubject = new DevExpress.XtraGrid.GridControl();
            this.gcInfoTestSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcScore = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).BeginInit();
            this.gbxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoTestSubject)).BeginInit();
            this.gbxInfoTestSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTestSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoTestSubject)).BeginInit();
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
            // gbxInfoTestSubject
            // 
            this.gbxInfoTestSubject.Controls.Add(this.tbxScore);
            this.gbxInfoTestSubject.Controls.Add(this.cbxSubject);
            this.gbxInfoTestSubject.Controls.Add(this.cbxStudent);
            this.gbxInfoTestSubject.Controls.Add(this.label1);
            this.gbxInfoTestSubject.Controls.Add(this.btnCancel);
            this.gbxInfoTestSubject.Controls.Add(this.btnSave);
            this.gbxInfoTestSubject.Controls.Add(this.lblSubject);
            this.gbxInfoTestSubject.Controls.Add(this.lblStudent);
            this.gbxInfoTestSubject.Controls.Add(this.lblScore);
            this.gbxInfoTestSubject.Enabled = false;
            this.gbxInfoTestSubject.Location = new System.Drawing.Point(209, 3);
            this.gbxInfoTestSubject.Name = "gbxInfoTestSubject";
            this.gbxInfoTestSubject.Size = new System.Drawing.Size(618, 166);
            this.gbxInfoTestSubject.TabIndex = 3;
            this.gbxInfoTestSubject.Text = "Thông tin bài thi";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(380, 36);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(221, 20);
            this.tbxScore.TabIndex = 8;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(80, 36);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(221, 20);
            this.cbxSubject.TabIndex = 7;
            // 
            // cbxStudent
            // 
            this.cbxStudent.Location = new System.Drawing.Point(80, 84);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStudent.Size = new System.Drawing.Size(221, 20);
            this.cbxStudent.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(350, 39);
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
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(15, 43);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(20, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Môn";
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(15, 86);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(40, 13);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Học sinh";
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(320, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Điểm";
            // 
            // dgvInfoTestSubject
            // 
            this.dgvInfoTestSubject.Location = new System.Drawing.Point(0, 175);
            this.dgvInfoTestSubject.MainView = this.gcInfoTestSubject;
            this.dgvInfoTestSubject.Name = "dgvInfoTestSubject";
            this.dgvInfoTestSubject.Size = new System.Drawing.Size(827, 172);
            this.dgvInfoTestSubject.TabIndex = 4;
            this.dgvInfoTestSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcInfoTestSubject});
            // 
            // gcInfoTestSubject
            // 
            this.gcInfoTestSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcSubject,
            this.gcStudent,
            this.gcScore});
            this.gcInfoTestSubject.GridControl = this.dgvInfoTestSubject;
            this.gcInfoTestSubject.Name = "gcInfoTestSubject";
            this.gcInfoTestSubject.OptionsView.ShowGroupPanel = false;
            // 
            // gcSubject
            // 
            this.gcSubject.Caption = "Môn học";
            this.gcSubject.FieldName = "MaMH";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 0;
            // 
            // gcStudent
            // 
            this.gcStudent.Caption = "Học sinh";
            this.gcStudent.FieldName = "MaHS";
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Visible = true;
            this.gcStudent.VisibleIndex = 1;
            // 
            // gcScore
            // 
            this.gcScore.Caption = "Điểm";
            this.gcScore.FieldName = "DiemThi";
            this.gcScore.Name = "gcScore";
            this.gcScore.Visible = true;
            this.gcScore.VisibleIndex = 2;
            // 
            // InfoTestSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvInfoTestSubject);
            this.Controls.Add(this.gbxInfoTestSubject);
            this.Controls.Add(this.gbxFunction);
            this.Name = "InfoTestSubject";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.InfoTestSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoTestSubject)).EndInit();
            this.gbxInfoTestSubject.ResumeLayout(false);
            this.gbxInfoTestSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTestSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoTestSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxFunction;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl gbxInfoTestSubject;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.LabelControl lblStudent;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private DevExpress.XtraEditors.TextEdit tbxScore;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private DevExpress.XtraEditors.LookUpEdit cbxStudent;
        private DevExpress.XtraGrid.GridControl dgvInfoTestSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gcInfoTestSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcStudent;
        private DevExpress.XtraGrid.Columns.GridColumn gcScore;
    }
}
