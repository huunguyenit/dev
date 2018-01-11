namespace frmManage.GUI
{
    partial class InfoTestExcersice
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
            this.gbxInfoTestExersice = new DevExpress.XtraEditors.GroupControl();
            this.lblTest_Ex = new DevExpress.XtraEditors.LabelControl();
            this.cbxTestGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxTest = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblIDTest = new DevExpress.XtraEditors.LabelControl();
            this.tbxIDTest = new DevExpress.XtraEditors.TextEdit();
            this.cbxNameGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxStudent = new DevExpress.XtraEditors.LookUpEdit();
            this.tbxScore = new DevExpress.XtraEditors.TextEdit();
            this.tbxNameTest = new DevExpress.XtraEditors.TextEdit();
            this.cbxChapter = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblChapter = new DevExpress.XtraEditors.LabelControl();
            this.lblGroup = new DevExpress.XtraEditors.LabelControl();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.lblStudent = new DevExpress.XtraEditors.LabelControl();
            this.lblNameTest = new DevExpress.XtraEditors.LabelControl();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.dgvInfoTest = new DevExpress.XtraGrid.GridControl();
            this.gvTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTypeTest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStudent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIDSemester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTestGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIDTest = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).BeginInit();
            this.gbxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoTestExersice)).BeginInit();
            this.gbxInfoTestExersice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTestGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNameGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNameTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
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
            // gbxInfoTestExersice
            // 
            this.gbxInfoTestExersice.Controls.Add(this.lblTest_Ex);
            this.gbxInfoTestExersice.Controls.Add(this.cbxTestGroup);
            this.gbxInfoTestExersice.Controls.Add(this.cbxTest);
            this.gbxInfoTestExersice.Controls.Add(this.lblIDTest);
            this.gbxInfoTestExersice.Controls.Add(this.tbxIDTest);
            this.gbxInfoTestExersice.Controls.Add(this.cbxNameGroup);
            this.gbxInfoTestExersice.Controls.Add(this.cbxStudent);
            this.gbxInfoTestExersice.Controls.Add(this.tbxScore);
            this.gbxInfoTestExersice.Controls.Add(this.tbxNameTest);
            this.gbxInfoTestExersice.Controls.Add(this.cbxChapter);
            this.gbxInfoTestExersice.Controls.Add(this.cbxSubject);
            this.gbxInfoTestExersice.Controls.Add(this.btnCancel);
            this.gbxInfoTestExersice.Controls.Add(this.btnSave);
            this.gbxInfoTestExersice.Controls.Add(this.lblChapter);
            this.gbxInfoTestExersice.Controls.Add(this.lblGroup);
            this.gbxInfoTestExersice.Controls.Add(this.lblScore);
            this.gbxInfoTestExersice.Controls.Add(this.lblStudent);
            this.gbxInfoTestExersice.Controls.Add(this.lblNameTest);
            this.gbxInfoTestExersice.Controls.Add(this.lblSubject);
            this.gbxInfoTestExersice.Enabled = false;
            this.gbxInfoTestExersice.Location = new System.Drawing.Point(209, 3);
            this.gbxInfoTestExersice.Name = "gbxInfoTestExersice";
            this.gbxInfoTestExersice.Size = new System.Drawing.Size(618, 166);
            this.gbxInfoTestExersice.TabIndex = 3;
            this.gbxInfoTestExersice.Text = "Thông tin bài kiểm tra, bài tập";
            // 
            // lblTest_Ex
            // 
            this.lblTest_Ex.Location = new System.Drawing.Point(15, 80);
            this.lblTest_Ex.Name = "lblTest_Ex";
            this.lblTest_Ex.Size = new System.Drawing.Size(14, 13);
            this.lblTest_Ex.TabIndex = 24;
            this.lblTest_Ex.Text = "Bài";
            // 
            // cbxTestGroup
            // 
            this.cbxTestGroup.Location = new System.Drawing.Point(205, 80);
            this.cbxTestGroup.Name = "cbxTestGroup";
            this.cbxTestGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTestGroup.Properties.Items.AddRange(new object[] {
            "Nhóm",
            "Cá nhân"});
            this.cbxTestGroup.Size = new System.Drawing.Size(100, 20);
            this.cbxTestGroup.TabIndex = 23;
            // 
            // cbxTest
            // 
            this.cbxTest.Location = new System.Drawing.Point(80, 80);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTest.Properties.Items.AddRange(new object[] {
            "Bài tập",
            "Bài kiểm tra"});
            this.cbxTest.Size = new System.Drawing.Size(100, 20);
            this.cbxTest.TabIndex = 23;
            // 
            // lblIDTest
            // 
            this.lblIDTest.Location = new System.Drawing.Point(310, 30);
            this.lblIDTest.Name = "lblIDTest";
            this.lblIDTest.Size = new System.Drawing.Size(31, 13);
            this.lblIDTest.TabIndex = 22;
            this.lblIDTest.Text = "Mã Bài";
            // 
            // tbxIDTest
            // 
            this.tbxIDTest.Enabled = false;
            this.tbxIDTest.Location = new System.Drawing.Point(377, 30);
            this.tbxIDTest.Name = "tbxIDTest";
            this.tbxIDTest.Size = new System.Drawing.Size(224, 20);
            this.tbxIDTest.TabIndex = 21;
            // 
            // cbxNameGroup
            // 
            this.cbxNameGroup.Location = new System.Drawing.Point(80, 105);
            this.cbxNameGroup.Name = "cbxNameGroup";
            this.cbxNameGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNameGroup.Size = new System.Drawing.Size(225, 20);
            this.cbxNameGroup.TabIndex = 19;
            // 
            // cbxStudent
            // 
            this.cbxStudent.Location = new System.Drawing.Point(377, 80);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStudent.Size = new System.Drawing.Size(224, 20);
            this.cbxStudent.TabIndex = 18;
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(377, 105);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(224, 20);
            this.tbxScore.TabIndex = 9;
            this.tbxScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxScore_KeyPress);
            // 
            // tbxNameTest
            // 
            this.tbxNameTest.Location = new System.Drawing.Point(377, 55);
            this.tbxNameTest.Name = "tbxNameTest";
            this.tbxNameTest.Size = new System.Drawing.Size(224, 20);
            this.tbxNameTest.TabIndex = 9;
            // 
            // cbxChapter
            // 
            this.cbxChapter.Location = new System.Drawing.Point(80, 55);
            this.cbxChapter.Name = "cbxChapter";
            this.cbxChapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChapter.Size = new System.Drawing.Size(225, 20);
            this.cbxChapter.TabIndex = 7;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(80, 30);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(225, 20);
            this.cbxSubject.TabIndex = 7;
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
            this.lblChapter.Location = new System.Drawing.Point(15, 55);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(38, 13);
            this.lblChapter.TabIndex = 2;
            this.lblChapter.Text = "Chương";
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(15, 105);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(27, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Nhóm";
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(311, 105);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Điểm";
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(311, 80);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(40, 13);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Học sinh";
            // 
            // lblNameTest
            // 
            this.lblNameTest.Location = new System.Drawing.Point(310, 55);
            this.lblNameTest.Name = "lblNameTest";
            this.lblNameTest.Size = new System.Drawing.Size(35, 13);
            this.lblNameTest.TabIndex = 0;
            this.lblNameTest.Text = "Tên bài";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(15, 30);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(41, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Môn Học";
            // 
            // dgvInfoTest
            // 
            this.dgvInfoTest.Location = new System.Drawing.Point(3, 175);
            this.dgvInfoTest.MainView = this.gvTest;
            this.dgvInfoTest.Name = "dgvInfoTest";
            this.dgvInfoTest.Size = new System.Drawing.Size(824, 172);
            this.dgvInfoTest.TabIndex = 4;
            this.dgvInfoTest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTest});
            // 
            // gvTest
            // 
            this.gvTest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcChapter,
            this.gcSubject,
            this.gcTypeTest,
            this.gcScore,
            this.gcStudent,
            this.gcGroup,
            this.gcIDSemester,
            this.gcTestGroup,
            this.gcIDTest});
            this.gvTest.GridControl = this.dgvInfoTest;
            this.gvTest.Name = "gvTest";
            this.gvTest.OptionsView.ShowGroupPanel = false;
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
            // InfoTestExcersice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvInfoTest);
            this.Controls.Add(this.gbxInfoTestExersice);
            this.Controls.Add(this.gbxFunction);
            this.Name = "InfoTestExcersice";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.InfoTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxFunction)).EndInit();
            this.gbxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxInfoTestExersice)).EndInit();
            this.gbxInfoTestExersice.ResumeLayout(false);
            this.gbxInfoTestExersice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTestGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIDTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNameGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNameTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxFunction;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl gbxInfoTestExersice;
        private DevExpress.XtraEditors.LookUpEdit cbxChapter;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblChapter;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraGrid.GridControl dgvInfoTest;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTest;
        private DevExpress.XtraGrid.Columns.GridColumn gcChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcTypeTest;
        private DevExpress.XtraGrid.Columns.GridColumn gcScore;
        private DevExpress.XtraGrid.Columns.GridColumn gcStudent;
        private DevExpress.XtraGrid.Columns.GridColumn gcGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDSemester;
        private DevExpress.XtraEditors.TextEdit tbxNameTest;
        private DevExpress.XtraEditors.LabelControl lblNameTest;
        private DevExpress.XtraEditors.TextEdit tbxScore;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private DevExpress.XtraEditors.LabelControl lblStudent;
        private DevExpress.XtraEditors.LabelControl lblGroup;
        private DevExpress.XtraEditors.LookUpEdit cbxStudent;
        private DevExpress.XtraEditors.LookUpEdit cbxNameGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcTestGroup;
        private DevExpress.XtraEditors.LabelControl lblIDTest;
        private DevExpress.XtraEditors.TextEdit tbxIDTest;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDTest;
        private DevExpress.XtraEditors.LabelControl lblTest_Ex;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTestGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTest;
    }
}
