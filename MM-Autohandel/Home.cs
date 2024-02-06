using MM_Autohandel.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Autohandel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void linkNewCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewCarPage newCarPage = new NewCarPage();
            newCarPage.Show();
            Close();
        }

        private void linkUsedCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsedCarPage usedCarPage = new UsedCarPage();
            usedCarPage.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCarPage newCarPage = new NewCarPage();
            newCarPage.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsedCarPage usedCarPage = new UsedCarPage();
            usedCarPage.Show();
            Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
