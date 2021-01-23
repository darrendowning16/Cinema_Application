using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BookingApplication
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I99UMVE\SQLEXPRESS;Initial Catalog=BookingApplication;Integrated Security=True"); // Estabilishes a connection between the program and SQL server
        SqlCommand cmd; // Creates a new variable

        // Global variable 
        int ID = 0; // Create variable 'ID' and store it as integer

        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Starts the form in the center of the screen
        }

        private void iconBtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                const string RequiredFieldsError = "Fill in all the required fields";
                const string caption = "Required Fields";

                var result = MessageBox.Show(RequiredFieldsError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Start of User Validation

                string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"; // Variable used to store the Email regex
                if (Regex.IsMatch(txtEmail.Text, EmailPattern)) // Checks the entered email against the email pattern to verify the format
                {
                    if (txtPassword.Text == txtConfirmPassword.Text) // Checks the Password and the Confirmed Password are the same
                    {
                        if (txtName.Text.Length >= 2) // Checks if the Name entered is greater than or equal to 2 characters
                        {
                            if (txtName.Text.Length < 40) // Checks if the Name entered is less than 40 characters
                            {
                                if (txtEmail.Text.Length < 40) // Checks if the Email entered is greater than or equal to 2 characters
                                {
                                    if (txtPassword.Text.Length >= 2) // Checks if the Password entered is greater than or equal to 2 characters
                                    {
                                        if (txtPassword.Text.Length < 50)  // Checks if the Password entered is less than 50 characters
                                        {
                                            string query = "SELECT * FROM dbo.Accounts WHERE Email = '" + txtEmail.Text.Trim() + "'";
                                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                                            DataTable data = new DataTable();
                                            sda.Fill(data);
                                            if (data.Rows.Count > 0)
                                            {
                                                MessageBox.Show("Email already exists");
                                            }
                                            else
                                            {
                                                con.Open(); // Opens the connection
                                                cmd = new SqlCommand("INSERT into dbo.Accounts(Name, Email, Password) VALUES(@Name, @Email, @Password)", con);
                                                cmd.Parameters.AddWithValue("@id", ID); // Stores the ID collected from the command to the @ID variable
                                                cmd.Parameters.AddWithValue("@Name", txtName.Text); // Stores the Name collected from the command to the @Name variable
                                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text); // Stores the Email collected from the command to the @Email variable
                                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Stores the Password collected from the command to the @Password variable
                                                cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)

                                                const string AccountCreated = "Account created!, Please log in again to continue"; // Creates a constant variable called AccountCreated
                                                const string caption = "Account created!"; // Creates a constant variable called Caption

                                                var result = MessageBox.Show(AccountCreated, caption, MessageBoxButtons.OK, MessageBoxIcon.Information); // Displays a message to the user

                                                con.Close(); // Closes the connection

                                                txtName.Clear(); // Clears the Name textbox
                                                txtEmail.Clear(); // Clears the Email textbox
                                                txtPassword.Clear(); // Clears the Password textbox
                                                txtConfirmPassword.Clear(); // Clears the ConfirmPassword textbox

                                                Login login = new Login(); //Opens a form called Login
                                                this.Hide(); // Hides the previous form
                                                login.ShowDialog(); // Opens the form
                                                this.Close(); // Closes the form
                                            }
                                        }
                                        else
                                        {
                                            const string PasswordLengthErrorLong = "Password must be less than 50 characters";
                                            const string caption = "Invalid Password Length";

                                            var result = MessageBox.Show(PasswordLengthErrorLong, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        const string PasswordLengthErrorShort = "Password must be more than 2 characters";
                                        const string caption = "Invalid Password Length";

                                        var result = MessageBox.Show(PasswordLengthErrorShort, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    const string EmailLengthError = "Email must be less than 40 characters";
                                    const string caption = "Invalid Email Length";

                                    var result = MessageBox.Show(EmailLengthError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                const string NameLengthErrorLong = "Name must be less than 40 characters";
                                const string caption = "Invalid Name Length";

                                var result = MessageBox.Show(NameLengthErrorLong, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            const string NameLengthErrorShort = "Name must be more than 2 characters";
                            const string caption = "Invalid Name Length";

                            var result = MessageBox.Show(NameLengthErrorShort, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        const string PasswordMatchError = "Passwords do not match";
                        const string caption = "Invalid Password";

                        var result = MessageBox.Show(PasswordMatchError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    const string EmailFormat = "Email is not in the correct format";
                    const string caption = "Invalid Email Format";

                    var result = MessageBox.Show(EmailFormat, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clear All button
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtName.Text = ""; // Clears the name textbox 

            txtEmail.Text = ""; // Clears the Email textbox 

            txtPassword.Text = ""; // Clears the Password textbox 

            txtConfirmPassword.Text = ""; // Clears the Confirm Password textbox 
        }

        // Exit Register button
        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the application
        }

        // Back Button
        private void iconBtnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login(); //Opens a form called Login
            this.Hide(); // Hides the previous form
            login.ShowDialog(); // Opens the form
            this.Close(); // Closes the form
        }

        private void btnExitRegister_MouseEnter(object sender, EventArgs e)
        {
            toolTipRegisterForm.Show("Exit Application", btnExitRegister); //If the user hovers over the exit button then a message will display
        }

        private void btnExitRegister_MouseLeave(object sender, EventArgs e)
        {
            toolTipRegisterForm.Hide(btnExitRegister); //if the user stops hovering over the exit button then the message will disappear
        }

        private void iconBtnBack_MouseEnter(object sender, EventArgs e)
        {
            toolTipRegisterForm.Show("Go back to log in page", iconBtnBack); //If the user hovers over the back button then a message will display
        }

        private void iconBtnBack_MouseLeave(object sender, EventArgs e)
        {
            toolTipRegisterForm.Hide(iconBtnBack); //If the user stops hovering over the back button then the message will disappear
        }

        private void iconBtnRegister_MouseEnter(object sender, EventArgs e)
        {
            toolTipRegisterForm.Show("Finish registration", iconBtnRegister); //If the user hovers over the finish registration button then a message will display
        }

        private void iconBtnRegister_MouseLeave(object sender, EventArgs e)
        {
            toolTipRegisterForm.Hide(iconBtnRegister); //If the user stops hovering over the finish registration button then the message will disappear
        }
    }
}
