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
    public partial class Booking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I99UMVE\SQLEXPRESS;Initial Catalog=BookingApplication;Integrated Security=True"); // Estabilishes a connection between the program and SQL server
        SqlCommand cmd;

        string[] movieDescription = { "A lovable monster named James P. Sullivan (better known as Sulley) and his wisecracking best friend, short, green cyclops monster Mike Wazowski, discover what happens when the real world interacts with theirs in the form of a 2-year-old baby girl dubbed Boo who accidentally sneaks into the monster world with Sulley one night. And now it's up to Sulley and Mike to send Boo back in her door before anybody finds out, especially two evil villains such as Sulley's main rival as a scarer, chameleon-like Randall (a monster that Boo is very afraid of).",
        "A covert team of immortal mercenaries are suddenly exposed and must now fight to keep their identity a secret just as an unexpected new member is discovered.",
        "In the sequel to 2018's THE KISSING BOOTH, high school senior Elle juggles a long-distance relationship with her dreamy boyfriend Noah, college applications, and a new friendship with a handsome classmate that could change everything.",
        "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
        "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
        "Tyler Rake, a fearless black market mercenary, embarks on the most deadly extraction of his career when he's enlisted to rescue the kidnapped son of an imprisoned international crime lord.",
        "In Jumanji: The Next Level, the gang is back but the game has changed. As they return to rescue one of their own, the players will have to brave parts unknown from arid deserts to snowy mountains, to escape the world's most dangerous game.",
        "An augmented human and Sarah Connor must stop an advanced liquid Terminator from hunting down a young girl, whose fate is critical to the human race."};//Makes a string array containing all the movie descriptions

        //Global variables

        public static int ID = 0; // Create variable 'ID' and store it as integer

        int currentIndex = 0;
        int under4, child, teen, adult, senior;
        double total, feeTotal;
        //double Fee3 = 0.03, Fee5 = 0.05;

        public static int Under4Tickets, ChildTickets, TeenTickets, AdultTickets, SeniorTickets;

        public Booking()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//Starts the form in the center of the screen
            lblMovieDescription.Text = movieDescription[0].ToString();//Displays the description of the movie that is selected from the drop down list
            comboBoxMovieNames.SelectedIndex = 0;//Sets the drops downs to be set on the first value
            comboBoxMovieTimes.SelectedIndex = 0;//Sets the drop down to the first value
            comboBoxUnder4.SelectedIndex = 0;//Sets the drop down to the first value
            comboBoxChild.SelectedIndex = 0;//Sets the drop down to the first value
            comboBoxTeen.SelectedIndex = 0;//Sets the drop down to the first value
            comboBoxSenior.SelectedIndex = 0;//Sets the drop down to the first value
            comboBoxAdult.SelectedIndex = 0;//Sets the drop down to the first value
            rdoBtnCC.Checked = true;
            
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            this.tabControlBooking.SelectedIndex = 0;
        }

        private void btnExitBooking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconbtnLogOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        public void Logout()
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

        private void comboBoxMovieNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMovie = comboBoxMovieNames.SelectedIndex;//Reads the selected movie

            if (selectedMovie == 0)//If the movie is 0 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.MonstersInc;//If the movie is 0 it will display the monster inc image
            }
            else if (selectedMovie == 1)//If the movie is 1 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.TheOldGuard;//If the movie is 1 it will display the old guard image
            }
            else if (selectedMovie == 2)//If the movie is 2 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.TheKissingBooth;//If the movie is 2 it will display the Poohs kissing booth image
            }
            else if (selectedMovie == 3)//If the movie is 3 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.Joker;//If the movie is 3 it will display the Joker image
            }
            else if (selectedMovie == 4)//If the movie is 4 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.AvengerEndGame;//If the movie is 3 it will display the Avengers Endgame image
            }
            else if (selectedMovie == 5)//If the movie is 5 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.Extraction;//If the movie is 3 it will display the Extraction image
            }
            else if (selectedMovie == 6)//If the movie is 6 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.Jumanji;//If the movie is 3 it will display the Jumanji image
            }
            else if (selectedMovie == 7)//If the movie is 7 then it will run the code inside the brackets
            {
                picBoxMovieImage.Image = Properties.Resources.Terminator;//If the movie is 3 it will display the Terminator image
            }

            lblMovieDescription.Text = movieDescription[comboBoxMovieNames.SelectedIndex].ToString();//Displays the movie description for the movie that was selected in the drop down list
        }

        private void IconbtnExitBooking_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Exit Application", IconbtnExitBooking);//If the user hovers over the exit button then a message will display
        }

        private void IconbtnExitBooking_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(IconbtnExitBooking);//if the user stops hovering over the exit button then the message will disappear
        }

        private void IconbtnLogOut_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Log out", IconbtnLogOut);//If the user hovers over the exit button then a message will display
        }

        private void IconbtnLogOut_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(IconbtnLogOut);//if the user stops hovering over the log out button then the message will disappear
        }

        private void tabControlBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlBooking.SelectedIndex = currentIndex;
            return;
        }

        private void iconBtnProceed_Click(object sender, EventArgs e)
        {
            currentIndex += 1;

            if (currentIndex >= tabControlBooking.TabPages.Count)
            {
                currentIndex = 0;
            }

            foreach (TabPage pg in tabControlBooking.TabPages)
            {
                pg.Enabled = false;
            }

            tabControlBooking.TabPages[currentIndex].Enabled = true;
            tabControlBooking.SelectedIndex = currentIndex;

            int selectedMovie = comboBoxMovieNames.SelectedIndex;//Reads the selected movie

            if (selectedMovie == 0)//If the movie is 0 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.MonstersInc;//If the movie is 0 it will display the monster inc image
            }
            else if (selectedMovie == 1)//If the movie is 1 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.TheOldGuard;//If the movie is 1 it will display the old guard image
            }
            else if (selectedMovie == 2)//If the movie is 2 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.TheKissingBooth;//If the movie is 2 it will display the kissing booth image
            }
            else if (selectedMovie == 3)//If the movie is 3 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.Joker;//If the movie is 3 it will display the Joker image
            }
            else if (selectedMovie == 4)//If the movie is 4 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.AvengerEndGame;//If the movie is 3 it will display the Avengers Endgame image
            }
            else if (selectedMovie == 5)//If the movie is 5 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.Extraction;//If the movie is 3 it will display the Extraction image
            }
            else if (selectedMovie == 6)//If the movie is 6 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.Jumanji;//If the movie is 3 it will display the Jumanji image
            }
            else if (selectedMovie == 7)//If the movie is 7 then it will run the code inside the brackets
            {
                picBoxTickets.Image = Properties.Resources.Terminator;//If the movie is 3 it will display the Terminator image
            }
        }

        private void comboBoxUnder4_SelectedIndexChanged(object sender, EventArgs e)
        {
            under4 = Convert.ToInt32(comboBoxUnder4.SelectedItem) * 1;
            price();
        }

        private void comboBoxChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            child = Convert.ToInt32(comboBoxChild.SelectedItem) * 3;
            price();
        }

        private void comboBoxTeen_SelectedIndexChanged(object sender, EventArgs e)
        {
            teen = Convert.ToInt32(comboBoxTeen.SelectedItem) * 4;
            price();
        }

        private void comboBoxSenior_SelectedIndexChanged(object sender, EventArgs e)
        {
            senior = Convert.ToInt32(comboBoxSenior.SelectedItem) * 4;
            price();
        }

        private void comboBoxAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            adult = Convert.ToInt32(comboBoxAdult.SelectedItem) * 6;
            price();
        }

        private void iconBtnRefresh_Click(object sender, EventArgs e)
        {
            comboBoxUnder4.SelectedIndex = 0;
            comboBoxChild.SelectedIndex = 0;
            comboBoxTeen.SelectedIndex = 0;
            comboBoxSenior.SelectedIndex = 0;
            comboBoxAdult.SelectedIndex = 0;
        }

        private void iconBtnTicketsBack_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;

            if (currentIndex >= tabControlBooking.TabPages.Count)
            {
                currentIndex = 0;
            }

            foreach (TabPage pg in tabControlBooking.TabPages)
            {
                pg.Enabled = false;
            }

            tabControlBooking.TabPages[currentIndex].Enabled = true;
            tabControlBooking.SelectedIndex = currentIndex;
        }

        private void iconBtnConfirmationBack_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;

            if (currentIndex >= tabControlBooking.TabPages.Count)
            {
                currentIndex = 0;
            }

            foreach (TabPage pg in tabControlBooking.TabPages)
            {
                pg.Enabled = false;
            }

            tabControlBooking.TabPages[currentIndex].Enabled = true;
            tabControlBooking.SelectedIndex = currentIndex;
        }

        private void iconBtnReset_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Reset all options to default", iconBtnReset);//If the user hovers over the reset button then a message will display
        }

        private void iconBtnReset_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnReset);//if the user stops hovering over the reset button then the message will disappear
        }

        private void iconBtnProceed_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Proceed to next stage", iconBtnProceed);//If the user hovers over the reset button then a message will display
        }

        private void iconBtnProceed_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnProceed);//if the user stops hovering over the proceed button then the message will disappear
        }

        private void iconBtnTicketsBack_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Return to previous stage", iconBtnTicketsBack);//If the user hovers over the back button then a message will display
        }

        private void iconBtnTicketsBack_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnTicketsBack);//if the user stops hovering over the back button then the message will disappear
        }

        private void iconBtnRefresh_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Reset all options to default", iconBtnRefresh);//If the user hovers over the back button then a message will display
        }

        private void iconBtnRefresh_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnRefresh);//if the user stops hovering over the refresh button then the message will disappear
        }

        private void iconBtnTicketsProceed_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Proceed to next stage", iconBtnTicketsProceed);//If the user hovers over the Proceed button then a message will display
        }

        private void iconBtnTicketsProceed_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnTicketsProceed);//if the user stops hovering over the Proceed button then the message will disappear
        }

        private void iconBtnConfirmationBack_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Return to previous stage", iconBtnConfirmationBack);//If the user hovers over the back button then a message will display
        }

        private void iconBtnConfirmationBack_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnConfirmationBack);//if the user stops hovering over the back button then the message will disappear
        }

        private void iconBtnConfirmationProceed_MouseEnter(object sender, EventArgs e)
        {
            toolTipBookingMovie.Show("Proceed to next stage", iconBtnConfirmationProceed);//If the user hovers over the Proceed button then a message will display
        }

        private void rdoBtnCC_CheckedChanged(object sender, EventArgs e)
        {
            lbl3.Hide();
            lbl5.Show();
            lblPaymentName.Show();
            lblPPEmail.Show();
            lblCardNumber.Show();
            lblExpiryDate.Show();
            lblCVV.Show();
            lblForwardSlash.Show();
            txtBoxExpiryDateYY.Show();
            txtBoxPaymentName.Show();
            txtBoxPPEmail.Show();
            txtBoxCardNumber.Show();
            txtBoxExpiryDateMM.Show();
            txtBoxCVV.Show();
            lblPPpassword.Hide();
            txtBoxPPpassword.Hide();
            feeTotal = (total * 0.05);
            lblFinalPriceDisplay.Text = "£" + (total + feeTotal).ToString("F2");
        }

        private void rdoBtnPP_CheckedChanged(object sender, EventArgs e)
        {
            lbl5.Hide();
            lbl3.Show();
            lblPaymentName.Show();
            lblPPEmail.Show();
            lblPPpassword.Show();
            txtBoxPPEmail.Show();
            txtBoxPPEmail.Show();
            txtBoxPPpassword.Show();
            lblCardNumber.Hide();
            lblExpiryDate.Hide();
            lblCVV.Hide();
            lblForwardSlash.Hide();
            txtBoxCardNumber.Hide();
            txtBoxExpiryDateMM.Hide();
            txtBoxExpiryDateYY.Hide();
            txtBoxCVV.Hide();
            feeTotal = (total * 0.03);
            lblFinalPriceDisplay.Text = "£" + (total + feeTotal).ToString("F2");
        }

        private void btnPaymentConfirm_Click(object sender, EventArgs e)
        {
            if (rdoBtnCC.Checked)
            {
                if (string.IsNullOrEmpty(txtBoxPaymentName.Text.Trim()) || string.IsNullOrEmpty(txtBoxPPEmail.Text.Trim()) || string.IsNullOrEmpty(txtBoxCardNumber.Text.Trim()) || string.IsNullOrEmpty(txtBoxExpiryDateMM.Text.Trim()) || string.IsNullOrEmpty(txtBoxCVV.Text.Trim()))
                {
                    const string RequiredFieldsError = "Fill in all the required fields";
                    const string caption = "Required Fields";

                    var result = MessageBox.Show(RequiredFieldsError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtBoxCardNumber.Text.Length == 12)
                    {
                        if(txtBoxExpiryDateMM.Text.Length == 2 && txtBoxExpiryDateYY.Text.Length == 2)
                        {
                            string cvv = "^[0-9]+$";
                            if (txtBoxCVV.Text.Length == 3 && Regex.IsMatch(txtBoxCVV.Text, cvv))
                            {
                                string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                                if (Regex.IsMatch(txtBoxPPEmail.Text.Trim(), EmailPattern))
                                {
                                    const string Finished = "Ready to Pay?";
                                    const string caption = "Payment";
                                    DialogResult result = MessageBox.Show(Finished, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (result == DialogResult.Yes)
                                    {
                                        con.Open(); // Opens the connection
                                        cmd = new SqlCommand("insert into dbo.Bookings(Name, BookingEmail, Movie, MovieTime, TicketPrice, PaymentType, Email, Under4Tickets, ChildTickets, TeenTickets, AdultTickets, SeniorTickets) " +
                                            "values(@Name, @BookingEmail, @Movie, @MovieTime, @TicketPrice, @PaymentType, @Email, @Under4Tickets, @ChildTickets, @TeenTickets, @AdultTickets, @SeniorTickets)", con);
                                        cmd.Parameters.AddWithValue("@BookingID", ID); // Stores the ID collected from the command to the @ID variable
                                        cmd.Parameters.AddWithValue("@Name", txtBoxPaymentName.Text);
                                        cmd.Parameters.AddWithValue("@BookingEmail", txtBoxPPEmail.Text);
                                        cmd.Parameters.AddWithValue("@Movie", comboBoxMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                                        cmd.Parameters.AddWithValue("@MovieTime", lblMovieTime.Text);
                                        cmd.Parameters.AddWithValue("@TicketPrice", lblFinalPriceDisplay.Text);
                                        cmd.Parameters.AddWithValue("@PaymentType", rdoBtnCC.Text);
                                        cmd.Parameters.AddWithValue("@Email", Login.Email);
                                        cmd.Parameters.AddWithValue("@Under4Tickets", comboBoxUnder4.SelectedItem);
                                        cmd.Parameters.AddWithValue("@ChildTickets", comboBoxChild.SelectedItem);
                                        cmd.Parameters.AddWithValue("@TeenTickets", comboBoxTeen.SelectedItem);
                                        cmd.Parameters.AddWithValue("@AdultTickets", comboBoxAdult.SelectedItem);
                                        cmd.Parameters.AddWithValue("@SeniorTickets", comboBoxSenior.SelectedItem);

                                        cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)

                                        const string Exit = "Payment successful!, Press Ok to exit the application";
                                        const string Heading = "Payment";

                                        DialogResult result1 = MessageBox.Show(Exit, Heading, MessageBoxButtons.OK, MessageBoxIcon.Question);
                                        if (result1 == DialogResult.OK)
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
                                    const string EmailFormatError = "Email is not in the correct format";
                                    const string caption = "Incorrect Email";

                                    var result = MessageBox.Show(EmailFormatError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                const string cardCVVLength = "CVV must consist of 3 numbers";
                                const string caption = "Incorrect Length";

                                var result = MessageBox.Show(cardCVVLength, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            const string cardExpirtyDateLength = "Expiry Date must be in the correct format MM/YY";
                            const string caption = "Incorrect Length";

                            var result = MessageBox.Show(cardExpirtyDateLength, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        const string cardNumberLength = "Card Number must be 12 digits";
                        const string caption = "Incorrect Length";

                        var result = MessageBox.Show(cardNumberLength, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtBoxPaymentName.Text.Trim()) || string.IsNullOrEmpty(txtBoxPPEmail.Text.Trim()) || string.IsNullOrEmpty(txtBoxPPpassword.Text.Trim()))
                {
                    const string RequiredFieldsError = "Fill in all the required fields";
                    const string caption = "Required Fields";

                    var result = MessageBox.Show(RequiredFieldsError, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                    if (Regex.IsMatch(txtBoxPPEmail.Text.Trim(), EmailPattern))
                    {
                        const string Finished = "Ready to Pay?";
                        const string caption = "Payment";

                        DialogResult result = MessageBox.Show(Finished, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            con.Open(); // Opens the connection
                            cmd = new SqlCommand("insert into dbo.Bookings(Name, BookingEmail, Movie, MovieTime, TicketPrice, PaymentType, Email, Under4Tickets, ChildTickets, TeenTickets, AdultTickets, SeniorTickets) " +
                                "values(@Name, @BookingEmail, @Movie, @MovieTime, @TicketPrice, @PaymentType, @Email, @Under4Tickets, @ChildTickets, @TeenTickets, @AdultTickets, @SeniorTickets)", con);
                            cmd.Parameters.AddWithValue("@BookingID", ID); // Stores the ID collected from the command to the @ID variable
                            cmd.Parameters.AddWithValue("@Name", txtBoxPaymentName.Text);
                            cmd.Parameters.AddWithValue("@BookingEmail", txtBoxPPEmail.Text);
                            cmd.Parameters.AddWithValue("@Movie", comboBoxMovieNames.SelectedItem); // Stores the Password collected from the command to the @Password variable
                            cmd.Parameters.AddWithValue("@MovieTime", lblMovieTime.Text);
                            cmd.Parameters.AddWithValue("@TicketPrice", lblFinalPriceDisplay.Text);
                            cmd.Parameters.AddWithValue("@PaymentType", rdoBtnPP.Text);
                            cmd.Parameters.AddWithValue("@Email", Login.Email);
                            cmd.Parameters.AddWithValue("@Under4Tickets", comboBoxUnder4.SelectedItem);
                            cmd.Parameters.AddWithValue("@ChildTickets", comboBoxChild.SelectedItem);
                            cmd.Parameters.AddWithValue("@TeenTickets", comboBoxTeen.SelectedItem);
                            cmd.Parameters.AddWithValue("@AdultTickets", comboBoxAdult.SelectedItem);
                            cmd.Parameters.AddWithValue("@SeniorTickets", comboBoxSenior.SelectedItem);

                            cmd.ExecuteNonQuery(); // Executes the query (Non query is for UPDATE, INSERT AND DELETE statements)

                            const string Exit = "Payment successful!, Press Ok to exit the application";
                            const string Heading = "Payment";

                            DialogResult result1 = MessageBox.Show(Exit, Heading, MessageBoxButtons.OK, MessageBoxIcon.Question);
                            if (result1 == DialogResult.OK)
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
                        const string EmailFormat = "Email is not in the correct format";
                        const string caption = "Incorrect Format";

                        var result = MessageBox.Show(EmailFormat, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void icnbtnHome_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();//opens a form called Menu
            this.Hide();//hides the previous form
            menu.ShowDialog();//opens the form
            this.Close();//closes the form
        }

        private void iconBtnConfirmationProceed_MouseLeave(object sender, EventArgs e)
        {
            toolTipBookingMovie.Hide(iconBtnConfirmationProceed);//if the user stops hovering over the Proceed button then the message will disappear
        }

        private void iconBtnTicketsProceed_Click(object sender, EventArgs e)
        {
            if (comboBoxUnder4.SelectedIndex != 0 || comboBoxChild.SelectedIndex != 0 || comboBoxTeen.SelectedIndex != 0 || comboBoxAdult.SelectedIndex != 0 || comboBoxSenior.SelectedIndex != 0)
            {
                currentIndex += 1;

                if (currentIndex >= tabControlBooking.TabPages.Count)
                {
                    currentIndex = 0;
                }

                foreach (TabPage pg in tabControlBooking.TabPages)
                {
                    pg.Enabled = false;
                }

                tabControlBooking.TabPages[currentIndex].Enabled = true;
                tabControlBooking.SelectedIndex = currentIndex;

                int selectedMovie = comboBoxMovieNames.SelectedIndex;//Reads the selected movie

                if (selectedMovie == 0)//If the movie is 0 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.MonstersInc;//If the movie is 0 it will display the monster inc image
                }
                else if (selectedMovie == 1)//If the movie is 1 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.TheOldGuard;//If the movie is 1 it will display the old guard image
                }
                else if (selectedMovie == 2)//If the movie is 2 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.TheKissingBooth;//If the movie is 2 it will display the kissing booth image
                }
                else if (selectedMovie == 3)//If the movie is 3 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.Joker;//If the movie is 3 it will display the Joker image
                }
                else if (selectedMovie == 4)//If the movie is 4 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.AvengerEndGame;//If the movie is 3 it will display the Avengers Endgame image
                }
                else if (selectedMovie == 5)//If the movie is 5 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.Extraction;//If the movie is 3 it will display the Extraction image
                }
                else if (selectedMovie == 6)//If the movie is 6 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.Jumanji;//If the movie is 3 it will display the Jumanji image
                }
                else if (selectedMovie == 7)//If the movie is 7 then it will run the code inside the brackets
                {
                    picBoxChosenMovieConfirmation.Image = Properties.Resources.Terminator;//If the movie is 3 it will display the Terminator image
                }

                lblUnder4sQuantity.Text = comboBoxUnder4.SelectedItem.ToString();
                lblChildQuantity.Text = comboBoxChild.SelectedItem.ToString();
                lblTeenQuantity.Text = comboBoxTeen.SelectedItem.ToString();
                lblSeniorQuantity.Text = comboBoxSenior.SelectedItem.ToString();
                lblAdultQuantity.Text = comboBoxAdult.SelectedItem.ToString();

                lblTotalPrice.Text = lblFinalPrice.Text;

                lblMovieTime.Text = comboBoxMovieTimes.SelectedItem.ToString();
            }
            else
            {
                const string NoTickets = "No tickets selected, please select at least 1 ticket to continue";
                const string caption = "No ticket";

                var result = MessageBox.Show(NoTickets, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnConfirmationProceed_Click(object sender, EventArgs e)
        {
            currentIndex += 1;

            if (currentIndex >= tabControlBooking.TabPages.Count)
            {
                currentIndex = 0;
            }

            foreach (TabPage pg in tabControlBooking.TabPages)
            {
                pg.Enabled = false;
            }

            tabControlBooking.TabPages[currentIndex].Enabled = true;
            tabControlBooking.SelectedIndex = currentIndex;

            feeTotal = (total * 0.05);
            lblFinalPriceDisplay.Text = "£" + (total + feeTotal).ToString("F2");
        }

        private void iconBtnReset_Click(object sender, EventArgs e)
        {
            lblMovieDescription.Text = movieDescription[0].ToString();//Displays the description of the movie that is selected from the drop down list
            comboBoxMovieNames.SelectedIndex = 0;//Sets the drops downs to be set on the first value
            comboBoxMovieTimes.SelectedIndex = 0;//Sets the drop down to the first value
        }

        private void price()
        {
            total = Convert.ToInt32((under4 + child + teen + adult + senior));

            lblFinalPrice.Text = "£" + total.ToString();
        }
    }
}
