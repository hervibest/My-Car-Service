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
    public partial class BookingForm : Form
    {
        
        public BookingForm(string name, string alamat, string tipecar)
        {
           
            InitializeComponent();
           
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "DloYF0U5Z2AsSZWD8J23D4vgIqt3f6KvhZfvX1oj",
            BasePath = "https://my-car-service-59f5f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void BookingForm_Load(object sender, EventArgs e)
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
            dateTime time = new dateTime()
            {
                Time = dateTimePicker1.Value.ToString()


            };
            var setter = client.Set($"Username/{LoginForm.Username}/"+ "Waktu pemesanan",time);
            ServiceSelectionForm servisform = new ServiceSelectionForm();
            Hide();
            MessageBox.Show("Anda berhasil memesan waktu servis");
            Close();
            servisform.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show("Anda telah memilih tanggal sekian " + dt.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Anda telah memilih garasi " + comboBox1.Text);
        }
    }
}
