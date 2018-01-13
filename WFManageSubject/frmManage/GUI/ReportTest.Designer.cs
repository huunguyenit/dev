namespace frmManage.GUI
{
    partial class ReportTest
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbxGroup = new DevExpress.XtraEditors.TextEdit();
            this.tbxStudent = new DevExpress.XtraEditors.TextEdit();
            this.tbxExersice = new DevExpress.XtraEditors.TextEdit();
            this.tbxTest = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxExersice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbxTest);
            this.groupControl1.Controls.Add(this.tbxExersice);
            this.groupControl1.Controls.Add(this.tbxStudent);
            this.groupControl1.Controls.Add(this.tbxGroup);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(824, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Báo cáo - thống kê bài kiểm tra";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(151, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Bài cá nhân";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(387, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Bài tập";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(151, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bài nhóm";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(387, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Bài kiểm tra";
            // 
            // tbxGroup
            // 
            this.tbxGroup.Enabled = false;
            this.tbxGroup.Location = new System.Drawing.Point(225, 32);
            this.tbxGroup.Name = "tbxGroup";
            this.tbxGroup.Size = new System.Drawing.Size(134, 20);
            this.tbxGroup.TabIndex = 1;
            // 
            // tbxStudent
            // 
            this.tbxStudent.Enabled = false;
            this.tbxStudent.Location = new System.Drawing.Point(225, 61);
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.Size = new System.Drawing.Size(134, 20);
            this.tbxStudent.TabIndex = 1;
            // 
            // tbxExersice
            // 
            this.tbxExersice.Enabled = false;
            this.tbxExersice.Location = new System.Drawing.Point(457, 32);
            this.tbxExersice.Name = "tbxExersice";
            this.tbxExersice.Size = new System.Drawing.Size(134, 20);
            this.tbxExersice.TabIndex = 1;
            // 
            // tbxTest
            // 
            this.tbxTest.Enabled = false;
            this.tbxTest.Location = new System.Drawing.Point(457, 61);
            this.tbxTest.Name = "tbxTest";
            this.tbxTest.Size = new System.Drawing.Size(134, 20);
            this.tbxTest.TabIndex = 1;
            // 
            // dgvInfoTest
            // 
            this.dgvInfoTest.Location = new System.Drawing.Point(3, 109);
            this.dgvInfoTest.MainView = this.gvTest;
            this.dgvInfoTest.Name = "dgvInfoTest";
            this.dgvInfoTest.Size = new System.Drawing.Size(824, 238);
            this.dgvInfoTest.TabIndex = 5;
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
            // ReportTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInfoTest);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportTest";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.ReportTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxExersice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbxTest;
        private DevExpress.XtraEditors.TextEdit tbxExersice;
        private DevExpress.XtraEditors.TextEdit tbxStudent;
        private DevExpress.XtraEditors.TextEdit tbxGroup;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl dgvInfoTest;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTest;
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
