using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApplication
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Starts the form in the center of the screen
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();//Opens a form called login
            this.Hide();//Hides the previous form
            booking.ShowDialog();//Shows the form
            this.Close();//closes the form
        }

        private void IconbtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();//Opens a form called login
            this.Hide();//Hides the previous form
            login.ShowDialog();//Shows the form
            this.Close();//closes the form
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconbtnLogOut_MouseEnter(object sender, EventArgs e)
        {
            toolTipMenu.Show("Log out", IconbtnLogOut);//If the user hovers over the log out button then a message will display
        }

        private void IconbtnLogOut_MouseLeave(object sender, EventArgs e)
        {
            toolTipMenu.Hide(IconbtnLogOut);//if the user stops hovering over the exit button then the message will disappear
        }

        private void btnExitMenu_MouseEnter(object sender, EventArgs e)
        {
            toolTipMenu.Show("Exit Application", btnExitMenu);//If the user hovers over the exit button then a message will display
        }

        private void btnExitMenu_MouseLeave(object sender, EventArgs e)
        {
            toolTipMenu.Hide(btnExitMenu);//if the user stops hovering over the exit button then the message will disappear
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookings viewBookings = new ViewBookings();//opens a form called Menu
            this.Hide();//hides the previous form
            viewBookings.ShowDialog();//opens the form
            this.Close();//closes the form
        }
    }
}
