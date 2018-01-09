namespace frmManage.GUI
{
    partial class InfoSubject
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
            this.gbxInfoSubject = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNotnull = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).BeginInit();
            this.gbxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoSubject)).BeginInit();
            this.gbxInfoSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::frmManage.Properties.Resources.imgTrash;
            this.btnDelete.Location = new System.Drawing.Point(58, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::frmManage.Properties.Resources.imgAddPlus;
            this.btnAdd.Location = new System.Drawing.Point(58, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            // 
            // gbxInfoSubject
            // 
            this.gbxInfoSubject.Controls.Add(this.lblNotnull);
            this.gbxInfoSubject.Controls.Add(this.textEdit2);
            this.gbxInfoSubject.Controls.Add(this.textEdit1);
            this.gbxInfoSubject.Controls.Add(this.simpleButton2);
            this.gbxInfoSubject.Controls.Add(this.simpleButton1);
            this.gbxInfoSubject.Controls.Add(this.labelControl3);
            this.gbxInfoSubject.Controls.Add(this.labelControl2);
            this.gbxInfoSubject.Controls.Add(this.labelControl1);
            this.gbxInfoSubject.Controls.Add(this.textEdit3);
            this.gbxInfoSubject.Location = new System.Drawing.Point(209, 3);
            this.gbxInfoSubject.Name = "gbxInfoSubject";
            this.gbxInfoSubject.Size = new System.Drawing.Size(618, 166);
            this.gbxInfoSubject.TabIndex = 2;
            this.gbxInfoSubject.Text = "Thông tin môn học";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(90, 67);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(221, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(90, 35);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(221, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::frmManage.Properties.Resources.imgCancel;
            this.simpleButton2.Location = new System.Drawing.Point(236, 133);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Hủy bỏ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::frmManage.Properties.Resources.imgSave;
            this.simpleButton1.Location = new System.Drawing.Point(131, 133);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Lưu lại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Giáo viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Môn";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(90, 97);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Size = new System.Drawing.Size(221, 20);
            this.textEdit3.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Môn";
            // 
            // lblNotnull
            // 
            this.lblNotnull.AutoSize = true;
            this.lblNotnull.ForeColor = System.Drawing.Color.Red;
            this.lblNotnull.Location = new System.Drawing.Point(63, 70);
            this.lblNotnull.Name = "lblNotnull";
            this.lblNotnull.Size = new System.Drawing.Size(21, 13);
            this.lblNotnull.TabIndex = 5;
            this.lblNotnull.Text = "(*)";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 175);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(830, 172);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dgvColID,
            this.dgvColSubject,
            this.dgvColTeacher});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // dgvColID
            // 
            this.dgvColID.Caption = "Mã môn";
            this.dgvColID.Name = "dgvColID";
            this.dgvColID.Visible = true;
            this.dgvColID.VisibleIndex = 0;
            // 
            // dgvColSubject
            // 
            this.dgvColSubject.Caption = "Tên môn";
            this.dgvColSubject.Name = "dgvColSubject";
            this.dgvColSubject.Visible = true;
            this.dgvColSubject.VisibleIndex = 1;
            // 
            // dgvColTeacher
            // 
            this.dgvColTeacher.Caption = "Giáo viên";
            this.dgvColTeacher.Name = "dgvColTeacher";
            this.dgvColTeacher.Visible = true;
            this.dgvColTeacher.VisibleIndex = 2;
            // 
            // InfoSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::frmManage.Properties.Resources.imgFrmManage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gbxInfoSubject);
            this.Controls.Add(this.gbxFunction);
            this.Name = "InfoSubject";
            this.Size = new System.Drawing.Size(830, 350);
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoSubject)).EndInit();
            this.gbxInfoSubject.ResumeLayout(false);
            this.gbxInfoSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gbxFunction;
        private DevExpress.XtraEditors.GroupControl gbxInfoSubject;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblNotnull;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColID;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColSubject;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColTeacher;
    }
}
