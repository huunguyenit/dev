namespace frmManage.GUI
{
    partial class ReportDocument
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
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.tbxSumDocument = new System.Windows.Forms.TextBox();
            this.cbxChapter = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDocument = new DevExpress.XtraGrid.GridControl();
            this.gvDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNameDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImportant = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnReport);
            this.groupControl1.Controls.Add(this.tbxSumDocument);
            this.groupControl1.Controls.Add(this.cbxChapter);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(824, 61);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Báo cáo - thống kê tài liệu";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(301, 31);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tbxSumDocument
            // 
            this.tbxSumDocument.Enabled = false;
            this.tbxSumDocument.Location = new System.Drawing.Point(650, 34);
            this.tbxSumDocument.Name = "tbxSumDocument";
            this.tbxSumDocument.Size = new System.Drawing.Size(106, 21);
            this.tbxSumDocument.TabIndex = 3;
            // 
            // cbxChapter
            // 
            this.cbxChapter.EditValue = "";
            this.cbxChapter.Location = new System.Drawing.Point(78, 33);
            this.cbxChapter.Name = "cbxChapter";
            this.cbxChapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChapter.Size = new System.Drawing.Size(208, 20);
            this.cbxChapter.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(567, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tổng tài liệu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chương";
            // 
            // dgvDocument
            // 
            this.dgvDocument.Location = new System.Drawing.Point(3, 70);
            this.dgvDocument.MainView = this.gvDocument;
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.Size = new System.Drawing.Size(824, 277);
            this.dgvDocument.TabIndex = 3;
            this.dgvDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocument});
            // 
            // gvDocument
            // 
            this.gvDocument.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNameDocument,
            this.gcImportant});
            this.gvDocument.GridControl = this.dgvDocument;
            this.gvDocument.Name = "gvDocument";
            this.gvDocument.OptionsView.ShowGroupPanel = false;
            // 
            // gcNameDocument
            // 
            this.gcNameDocument.Caption = "Tên tài liệu";
            this.gcNameDocument.FieldName = "TenTL";
            this.gcNameDocument.Name = "gcNameDocument";
            this.gcNameDocument.Visible = true;
            this.gcNameDocument.VisibleIndex = 0;
            this.gcNameDocument.Width = 546;
            // 
            // gcImportant
            // 
            this.gcImportant.Caption = "Quan trọng";
            this.gcImportant.FieldName = "QuanTrong";
            this.gcImportant.Name = "gcImportant";
            this.gcImportant.Visible = true;
            this.gcImportant.VisibleIndex = 1;
            this.gcImportant.Width = 145;
            // 
            // ReportDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocument);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportDocument";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.ReportDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.TextBox tbxSumDocument;
        private DevExpress.XtraEditors.LookUpEdit cbxChapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvDocument;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gcNameDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gcImportant;
    }
}
