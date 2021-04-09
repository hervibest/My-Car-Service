using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class BookingForm : Form
    {
        
        public BookingForm(string name, string alamat, string tipecar)
        {
           
            InitializeComponent();
            Nama.Text =  "Nama anda :"+ name + "\n Alamat anda :" + alamat + "\n Jenis Mobil anda : " +tipecar+"\n";
            //Booking(string _date, string _time, String _garageselection)
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

            
            

      


            MessageBox.Show("Anda telah memilih tanggal sekian "+ dt.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceSelectionForm ServiceForm = new ServiceSelectionForm();
            Hide();
            ServiceForm.ShowDialog();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Anda telah memilih garasi " + comboBox1.Text);
        }
    }
}
