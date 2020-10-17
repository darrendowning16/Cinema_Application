namespace BookingApplication
{
    partial class Menu
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
            this.btnBooking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconbtnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnExitMenu = new FontAwesome.Sharp.IconButton();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(30, 77);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(265, 57);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Start booking process";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.IconbtnLogOut);
            this.panel1.Controls.Add(this.btnExitMenu);
            this.panel1.Controls.Add(this.lblWelcomeBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 58);
            this.panel1.TabIndex = 4;
            // 
            // IconbtnLogOut
            // 
            this.IconbtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconbtnLogOut.FlatAppearance.BorderSize = 0;
            this.IconbtnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconbtnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconbtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconbtnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconbtnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IconbtnLogOut.IconColor = System.Drawing.Color.Black;
            this.IconbtnLogOut.IconSize = 40;
            this.IconbtnLogOut.Location = new System.Drawing.Point(232, 16);
            this.IconbtnLogOut.Name = "IconbtnLogOut";
            this.IconbtnLogOut.Rotation = 0D;
            this.IconbtnLogOut.Size = new System.Drawing.Size(50, 34);
            this.IconbtnLogOut.TabIndex = 3;
            this.IconbtnLogOut.UseVisualStyleBackColor = true;
            this.IconbtnLogOut.Click += new System.EventHandler(this.IconbtnLogOut_Click);
            this.IconbtnLogOut.MouseEnter += new System.EventHandler(this.IconbtnLogOut_MouseEnter);
            this.IconbtnLogOut.MouseLeave += new System.EventHandler(this.IconbtnLogOut_MouseLeave);
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitMenu.FlatAppearance.BorderSize = 0;
            this.btnExitMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExitMenu.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExitMenu.IconColor = System.Drawing.Color.Black;
            this.btnExitMenu.IconSize = 40;
            this.btnExitMenu.Location = new System.Drawing.Point(275, 13);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Rotation = 0D;
            this.btnExitMenu.Size = new System.Drawing.Size(45, 40);
            this.btnExitMenu.TabIndex = 2;
            this.btnExitMenu.UseVisualStyleBackColor = true;
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            this.btnExitMenu.MouseEnter += new System.EventHandler(this.btnExitMenu_MouseEnter);
            this.btnExitMenu.MouseLeave += new System.EventHandler(this.btnExitMenu_MouseLeave);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(314, 58);
            this.lblWelcomeBack.TabIndex = 1;
            this.lblWelcomeBack.Text = "Welcome Back";
            this.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBookings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookings.Location = new System.Drawing.Point(30, 140);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(265, 57);
            this.btnViewBookings.TabIndex = 5;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 218);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeBack;
        private FontAwesome.Sharp.IconButton btnExitMenu;
        private FontAwesome.Sharp.IconButton IconbtnLogOut;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.Button btnViewBookings;
    }
}