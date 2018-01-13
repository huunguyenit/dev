namespace frmManage.GUI
{
    partial class ReportSubject
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
            this.dgvChapter = new DevExpress.XtraGrid.GridControl();
            this.gvChapter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.tbxSumChapter = new System.Windows.Forms.TextBox();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.gcIDChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNameChapter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChapter
            // 
            this.dgvChapter.Location = new System.Drawing.Point(3, 70);
            this.dgvChapter.MainView = this.gvChapter;
            this.dgvChapter.Name = "dgvChapter";
            this.dgvChapter.Size = new System.Drawing.Size(824, 277);
            this.dgvChapter.TabIndex = 0;
            this.dgvChapter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChapter});
            // 
            // gvChapter
            // 
            this.gvChapter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcIDChapter,
            this.gcNameChapter,
            this.gcImportant});
            this.gvChapter.GridControl = this.dgvChapter;
            this.gvChapter.Name = "gvChapter";
            this.gvChapter.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnReport);
            this.groupControl1.Controls.Add(this.tbxSumChapter);
            this.groupControl1.Controls.Add(this.cbxSubject);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(824, 61);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Báo cáo - thống kê nội dung môn học";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Môn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(567, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tổng số chương";
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(61, 34);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.EditValue = "";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(208, 20);
            this.cbxSubject.TabIndex = 2;
            // 
            // tbxSumChapter
            // 
            this.tbxSumChapter.Enabled = false;
            this.tbxSumChapter.Location = new System.Drawing.Point(650, 34);
            this.tbxSumChapter.Name = "tbxSumChapter";
            this.tbxSumChapter.Size = new System.Drawing.Size(106, 21);
            this.tbxSumChapter.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(290, 31);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gcIDChapter
            // 
            this.gcIDChapter.Caption = "Mã chương";
            this.gcIDChapter.FieldName = "MaChuong";
            this.gcIDChapter.Name = "gcIDChapter";
            this.gcIDChapter.Visible = true;
            this.gcIDChapter.VisibleIndex = 0;
            this.gcIDChapter.Width = 123;
            // 
            // gcNameChapter
            // 
            this.gcNameChapter.Caption = "Tên chương";
            this.gcNameChapter.FieldName = "TenChuong";
            this.gcNameChapter.Name = "gcNameChapter";
            this.gcNameChapter.Visible = true;
            this.gcNameChapter.VisibleIndex = 1;
            this.gcNameChapter.Width = 446;
            // 
            // gcImportant
            // 
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 2;
            this.gcImportant.Width = 122;
            // 
            // ReportSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvChapter);
            this.Name = "ReportSubject";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.ReportSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvChapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.TextBox tbxSumChapter;
        private DevExpress.XtraEditors.LookUpEdit cbxSubject;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gcIDChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcNameChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
    }
}
