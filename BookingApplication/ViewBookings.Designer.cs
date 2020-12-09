namespace BookingApplication
{
    partial class ViewBookings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSignInEmail = new System.Windows.Forms.Label();
            this.txtSignInEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtboxBookingEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnSearchEmail = new FontAwesome.Sharp.IconButton();
            this.IconbtnLogOut = new FontAwesome.Sharp.IconButton();
            this.IconbtnExitBooking = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookingEmail = new System.Windows.Forms.Label();
            this.iconbtnEdit = new FontAwesome.Sharp.IconButton();
            this.icnbtnHome = new FontAwesome.Sharp.IconButton();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingApplicationDataSet = new BookingApplication.BookingApplicationDataSet();
            this.bookingsTableAdapter = new BookingApplication.BookingApplicationDataSetTableAdapters.BookingsTableAdapter();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.under4TicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teenTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingApplicationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignInEmail
            // 
            this.lblSignInEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInEmail.ForeColor = System.Drawing.Color.White;
            this.lblSignInEmail.Location = new System.Drawing.Point(8, 0);
            this.lblSignInEmail.Name = "lblSignInEmail";
            this.lblSignInEmail.Size = new System.Drawing.Size(104, 30);
            this.lblSignInEmail.TabIndex = 1;
            this.lblSignInEmail.Text = "Signed in as: ";
            this.lblSignInEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSignInEmail
            // 
            this.txtSignInEmail.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txtSignInEmail.CustomButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInEmail.CustomButton.Image = null;
            this.txtSignInEmail.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtSignInEmail.CustomButton.Name = "";
            this.txtSignInEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSignInEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSignInEmail.CustomButton.TabIndex = 1;
            this.txtSignInEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSignInEmail.CustomButton.UseSelectable = true;
            this.txtSignInEmail.CustomButton.Visible = false;
            this.txtSignInEmail.Enabled = false;
            this.txtSignInEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSignInEmail.Lines = new string[0];
            this.txtSignInEmail.Location = new System.Drawing.Point(12, 33);
            this.txtSignInEmail.MaxLength = 32767;
            this.txtSignInEmail.Name = "txtSignInEmail";
            this.txtSignInEmail.PasswordChar = '\0';
            this.txtSignInEmail.ReadOnly = true;
            this.txtSignInEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSignInEmail.SelectedText = "";
            this.txtSignInEmail.SelectionLength = 0;
            this.txtSignInEmail.SelectionStart = 0;
            this.txtSignInEmail.ShortcutsEnabled = true;
            this.txtSignInEmail.Size = new System.Drawing.Size(250, 30);
            this.txtSignInEmail.TabIndex = 5;
            this.txtSignInEmail.UseSelectable = true;
            this.txtSignInEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSignInEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtboxBookingEmail
            // 
            this.txtboxBookingEmail.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txtboxBookingEmail.CustomButton.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxBookingEmail.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.txtboxBookingEmail.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtboxBookingEmail.CustomButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBookingEmail.CustomButton.Image = null;
            this.txtboxBookingEmail.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtboxBookingEmail.CustomButton.Name = "";
            this.txtboxBookingEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtboxBookingEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxBookingEmail.CustomButton.TabIndex = 1;
            this.txtboxBookingEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxBookingEmail.CustomButton.UseSelectable = true;
            this.txtboxBookingEmail.CustomButton.UseVisualStyleBackColor = false;
            this.txtboxBookingEmail.CustomButton.Visible = false;
            this.txtboxBookingEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtboxBookingEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtboxBookingEmail.Lines = new string[0];
            this.txtboxBookingEmail.Location = new System.Drawing.Point(282, 34);
            this.txtboxBookingEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtboxBookingEmail.MaxLength = 32767;
            this.txtboxBookingEmail.Name = "txtboxBookingEmail";
            this.txtboxBookingEmail.PasswordChar = '\0';
            this.txtboxBookingEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxBookingEmail.SelectedText = "";
            this.txtboxBookingEmail.SelectionLength = 0;
            this.txtboxBookingEmail.SelectionStart = 0;
            this.txtboxBookingEmail.ShortcutsEnabled = true;
            this.txtboxBookingEmail.Size = new System.Drawing.Size(250, 30);
            this.txtboxBookingEmail.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtboxBookingEmail.TabIndex = 6;
            this.txtboxBookingEmail.UseSelectable = true;
            this.txtboxBookingEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxBookingEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearchEmail
            // 
            this.btnSearchEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchEmail.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchEmail.IconColor = System.Drawing.Color.Black;
            this.btnSearchEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchEmail.IconSize = 20;
            this.btnSearchEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchEmail.Location = new System.Drawing.Point(535, 33);
            this.btnSearchEmail.Name = "btnSearchEmail";
            this.btnSearchEmail.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSearchEmail.Rotation = 0D;
            this.btnSearchEmail.Size = new System.Drawing.Size(59, 32);
            this.btnSearchEmail.TabIndex = 7;
            this.btnSearchEmail.UseVisualStyleBackColor = false;
            this.btnSearchEmail.Click += new System.EventHandler(this.btnSearchEmail_Click);
            // 
            // IconbtnLogOut
            // 
            this.IconbtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.IconbtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconbtnLogOut.FlatAppearance.BorderSize = 0;
            this.IconbtnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconbtnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconbtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconbtnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconbtnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IconbtnLogOut.IconColor = System.Drawing.Color.Black;
            this.IconbtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconbtnLogOut.IconSize = 40;
            this.IconbtnLogOut.Location = new System.Drawing.Point(982, 30);
            this.IconbtnLogOut.Name = "IconbtnLogOut";
            this.IconbtnLogOut.Rotation = 0D;
            this.IconbtnLogOut.Size = new System.Drawing.Size(50, 34);
            this.IconbtnLogOut.TabIndex = 10;
            this.IconbtnLogOut.UseVisualStyleBackColor = false;
            this.IconbtnLogOut.Click += new System.EventHandler(this.IconbtnLogOut_Click);
            // 
            // IconbtnExitBooking
            // 
            this.IconbtnExitBooking.BackColor = System.Drawing.Color.Transparent;
            this.IconbtnExitBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconbtnExitBooking.FlatAppearance.BorderSize = 0;
            this.IconbtnExitBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconbtnExitBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconbtnExitBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconbtnExitBooking.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconbtnExitBooking.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IconbtnExitBooking.IconColor = System.Drawing.Color.Black;
            this.IconbtnExitBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconbtnExitBooking.IconSize = 40;
            this.IconbtnExitBooking.Location = new System.Drawing.Point(1035, 26);
            this.IconbtnExitBooking.Name = "IconbtnExitBooking";
            this.IconbtnExitBooking.Rotation = 0D;
            this.IconbtnExitBooking.Size = new System.Drawing.Size(45, 40);
            this.IconbtnExitBooking.TabIndex = 11;
            this.IconbtnExitBooking.UseVisualStyleBackColor = false;
            this.IconbtnExitBooking.Click += new System.EventHandler(this.IconbtnExitBooking_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.txtboxBookingEmail);
            this.panel1.Controls.Add(this.lblBookingEmail);
            this.panel1.Controls.Add(this.iconbtnEdit);
            this.panel1.Controls.Add(this.icnbtnHome);
            this.panel1.Controls.Add(this.IconbtnExitBooking);
            this.panel1.Controls.Add(this.IconbtnLogOut);
            this.panel1.Controls.Add(this.txtSignInEmail);
            this.panel1.Controls.Add(this.lblSignInEmail);
            this.panel1.Controls.Add(this.btnSearchEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 78);
            this.panel1.TabIndex = 9;
            // 
            // lblBookingEmail
            // 
            this.lblBookingEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingEmail.ForeColor = System.Drawing.Color.White;
            this.lblBookingEmail.Location = new System.Drawing.Point(278, 3);
            this.lblBookingEmail.Name = "lblBookingEmail";
            this.lblBookingEmail.Size = new System.Drawing.Size(204, 30);
            this.lblBookingEmail.TabIndex = 14;
            this.lblBookingEmail.Text = "Enter your Booking Email:";
            this.lblBookingEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconbtnEdit
            // 
            this.iconbtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.iconbtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnEdit.FlatAppearance.BorderSize = 0;
            this.iconbtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconbtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconbtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconbtnEdit.IconColor = System.Drawing.Color.Black;
            this.iconbtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnEdit.IconSize = 40;
            this.iconbtnEdit.Location = new System.Drawing.Point(866, 31);
            this.iconbtnEdit.Name = "iconbtnEdit";
            this.iconbtnEdit.Rotation = 0D;
            this.iconbtnEdit.Size = new System.Drawing.Size(50, 34);
            this.iconbtnEdit.TabIndex = 13;
            this.iconbtnEdit.UseVisualStyleBackColor = false;
            this.iconbtnEdit.Click += new System.EventHandler(this.iconbtnEdit_Click);
            // 
            // icnbtnHome
            // 
            this.icnbtnHome.BackColor = System.Drawing.Color.Transparent;
            this.icnbtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnbtnHome.FlatAppearance.BorderSize = 0;
            this.icnbtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icnbtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icnbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnbtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icnbtnHome.IconColor = System.Drawing.Color.Black;
            this.icnbtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnHome.IconSize = 40;
            this.icnbtnHome.Location = new System.Drawing.Point(923, 30);
            this.icnbtnHome.Name = "icnbtnHome";
            this.icnbtnHome.Rotation = 0D;
            this.icnbtnHome.Size = new System.Drawing.Size(50, 34);
            this.icnbtnHome.TabIndex = 12;
            this.icnbtnHome.UseVisualStyleBackColor = false;
            this.icnbtnHome.Click += new System.EventHandler(this.icnbtnHome_Click);
            // 
            // lblNoRecords
            // 
            this.lblNoRecords.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecords.Location = new System.Drawing.Point(0, 69);
            this.lblNoRecords.Name = "lblNoRecords";
            this.lblNoRecords.Size = new System.Drawing.Size(1090, 41);
            this.lblNoRecords.TabIndex = 10;
            this.lblNoRecords.Text = "No Bookings Found!";
            this.lblNoRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bookingEmailDataGridViewTextBoxColumn,
            this.movieDataGridViewTextBoxColumn,
            this.movieTimeDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.under4TicketsDataGridViewTextBoxColumn,
            this.childTicketsDataGridViewTextBoxColumn,
            this.teenTicketsDataGridViewTextBoxColumn,
            this.adultTicketsDataGridViewTextBoxColumn,
            this.seniorTicketsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 370);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.bookingApplicationDataSet;
            // 
            // bookingApplicationDataSet
            // 
            this.bookingApplicationDataSet.DataSetName = "BookingApplicationDataSet";
            this.bookingApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bookingIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookingEmailDataGridViewTextBoxColumn
            // 
            this.bookingEmailDataGridViewTextBoxColumn.DataPropertyName = "BookingEmail";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bookingEmailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookingEmailDataGridViewTextBoxColumn.HeaderText = "Booking Email";
            this.bookingEmailDataGridViewTextBoxColumn.Name = "bookingEmailDataGridViewTextBoxColumn";
            this.bookingEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingEmailDataGridViewTextBoxColumn.Width = 230;
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.movieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            this.movieDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieDataGridViewTextBoxColumn.Width = 200;
            // 
            // movieTimeDataGridViewTextBoxColumn
            // 
            this.movieTimeDataGridViewTextBoxColumn.DataPropertyName = "MovieTime";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.movieTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.movieTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.movieTimeDataGridViewTextBoxColumn.Name = "movieTimeDataGridViewTextBoxColumn";
            this.movieTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "TicketPrice";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ticketPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ticket Price";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            this.ticketPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.paymentTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 160;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // under4TicketsDataGridViewTextBoxColumn
            // 
            this.under4TicketsDataGridViewTextBoxColumn.DataPropertyName = "Under4Tickets";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.under4TicketsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.under4TicketsDataGridViewTextBoxColumn.HeaderText = "Under4\'s";
            this.under4TicketsDataGridViewTextBoxColumn.Name = "under4TicketsDataGridViewTextBoxColumn";
            this.under4TicketsDataGridViewTextBoxColumn.ReadOnly = true;
            this.under4TicketsDataGridViewTextBoxColumn.Width = 130;
            // 
            // childTicketsDataGridViewTextBoxColumn
            // 
            this.childTicketsDataGridViewTextBoxColumn.DataPropertyName = "ChildTickets";
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.childTicketsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.childTicketsDataGridViewTextBoxColumn.HeaderText = "Child";
            this.childTicketsDataGridViewTextBoxColumn.Name = "childTicketsDataGridViewTextBoxColumn";
            this.childTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            this.childTicketsDataGridViewTextBoxColumn.Width = 130;
            // 
            // teenTicketsDataGridViewTextBoxColumn
            // 
            this.teenTicketsDataGridViewTextBoxColumn.DataPropertyName = "TeenTickets";
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.teenTicketsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.teenTicketsDataGridViewTextBoxColumn.HeaderText = "Teen";
            this.teenTicketsDataGridViewTextBoxColumn.Name = "teenTicketsDataGridViewTextBoxColumn";
            this.teenTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            this.teenTicketsDataGridViewTextBoxColumn.Width = 130;
            // 
            // adultTicketsDataGridViewTextBoxColumn
            // 
            this.adultTicketsDataGridViewTextBoxColumn.DataPropertyName = "AdultTickets";
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.adultTicketsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.adultTicketsDataGridViewTextBoxColumn.HeaderText = "Adult";
            this.adultTicketsDataGridViewTextBoxColumn.Name = "adultTicketsDataGridViewTextBoxColumn";
            this.adultTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            this.adultTicketsDataGridViewTextBoxColumn.Width = 130;
            // 
            // seniorTicketsDataGridViewTextBoxColumn
            // 
            this.seniorTicketsDataGridViewTextBoxColumn.DataPropertyName = "SeniorTickets";
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.seniorTicketsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.seniorTicketsDataGridViewTextBoxColumn.HeaderText = "Senior";
            this.seniorTicketsDataGridViewTextBoxColumn.Name = "seniorTicketsDataGridViewTextBoxColumn";
            this.seniorTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1090, 448);
            this.Controls.Add(this.lblNoRecords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBookings";
            this.Text = "ViewBookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingApplicationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSignInEmail;
        private MetroFramework.Controls.MetroTextBox txtSignInEmail;
        private MetroFramework.Controls.MetroTextBox txtboxBookingEmail;
        private FontAwesome.Sharp.IconButton btnSearchEmail;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconbtnLogOut;
        private FontAwesome.Sharp.IconButton IconbtnExitBooking;
        private System.Windows.Forms.Label lblNoRecords;
        private FontAwesome.Sharp.IconButton icnbtnHome;
        private FontAwesome.Sharp.IconButton iconbtnEdit;
        private System.Windows.Forms.Label lblBookingEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookingApplicationDataSet bookingApplicationDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private BookingApplicationDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn under4TicketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childTicketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teenTicketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultTicketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorTicketsDataGridViewTextBoxColumn;
    }
}