using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication
{
    public partial class ViewBookings : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I99UMVE\SQLEXPRESS;Initial Catalog=BookingApplication;Integrated Security=True"); // Estabilishes a connection between the program and SQL server
        SqlCommand cmd;

        public ViewBookings()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Variables to allow me to pass data to the edit form 

        public static string UsersName = "";
        public static string BookingEmail = "";
        public static string MovieName = "";
        public static string MovieTime = "";
        public static string TicketPrice = "";
        public static string PaymentType = "";
        public static string BookID = "";

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingApplicationDataSet.Bookings' table. You can move, or remove it, as needed.
            //this.bookingsTableAdapter.Fill(this.bookingApplicationDataSet.Bookings);

            txtSignInEmail.Text = Login.Email;
            iconbtnEdit.Visible = false;

        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxBookingEmail.Text.Trim()))
            {
                const string EmailRequired = "Booking Email can not be empty";
                const string caption = "Blank Email";

                var result = MessageBox.Show(EmailRequired, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtboxBookingEmail.Text.Trim(), EmailPattern))
                {
                    string query = "SELECT * FROM Bookings WHERE Email = @Email AND BookingEmail = @BookingEmail ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", Login.Email);
                    cmd.Parameters.AddWithValue("@BookingEmail", txtboxBookingEmail.Text);
                    con.Open(); // Opens the connection
                    cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)
                    DataTable dt = new DataTable(); // creates a datatable and Stores the data in dt 
                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Retrieves the data from the cmd command
                    da.Fill(dt); // Fills the da variable with the contents from the dt variable
                    if(dt.Rows.Count > 0)
                    {
                        lblNoRecords.Hide();
                        iconbtnEdit.Visible = true;
                        dataGridView1.DataSource = dt; // Sets the data grid to hold the data from the dt variable
                        con.Close(); // Closes the connection
                    }
                    else
                    {
                        const string NoEmailFound = "No Bookings with that email exist";
                        const string caption = "No Email Found";

                        var result = MessageBox.Show(NoEmailFound, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();

                    }
                }
                else
                {
                    const string EmailFormat = "Email is not in the correct format";
                    const string caption = "Incorrect Format";

                    var result = MessageBox.Show(EmailFormat, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IconbtnLogOut_Click(object sender, EventArgs e)
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

        private void IconbtnExitBooking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icnbtnHome_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();//opens a form called Menu
            this.Hide();//hides the previous form
            menu.ShowDialog();//opens the form
            this.Close();//closes the form
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                BookID = row.Cells[0].Value.ToString();
                UsersName = row.Cells[1].Value.ToString();
                BookingEmail = row.Cells[2].Value.ToString();
                MovieName = row.Cells[3].Value.ToString();
                MovieTime = row.Cells[4].Value.ToString();
                TicketPrice = row.Cells[5].Value.ToString();
                PaymentType = row.Cells[6].Value.ToString();
            }
        }

        private void iconbtnEdit_Click(object sender, EventArgs e)
        {
            EditBooking EditBooking = new EditBooking();//opens a form called EditBooking
            this.Hide();//hides the previous form
            EditBooking.ShowDialog();//opens the form
            this.Close();//closes the form
        }
    }
}
