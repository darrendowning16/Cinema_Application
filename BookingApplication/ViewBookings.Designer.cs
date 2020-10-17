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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingApplicationDataSet = new BookingApplication.BookingApplicationDataSet();
            this.bookingsTableAdapter = new BookingApplication.BookingApplicationDataSetTableAdapters.BookingsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingApplicationDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.nameDataGridViewTextBoxColumn,
            this.bookingEmailDataGridViewTextBoxColumn,
            this.movieDataGridViewTextBoxColumn,
            this.movieTimeDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "BookingID";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.BookingID.DefaultCellStyle = dataGridViewCellStyle2;
            this.BookingID.HeaderText = "ID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            this.BookingID.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookingEmailDataGridViewTextBoxColumn
            // 
            this.bookingEmailDataGridViewTextBoxColumn.DataPropertyName = "BookingEmail";
            this.bookingEmailDataGridViewTextBoxColumn.HeaderText = "Booking Email";
            this.bookingEmailDataGridViewTextBoxColumn.Name = "bookingEmailDataGridViewTextBoxColumn";
            this.bookingEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            this.movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            this.movieDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieDataGridViewTextBoxColumn.Width = 160;
            // 
            // movieTimeDataGridViewTextBoxColumn
            // 
            this.movieTimeDataGridViewTextBoxColumn.DataPropertyName = "MovieTime";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.movieTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.movieTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.movieTimeDataGridViewTextBoxColumn.Name = "movieTimeDataGridViewTextBoxColumn";
            this.movieTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "TicketPrice";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ticketPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ticket Price";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            this.ticketPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 140;
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
            this.txtboxBookingEmail.Style = MetroFramework.MetroColorStyle.Black;
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
            this.IconbtnLogOut.IconSize = 40;
            this.IconbtnLogOut.Location = new System.Drawing.Point(757, 30);
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
            this.IconbtnExitBooking.IconSize = 40;
            this.IconbtnExitBooking.Location = new System.Drawing.Point(810, 26);
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
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 78);
            this.panel1.TabIndex = 9;
            // 
            // lblBookingEmail
            // 
            this.lblBookingEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingEmail.ForeColor = System.Drawing.Color.White;
            this.lblBookingEmail.Location = new System.Drawing.Point(278, 3);
            this.lblBookingEmail.Name = "lblBookingEmail";
            this.lblBookingEmail.Size = new System.Drawing.Size(195, 30);
            this.lblBookingEmail.TabIndex = 14;
            this.lblBookingEmail.Text = "Enter your Booking Email";
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
            this.iconbtnEdit.IconSize = 40;
            this.iconbtnEdit.Location = new System.Drawing.Point(641, 31);
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
            this.icnbtnHome.IconSize = 40;
            this.icnbtnHome.Location = new System.Drawing.Point(698, 30);
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
            this.lblNoRecords.Size = new System.Drawing.Size(860, 41);
            this.lblNoRecords.TabIndex = 10;
            this.lblNoRecords.Text = "No Bookings Found!";
            this.lblNoRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.lblNoRecords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBookings";
            this.Text = "ViewBookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingApplicationDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BookingApplicationDataSet bookingApplicationDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private BookingApplicationDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBookingEmail;
    }
}