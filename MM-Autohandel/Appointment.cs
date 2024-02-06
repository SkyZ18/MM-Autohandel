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
    public partial class Appointment : Form
    {
        public Appointment()
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
    }
}
