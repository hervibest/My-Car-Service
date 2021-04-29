using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(fcon);
            if (client == null)
            {

                lblConnectionStatus.Text = "Tidak tersambung dengan Internet";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig
        {
            AuthSecret = "DloYF0U5Z2AsSZWD8J23D4vgIqt3f6KvhZfvX1oj",
            BasePath = "https://my-car-service-59f5f-default-rtdb.firebaseio.com/"



        };
        IFirebaseClient client;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regristration regris = new Regristration();
            Hide();
            regris.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Hide();
            login.ShowDialog();
            Close();
        }
    }
}
