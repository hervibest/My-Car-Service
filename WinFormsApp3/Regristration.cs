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

    public partial class Regristration : Form
    {
        public Regristration()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "DloYF0U5Z2AsSZWD8J23D4vgIqt3f6KvhZfvX1oj",
            BasePath = "https://my-car-service-59f5f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Alamat = txtAlamat.Text;
            string TipeCar = txtTipeCar.Text;
            Customer first = new Customer()
            {
                Name = txtName.Text,
                _alamat = txtAlamat.Text,
         
           TypeCar = txtTipeCar.Text,
            Username = UserID.Text,
                Password = PasswordBox.Text          

            };
           
            MessageBox.Show("Anda berhasil melakukan regristasi");
             
            
            BookingForm booking = new BookingForm(name, Alamat, TipeCar);
            Hide();
            var setter = client.Set("Username/" + UserID.Text, first);
            booking.ShowDialog();
            Close();

        }

        private void Regristration_Load(object sender, EventArgs e)
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
    }
}
