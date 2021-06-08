using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace WinFormsApp3
{
    public partial class LoginForm : Form
    {

        public static string Username { get; set; } 
        public LoginForm()
        {
            InitializeComponent();
            
            PasswordText.PasswordChar = '\u25CF';
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "DloYF0U5Z2AsSZWD8J23D4vgIqt3f6KvhZfvX1oj",
            BasePath = "https://my-car-service-59f5f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was problem in the internet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var result1 = client.Get("Username/" + UserID.Text);
                
                Customer User = result1.ResultAs<Customer>();
                if (UserID.Text == User.Username && PasswordText.Text == User.Password)
                {
                    Username = User.Username;
                    BookingForm booking = new BookingForm();
                    MessageBox.Show("Anda telah berhasil login");
                    Close();
                    booking.ShowDialog();
                

                    

                }
                else if (UserID.Text == User.Username)
                {
                    MessageBox.Show("Password anda salah");
                }
                else
                {
                    MessageBox.Show("Anda belum mendaftarkan diri");
                }
                Username = User.Username;





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regristration regris = new Regristration();
            Hide();
            regris.ShowDialog();
            Close();
        }
    }
}
