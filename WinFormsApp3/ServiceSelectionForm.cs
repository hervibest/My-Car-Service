using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ServiceSelectionForm : Form
    {
        public ServiceSelectionForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox4.Text == "Racing")
            {
                label1.Text = "Jenis mobil anda adalah Racing";
                Type1Car Car1 = new Type1Car("Racing", 1000, 2017);
                if (comboBox3.Text == "Quick Service")
                {
                    double EstimatedPrice = Car1.QuickService(1000, 2017);
                    label2.Text = "Anda memilih Quick Service";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show("Perkiraan Harga adalah :"+ EstimatedPrice.ToString());


                }
                else if (comboBox3.Text == "Full Service")
                {
                    double EstimatedPrice = Car1.FullService(1000, 2017);
                    MessageBox.Show(EstimatedPrice.ToString());
                    label2.Text = "Anda memilih Full Service";
                    label5.Text = EstimatedPrice.ToString();

                }
                else if (comboBox3.Text == "Tune Up")
                {
                    double EstimatedPrice = Car1.TuneUp(1000, 2017);
                    label2.Text = "Anda memilih Tune Up";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());

                }


                else if (comboBox3.Text == "Modify Car")
                {
                    double EstimatedPrice = Car1.ModifyCar(1000, 2017);
                    label2.Text = "Anda memilih Modify Car";
                    label5.Text = EstimatedPrice.ToString();
                    
                    MessageBox.Show(EstimatedPrice.ToString());
                }
                else
                {
                    MessageBox.Show("Anda belum memilih harga");

                }
            }
            if(comboBox4.Text == "Hatchback")
            {
                label1.Text = "Jenis mobil anda adalah Hatchback";
                MessageBox.Show("Anda telah memilih jenis Hatchback");
                Type2Car Car2 = new Type2Car("Hatchback", 1000, 2017);
                if (comboBox3.Text == "Quick Service")
                {
                    double EstimatedPrice = Car2.QuickService(1000, 2017);
                    label2.Text = "Anda memilih Quickl Service";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());


                }
                else if (comboBox3.Text == "Full Service")
                {
                    double EstimatedPrice = Car2.FullService(1000, 2017);
                    label2.Text = "Anda memilih Full Service";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());


                }
                else if (comboBox3.Text == "Tune Up")
                {
                    double EstimatedPrice = Car2.TuneUp(1000, 2017);
                    label2.Text = "Anda memilih Tune Up";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());

                }


                else if (comboBox3.Text == "Modify Car")
                {

                    double EstimatedPrice = Car2.ModifyCar(1000, 2017);
                    label2.Text = "Anda memilih Modify Car";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());
                }
                else
                {
                    MessageBox.Show("Anda belum memilih herga");

                }

            }
            if (comboBox4.Text == "SUV")
            {
                label1.Text = "Jenis mobil anda adalah SUV";
                MessageBox.Show("Anda telah memilih jenis SUV");
                Type3Car Car3 = new Type3Car("SUV", 1000, 2017);
                if (comboBox3.Text == "Quick Service")
                {
                    double EstimatedPrice = Car3.QuickService(1000, 2017);
                    label2.Text = "Anda memilih Quickl Service";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());


                }
                else if (comboBox3.Text == "Full Service")
                {
                    double EstimatedPrice = Car3.FullService(1000, 2017);
                    label2.Text = "Anda memilih Full Service";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());


                }
                else if (comboBox3.Text == "Tune Up")
                {
                    double EstimatedPrice = Car3.TuneUp(1000, 2017);
                    label2.Text = "Anda memilih Tune Up";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());

                }


                else if (comboBox3.Text == "Modify Car")
                {

                    double EstimatedPrice = Car3.ModifyCar(1000, 2017);
                    label2.Text = "Anda memilih Modify Car";
                    label5.Text = EstimatedPrice.ToString();
                    MessageBox.Show(EstimatedPrice.ToString());
                }
                else
                {
                    MessageBox.Show("Anda belum memilih herga");

                }

            }
            

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
