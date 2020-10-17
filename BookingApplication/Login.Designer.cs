namespace BookingApplication
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnExitLogin = new FontAwesome.Sharp.IconButton();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.iconBtnSignIn = new FontAwesome.Sharp.IconButton();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.linkLblSignUp = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelLogin.Controls.Add(this.btnExitLogin);
            this.panelLogin.Controls.Add(this.lblSignIn);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(265, 58);
            this.panelLogin.TabIndex = 9;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitLogin.FlatAppearance.BorderSize = 0;
            this.btnExitLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExitLogin.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExitLogin.IconColor = System.Drawing.Color.Black;
            this.btnExitLogin.IconSize = 40;
            this.btnExitLogin.Location = new System.Drawing.Point(208, 12);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Rotation = 0D;
            this.btnExitLogin.Size = new System.Drawing.Size(45, 40);
            this.btnExitLogin.TabIndex = 2;
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            this.btnExitLogin.MouseEnter += new System.EventHandler(this.btnExitLogin_MouseEnter);
            this.btnExitLogin.MouseLeave += new System.EventHandler(this.btnExitLogin_MouseLeave);
            // 
            // lblSignIn
            // 
            this.lblSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSignIn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(265, 58);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(19, 102);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter your Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(225, 25);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseCustomForeColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMark = "Enter your Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(19, 156);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Enter your Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(225, 25);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter your Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // iconBtnSignIn
            // 
            this.iconBtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSignIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconBtnSignIn.IconColor = System.Drawing.Color.Black;
            this.iconBtnSignIn.IconSize = 30;
            this.iconBtnSignIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnSignIn.Location = new System.Drawing.Point(144, 189);
            this.iconBtnSignIn.Name = "iconBtnSignIn";
            this.iconBtnSignIn.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnSignIn.Rotation = 0D;
            this.iconBtnSignIn.Size = new System.Drawing.Size(100, 38);
            this.iconBtnSignIn.TabIndex = 12;
            this.iconBtnSignIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnSignIn.UseVisualStyleBackColor = true;
            this.iconBtnSignIn.Click += new System.EventHandler(this.iconBtnSignIn_Click);
            this.iconBtnSignIn.MouseEnter += new System.EventHandler(this.iconBtnSignIn_MouseEnter);
            this.iconBtnSignIn.MouseLeave += new System.EventHandler(this.iconBtnSignIn_MouseLeave);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(21, 234);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(165, 23);
            this.lblNoAccount.TabIndex = 13;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // linkLblSignUp
            // 
            this.linkLblSignUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLblSignUp.AutoSize = true;
            this.linkLblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblSignUp.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLblSignUp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblSignUp.LinkColor = System.Drawing.Color.Red;
            this.linkLblSignUp.Location = new System.Drawing.Point(159, 234);
            this.linkLblSignUp.Name = "linkLblSignUp";
            this.linkLblSignUp.Size = new System.Drawing.Size(52, 18);
            this.linkLblSignUp.TabIndex = 14;
            this.linkLblSignUp.TabStop = true;
            this.linkLblSignUp.Text = "Sign Up";
            this.linkLblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSignUp_LinkClicked);
            this.linkLblSignUp.MouseEnter += new System.EventHandler(this.linkLblSignUp_MouseEnter);
            this.linkLblSignUp.MouseLeave += new System.EventHandler(this.linkLblSignUp_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 269);
            this.Controls.Add(this.linkLblSignUp);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.iconBtnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(265, 269);
            this.MinimumSize = new System.Drawing.Size(265, 269);
            this.Name = "Login";
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblSignIn;
        private FontAwesome.Sharp.IconButton btnExitLogin;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private FontAwesome.Sharp.IconButton iconBtnSignIn;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel linkLblSignUp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

