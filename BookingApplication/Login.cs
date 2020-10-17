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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Starts the form in the center of the screen
        }

        public static string Email = "";

        private void iconBtnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I99UMVE\SQLEXPRESS;Initial Catalog=BookingApplication;Integrated Security=True"); // Estabilishes a connection between the program and SQL server
            string query = "SELECT * FROM dbo.Accounts WHERE Email = '" + txtEmail.Text.Trim() + "'AND Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count == 1)
            {
                Email = txtEmail.Text;

                Menu menu = new Menu();//opens a form called Menu
                this.Hide();//hides the previous form
                menu.ShowDialog();//opens the form
                this.Close();//closes the form
            }
            else
            {
                const string NonExistedUser = "User does not exist";
                const string caption = "Log in error";

                var result = MessageBox.Show(NonExistedUser, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();//opens a form called Register
            this.Hide();//hides the previous form
            register.ShowDialog();//opens the form
            this.Close();//closes the form
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitLogin_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Exit Application", btnExitLogin);//If the user hovers over the exit button then a message will display
        }

        private void btnExitLogin_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(btnExitLogin);//if the user stops hovering over the exit button then the message will disappear
        }

        private void iconBtnSignIn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Sign in", iconBtnSignIn);
        }

        private void iconBtnSignIn_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(iconBtnSignIn);
        }

        private void linkLblSignUp_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Go to registration form", linkLblSignUp);
        }

        private void linkLblSignUp_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(linkLblSignUp);
        }
    }
}
