using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Regristration : Form
    {
        public Regristration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Alamat = txtAlamat.Text;
            string TipeCar = txtTipeCar.Text;
            Customer first = new Customer(name, Alamat, TipeCar);
            
            BookingForm booking = new BookingForm(name, Alamat, TipeCar);
          
            
            booking.ShowDialog();

        }
    }
}
