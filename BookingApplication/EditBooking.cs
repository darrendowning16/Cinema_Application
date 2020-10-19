using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication
{
    public partial class EditBooking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I99UMVE\SQLEXPRESS;Initial Catalog=BookingApplication;Integrated Security=True"); // Estabilishes a connection between the program and SQL server
        SqlCommand cmd;


        double total = Convert.ToDouble(ViewBookings.TicketPrice), editTotal;
        int under4, child, teen, adult, senior;

        public EditBooking()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Starts the form in the center of the screen
        }

        string BookingID = ViewBookings.BookID; // Create variable 'ID' and store it as integer

        private void EditBooking_Load(object sender, EventArgs e)
        {
            txtBoxEditName.Text = ViewBookings.UsersName;
            txtBoxEditBookingEmail.Text = ViewBookings.BookingEmail;
            comboBoxEditMovieNames.SelectedItem = ViewBookings.MovieName;
            comboBoxEditMovieTimes.SelectedItem = ViewBookings.MovieTime;
            txtBoxEditPaymentType.Text = ViewBookings.PaymentType;
            comboBoxEditUnder4.SelectedItem = ViewBookings.Under4sEditTickets;
            comboBoxEditChild.SelectedItem = ViewBookings.ChildEditTickets;
            comboBoxEditTeen.SelectedItem = ViewBookings.TeenEditTickets;
            comboBoxEditSenior.SelectedItem = ViewBookings.SeniorEditTickets;
            comboBoxEditAdult.SelectedItem = ViewBookings.AdultEditTickets;
            //lblEditFinalPrice.Text = "0";
        }

        private void icnbtnEditHome_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();//opens a form called Menu
            this.Hide();//hides the previous form
            menu.ShowDialog();//opens the form
            this.Close();//closes the form
        }

        private void icnEditReset_Click(object sender, EventArgs e)
        {
            const string Confirm = "Are you sure you want to reset data back to default?";
            const string caption = "Reset Data?";
            DialogResult result = MessageBox.Show(Confirm, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtBoxEditName.Text = ViewBookings.UsersName;
                txtBoxEditBookingEmail.Text = ViewBookings.BookingEmail;
                comboBoxEditMovieNames.SelectedItem = ViewBookings.MovieName;
                comboBoxEditMovieTimes.SelectedItem = ViewBookings.MovieTime;
                txtBoxEditPaymentType.Text = ViewBookings.PaymentType;
                comboBoxEditUnder4.SelectedItem = ViewBookings.Under4sEditTickets;
                comboBoxEditChild.SelectedItem = ViewBookings.ChildEditTickets;
                comboBoxEditTeen.SelectedItem = ViewBookings.TeenEditTickets;
                comboBoxEditSenior.SelectedItem = ViewBookings.SeniorEditTickets;
                comboBoxEditAdult.SelectedItem = ViewBookings.AdultEditTickets;
            }
                
        }

        private void comboBoxEditUnder4_SelectedIndexChanged(object sender, EventArgs e)
        {
            under4 = Convert.ToInt32(comboBoxEditUnder4.SelectedItem) * 1;
            price();
        }

        private void comboBoxEditChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            child = Convert.ToInt32(comboBoxEditChild.SelectedItem) * 3;
            price();
        }

        private void comboBoxEditTeen_SelectedIndexChanged(object sender, EventArgs e)
        {
            teen = Convert.ToInt32(comboBoxEditTeen.SelectedItem) * 4;
            price();
        }

        private void comboBoxEditSenior_SelectedIndexChanged(object sender, EventArgs e)
        {
            senior = Convert.ToInt32(comboBoxEditSenior.SelectedItem) * 4;
            price();
        }

        private void comboBoxEditAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            adult = Convert.ToInt32(comboBoxEditAdult.SelectedItem) * 6;
            price();
        }

        private void IconbtnEditLogOut_Click(object sender, EventArgs e)
        {
            const string LogoutConfirmation = "Are you sure you want to log out?";
            const string caption = "Logging out";

            var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();//opens a form called Login
                this.Hide();//hides the previous form
                login.ShowDialog();//opens the form
                this.Close();//closes the form
            }
        }

        private void IconbtnExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icnEditSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEditName.Text.Trim()) || string.IsNullOrEmpty(txtBoxEditBookingEmail.Text.Trim()))
            {
                const string RequiredFieldsError = "Fields can not be empty";
                const string caption = "Empty Fields";

                var result = MessageBox.Show(RequiredFieldsError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBoxEditUnder4.SelectedIndex != 0 || comboBoxEditChild.SelectedIndex != 0 || comboBoxEditTeen.SelectedIndex != 0 ||
                    comboBoxEditAdult.SelectedIndex != 0 || comboBoxEditSenior.SelectedIndex != 0)
                {
                    if(editTotal > total || editTotal == total)
                    {
                        if (txtBoxEditPaymentType.Text == "Credit Card")
                        {
                            string UpdatePayment = "Original Price: £" + total.ToString("F") + Environment.NewLine + "New Payment: £" + (editTotal + editTotal * 0.05).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Remaining Cost to be paid: £" + ((editTotal + editTotal * 0.05) - total).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Confirm?";
                            string captionUpdatePayment = "Payment";

                            var resultUpdatePayment = MessageBox.Show(UpdatePayment, captionUpdatePayment, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultUpdatePayment == DialogResult.Yes)
                            {
                                con.Open(); // Opens the connection
                                cmd = new SqlCommand("UPDATE dbo.Bookings SET Name=@Name, BookingEmail=@BookingEmail, Movie=@Movie, MovieTime=@MovieTime, TicketPrice=@TicketPrice, PaymentType=@PaymentType, Email=@Email WHERE BookingID=@BookingID", con);
                                cmd.Parameters.AddWithValue("@BookingID", BookingID); // Stores the ID collected from the command to the @ID variable
                                cmd.Parameters.AddWithValue("@Name", txtBoxEditName.Text);
                                cmd.Parameters.AddWithValue("@BookingEmail", txtBoxEditBookingEmail.Text);
                                cmd.Parameters.AddWithValue("@Movie", comboBoxEditMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                                cmd.Parameters.AddWithValue("@MovieTime", comboBoxEditMovieTimes.SelectedItem);
                                cmd.Parameters.AddWithValue("@TicketPrice", lblEditFinalPrice.Text);
                                cmd.Parameters.AddWithValue("@PaymentType", txtBoxEditPaymentType.Text);
                                cmd.Parameters.AddWithValue("@Email", Login.Email);

                                cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)
                                MessageBox.Show("Booking Updated Successfully");
                                con.Close();

                                const string LogoutConfirmation = "Would you like to return to the View Booking page to view your Booking?";
                                const string caption = "View Booking?";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    ViewBookings viewBookings = new ViewBookings();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    viewBookings.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                                else
                                {
                                    Menu menu = new Menu();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    menu.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                            }
                        }
                        else
                        {
                            string UpdatePayment = "Original Price: £" + total.ToString("F") + Environment.NewLine + "New Payment: £" + (editTotal + editTotal * 0.03).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Remaining Cost to be paid: £" + ((editTotal + editTotal * 0.03) - total).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Confirm?";
                            string captionUpdatePayment = "Payment";

                            var resultUpdatePayment = MessageBox.Show(UpdatePayment, captionUpdatePayment, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultUpdatePayment == DialogResult.Yes)
                            {
                                con.Open(); // Opens the connection
                                cmd = new SqlCommand("UPDATE dbo.Bookings SET Name=@Name, BookingEmail=@BookingEmail, Movie=@Movie, MovieTime=@MovieTime, TicketPrice=@TicketPrice, PaymentType=@PaymentType, Email=@Email WHERE BookingID=@BookingID", con);
                                cmd.Parameters.AddWithValue("@BookingID", BookingID); // Stores the ID collected from the command to the @ID variable
                                cmd.Parameters.AddWithValue("@Name", txtBoxEditName.Text);
                                cmd.Parameters.AddWithValue("@BookingEmail", txtBoxEditBookingEmail.Text);
                                cmd.Parameters.AddWithValue("@Movie", comboBoxEditMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                                cmd.Parameters.AddWithValue("@MovieTime", comboBoxEditMovieTimes.SelectedItem);
                                cmd.Parameters.AddWithValue("@TicketPrice", lblEditFinalPrice.Text);
                                cmd.Parameters.AddWithValue("@PaymentType", txtBoxEditPaymentType.Text);
                                cmd.Parameters.AddWithValue("@Email", Login.Email);

                                cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)
                                MessageBox.Show("Booking Updated Successfully");
                                con.Close();

                                const string LogoutConfirmation = "Would you like to return to the View Booking page to view your Booking?";
                                const string caption = "View Booking?";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    ViewBookings viewBookings = new ViewBookings();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    viewBookings.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                                else
                                {
                                    Menu menu = new Menu();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    menu.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                            }
                        }
                    }
                    if (total > editTotal)
                    {
                        if (txtBoxEditPaymentType.Text == "Credit Card")
                        {
                            string UpdatePaymentplus = "Original Price: £" + total.ToString("F") + Environment.NewLine + "New Payment: £" + (editTotal + editTotal * 0.05).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "You will be refunded: £" + (total - (editTotal + editTotal * 0.05)).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Confirm?";
                            string captionUpdatePaymentplus = "Confirm?";

                            var resultUpdatePaymentplus = MessageBox.Show(UpdatePaymentplus, captionUpdatePaymentplus, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (resultUpdatePaymentplus == DialogResult.Yes)
                            {
                                con.Open(); // Opens the connection
                                cmd = new SqlCommand("UPDATE dbo.Bookings SET Name=@Name, BookingEmail=@BookingEmail, Movie=@Movie, MovieTime=@MovieTime, TicketPrice=@TicketPrice, PaymentType=@PaymentType, Email=@Email WHERE BookingID=@BookingID", con);
                                cmd.Parameters.AddWithValue("@BookingID", BookingID); // Stores the ID collected from the command to the @ID variable
                                cmd.Parameters.AddWithValue("@Name", txtBoxEditName.Text);
                                cmd.Parameters.AddWithValue("@BookingEmail", txtBoxEditBookingEmail.Text);
                                cmd.Parameters.AddWithValue("@Movie", comboBoxEditMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                                cmd.Parameters.AddWithValue("@MovieTime", comboBoxEditMovieTimes.SelectedItem);
                                cmd.Parameters.AddWithValue("@TicketPrice", lblEditFinalPrice.Text);
                                cmd.Parameters.AddWithValue("@PaymentType", txtBoxEditPaymentType.Text);
                                cmd.Parameters.AddWithValue("@Email", Login.Email);

                                cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)
                                MessageBox.Show("Record Updated Successfully");
                                con.Close();

                                const string LogoutConfirmation = "Would you like to return to the View Booking page to view your Booking?";
                                const string caption = "View Booking?";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    ViewBookings viewBookings = new ViewBookings();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    viewBookings.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                                else
                                {
                                    Menu menu = new Menu();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    menu.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                            }
                            else
                            {
                                const string LogoutConfirmation = "Payment Cancelled, you have not been charged";
                                const string caption = "Payment";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            string UpdatePaymentplus = "Original Price: £" + total.ToString("F") + Environment.NewLine + "New Payment: £" + (editTotal + editTotal * 0.03).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "You will be refunded: £" + (total - (editTotal + editTotal * 0.03)).ToString("F")
                            + Environment.NewLine + Environment.NewLine + "Confirm?";
                            string captionUpdatePaymentplus = "Confirm?";

                            var resultUpdatePaymentplus = MessageBox.Show(UpdatePaymentplus, captionUpdatePaymentplus, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (resultUpdatePaymentplus == DialogResult.Yes)
                            {
                                con.Open(); // Opens the connection
                                cmd = new SqlCommand("UPDATE dbo.Bookings SET Name=@Name, BookingEmail=@BookingEmail, Movie=@Movie, MovieTime=@MovieTime, TicketPrice=@TicketPrice, PaymentType=@PaymentType, Email=@Email WHERE BookingID=@BookingID", con);
                                cmd.Parameters.AddWithValue("@BookingID", BookingID); // Stores the ID collected from the command to the @ID variable
                                cmd.Parameters.AddWithValue("@Name", txtBoxEditName.Text);
                                cmd.Parameters.AddWithValue("@BookingEmail", txtBoxEditBookingEmail.Text);
                                cmd.Parameters.AddWithValue("@Movie", comboBoxEditMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                                cmd.Parameters.AddWithValue("@MovieTime", comboBoxEditMovieTimes.SelectedItem);
                                cmd.Parameters.AddWithValue("@TicketPrice", lblEditFinalPrice.Text);
                                cmd.Parameters.AddWithValue("@PaymentType", txtBoxEditPaymentType.Text);
                                cmd.Parameters.AddWithValue("@Email", Login.Email);

                                cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)
                                MessageBox.Show("Record Updated Successfully");
                                con.Close();

                                const string LogoutConfirmation = "Would you like to return to the View Booking page to view your Booking?";
                                const string caption = "View Booking?";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    ViewBookings viewBookings = new ViewBookings();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    viewBookings.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                                else
                                {
                                    Menu menu = new Menu();//opens a form called Menu
                                    this.Hide();//hides the previous form
                                    menu.ShowDialog();//opens the form
                                    this.Close();//closes the form
                                }
                            }
                            else
                            {
                                const string LogoutConfirmation = "Payment Cancelled, you have not been charged";
                                const string caption = "Payment";

                                var result = MessageBox.Show(LogoutConfirmation, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    const string NoTickets = "No tickets selected, please select at least 1 ticket to continue";
                    const string caption = "No ticket";

                    var result = MessageBox.Show(NoTickets, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void price()
        {
            if(txtBoxEditPaymentType.Text == "Credit Card")
            {
                editTotal = Convert.ToInt32((under4 + child + teen + adult + senior));

                lblEditFinalPrice.Text = "£" + (editTotal + editTotal * 0.05 ).ToString("F");
            }
            else
            {
                editTotal = Convert.ToInt32((under4 + child + teen + adult + senior));

                lblEditFinalPrice.Text = "£" + (editTotal + editTotal * 0.03).ToString("F");
            }
        }
    }
}
