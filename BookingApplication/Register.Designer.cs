namespace BookingApplication
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitRegister = new FontAwesome.Sharp.IconButton();
            this.lblRegistrationForm = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.picBoxRegister = new System.Windows.Forms.PictureBox();
            this.iconBtnBack = new FontAwesome.Sharp.IconButton();
            this.iconBtnRegister = new FontAwesome.Sharp.IconButton();
            this.toolTipRegisterForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(122, 345);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(73, 50);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 18);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(30, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 18);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 275);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(115, 18);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnExitRegister);
            this.panel1.Controls.Add(this.lblRegistrationForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 58);
            this.panel1.TabIndex = 12;
            // 
            // btnExitRegister
            // 
            this.btnExitRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitRegister.FlatAppearance.BorderSize = 0;
            this.btnExitRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitRegister.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExitRegister.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExitRegister.IconColor = System.Drawing.Color.Black;
            this.btnExitRegister.IconSize = 40;
            this.btnExitRegister.Location = new System.Drawing.Point(747, 12);
            this.btnExitRegister.Name = "btnExitRegister";
            this.btnExitRegister.Rotation = 0D;
            this.btnExitRegister.Size = new System.Drawing.Size(45, 40);
            this.btnExitRegister.TabIndex = 0;
            this.btnExitRegister.TabStop = false;
            this.btnExitRegister.UseVisualStyleBackColor = true;
            this.btnExitRegister.Click += new System.EventHandler(this.btnExitRegister_Click);
            this.btnExitRegister.MouseEnter += new System.EventHandler(this.btnExitRegister_MouseEnter);
            this.btnExitRegister.MouseLeave += new System.EventHandler(this.btnExitRegister_MouseLeave);
            // 
            // lblRegistrationForm
            // 
            this.lblRegistrationForm.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationForm.Location = new System.Drawing.Point(0, 0);
            this.lblRegistrationForm.Name = "lblRegistrationForm";
            this.lblRegistrationForm.Size = new System.Drawing.Size(804, 58);
            this.lblRegistrationForm.TabIndex = 1;
            this.lblRegistrationForm.Text = "Register";
            this.lblRegistrationForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(32, 114);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter your Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(251, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter your Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(32, 174);
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
            this.txtEmail.Size = new System.Drawing.Size(251, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Enter your Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(33, 237);
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
            this.txtPassword.Size = new System.Drawing.Size(251, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter your Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(34, 308);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PromptText = "Confirm your Password";
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.ShowClearButton = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(251, 23);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.WaterMark = "Confirm your Password";
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picBoxRegister
            // 
            this.picBoxRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxRegister.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRegister.Image")));
            this.picBoxRegister.Location = new System.Drawing.Point(303, 58);
            this.picBoxRegister.Name = "picBoxRegister";
            this.picBoxRegister.Size = new System.Drawing.Size(501, 358);
            this.picBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRegister.TabIndex = 17;
            this.picBoxRegister.TabStop = false;
            // 
            // iconBtnBack
            // 
            this.iconBtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconBtnBack.IconColor = System.Drawing.Color.Black;
            this.iconBtnBack.IconSize = 30;
            this.iconBtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnBack.Location = new System.Drawing.Point(34, 345);
            this.iconBtnBack.Name = "iconBtnBack";
            this.iconBtnBack.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.iconBtnBack.Rotation = 0D;
            this.iconBtnBack.Size = new System.Drawing.Size(73, 50);
            this.iconBtnBack.TabIndex = 5;
            this.iconBtnBack.UseVisualStyleBackColor = true;
            this.iconBtnBack.Click += new System.EventHandler(this.iconBtnBack_Click);
            this.iconBtnBack.MouseEnter += new System.EventHandler(this.iconBtnBack_MouseEnter);
            this.iconBtnBack.MouseLeave += new System.EventHandler(this.iconBtnBack_MouseLeave);
            // 
            // iconBtnRegister
            // 
            this.iconBtnRegister.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnRegister.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconBtnRegister.IconColor = System.Drawing.Color.Black;
            this.iconBtnRegister.IconSize = 30;
            this.iconBtnRegister.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnRegister.Location = new System.Drawing.Point(210, 345);
            this.iconBtnRegister.Name = "iconBtnRegister";
            this.iconBtnRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.iconBtnRegister.Rotation = 0D;
            this.iconBtnRegister.Size = new System.Drawing.Size(73, 50);
            this.iconBtnRegister.TabIndex = 7;
            this.iconBtnRegister.UseVisualStyleBackColor = true;
            this.iconBtnRegister.Click += new System.EventHandler(this.iconBtnRegister_Click);
            this.iconBtnRegister.MouseEnter += new System.EventHandler(this.iconBtnRegister_MouseEnter);
            this.iconBtnRegister.MouseLeave += new System.EventHandler(this.iconBtnRegister_MouseLeave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 416);
            this.Controls.Add(this.iconBtnRegister);
            this.Controls.Add(this.iconBtnBack);
            this.Controls.Add(this.picBoxRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClearAll);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistrationForm;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox picBoxRegister;
        private FontAwesome.Sharp.IconButton btnExitRegister;
        private FontAwesome.Sharp.IconButton iconBtnBack;
        private FontAwesome.Sharp.IconButton iconBtnRegister;
        private System.Windows.Forms.ToolTip toolTipRegisterForm;
    }
}