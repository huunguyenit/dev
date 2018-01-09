namespace frmManage.GUI
{
    partial class ChangePassword
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
            this.lblChangePasword = new DevExpress.XtraEditors.LabelControl();
            this.lblOldPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblNewPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblRetypePassword = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusChangePassword = new DevExpress.XtraEditors.LabelControl();
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxReNewPassword = new System.Windows.Forms.TextBox();
            this.panMenuChange = new System.Windows.Forms.Panel();
            this.btnCancelChangePass = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcceptChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.panMenuChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChangePasword
            // 
            this.lblChangePasword.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePasword.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblChangePasword.Appearance.Options.UseFont = true;
            this.lblChangePasword.Appearance.Options.UseForeColor = true;
            this.lblChangePasword.Location = new System.Drawing.Point(206, 10);
            this.lblChangePasword.Margin = new System.Windows.Forms.Padding(4);
            this.lblChangePasword.Name = "lblChangePasword";
            this.lblChangePasword.Size = new System.Drawing.Size(138, 26);
            this.lblChangePasword.TabIndex = 0;
            this.lblChangePasword.Text = "Đổi mật khẩu";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Appearance.Options.UseFont = true;
            this.lblOldPassword.Location = new System.Drawing.Point(32, 63);
            this.lblOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(76, 19);
            this.lblOldPassword.TabIndex = 1;
            this.lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Appearance.Options.UseFont = true;
            this.lblNewPassword.Location = new System.Drawing.Point(32, 107);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(84, 19);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.Appearance.Options.UseFont = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(32, 149);
            this.lblRetypePassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(110, 19);
            this.lblRetypePassword.TabIndex = 3;
            this.lblRetypePassword.Text = "Nhập lại mật khẩu";
            // 
            // lblStatusChangePassword
            // 
            this.lblStatusChangePassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusChangePassword.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblStatusChangePassword.Appearance.Options.UseFont = true;
            this.lblStatusChangePassword.Appearance.Options.UseForeColor = true;
            this.lblStatusChangePassword.Location = new System.Drawing.Point(153, 190);
            this.lblStatusChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblStatusChangePassword.Name = "lblStatusChangePassword";
            this.lblStatusChangePassword.Size = new System.Drawing.Size(64, 19);
            this.lblStatusChangePassword.TabIndex = 4;
            this.lblStatusChangePassword.Text = "Trạng thái!";
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Location = new System.Drawing.Point(153, 60);
            this.tbxOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOldPassword.MaxLength = 10;
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.PasswordChar = '*';
            this.tbxOldPassword.Size = new System.Drawing.Size(291, 26);
            this.tbxOldPassword.TabIndex = 5;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(153, 104);
            this.tbxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNewPassword.MaxLength = 10;
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '*';
            this.tbxNewPassword.Size = new System.Drawing.Size(291, 26);
            this.tbxNewPassword.TabIndex = 5;
            // 
            // tbxReNewPassword
            // 
            this.tbxReNewPassword.Location = new System.Drawing.Point(153, 146);
            this.tbxReNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReNewPassword.MaxLength = 10;
            this.tbxReNewPassword.Name = "tbxReNewPassword";
            this.tbxReNewPassword.PasswordChar = '*';
            this.tbxReNewPassword.Size = new System.Drawing.Size(291, 26);
            this.tbxReNewPassword.TabIndex = 5;
            // 
            // panMenuChange
            // 
            this.panMenuChange.BackColor = System.Drawing.Color.Transparent;
            this.panMenuChange.Controls.Add(this.btnCancelChangePass);
            this.panMenuChange.Controls.Add(this.btnAcceptChangePassword);
            this.panMenuChange.Controls.Add(this.tbxReNewPassword);
            this.panMenuChange.Controls.Add(this.tbxNewPassword);
            this.panMenuChange.Controls.Add(this.tbxOldPassword);
            this.panMenuChange.Controls.Add(this.lblStatusChangePassword);
            this.panMenuChange.Controls.Add(this.lblRetypePassword);
            this.panMenuChange.Controls.Add(this.lblNewPassword);
            this.panMenuChange.Controls.Add(this.lblOldPassword);
            this.panMenuChange.Controls.Add(this.lblChangePasword);
            this.panMenuChange.Location = new System.Drawing.Point(152, 20);
            this.panMenuChange.Name = "panMenuChange";
            this.panMenuChange.Size = new System.Drawing.Size(503, 301);
            this.panMenuChange.TabIndex = 7;
            // 
            // btnCancelChangePass
            // 
            this.btnCancelChangePass.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangePass.Appearance.Options.UseFont = true;
            this.btnCancelChangePass.ImageOptions.Image = global::frmManage.Properties.Resources.imgCancel;
            this.btnCancelChangePass.Location = new System.Drawing.Point(332, 238);
            this.btnCancelChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelChangePass.Name = "btnCancelChangePass";
            this.btnCancelChangePass.Size = new System.Drawing.Size(100, 35);
            this.btnCancelChangePass.TabIndex = 6;
            this.btnCancelChangePass.Text = "Hủy bỏ";
            this.btnCancelChangePass.Click += new System.EventHandler(this.btnCancelChangePass_Click);
            // 
            // btnAcceptChangePassword
            // 
            this.btnAcceptChangePassword.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptChangePassword.Appearance.Options.UseFont = true;
            this.btnAcceptChangePassword.ImageOptions.Image = global::frmManage.Properties.Resources.imgChangePass24;
            this.btnAcceptChangePassword.Location = new System.Drawing.Point(153, 238);
            this.btnAcceptChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptChangePassword.Name = "btnAcceptChangePassword";
            this.btnAcceptChangePassword.Size = new System.Drawing.Size(100, 35);
            this.btnAcceptChangePassword.TabIndex = 6;
            this.btnAcceptChangePassword.Text = "Đồng ý";
            this.btnAcceptChangePassword.Click += new System.EventHandler(this.btnAcceptChangePassword_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmManage.Properties.Resources.imgFrmManage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panMenuChange);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(830, 350);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panMenuChange.ResumeLayout(false);
            this.panMenuChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblChangePasword;
        private DevExpress.XtraEditors.LabelControl lblOldPassword;
        private DevExpress.XtraEditors.LabelControl lblNewPassword;
        private DevExpress.XtraEditors.LabelControl lblRetypePassword;
        private DevExpress.XtraEditors.LabelControl lblStatusChangePassword;
        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxReNewPassword;
        private DevExpress.XtraEditors.SimpleButton btnAcceptChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnCancelChangePass;
        private System.Windows.Forms.Panel panMenuChange;
    }
}
