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
    public partial class Termine : Form
    {
        private Car car;

        public Termine(Car car)
        {
            InitializeComponent();
            this.car = car;

            label1.Text = car.getBrand();
            label2.Text = car.getDescription();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointments appointment = new Appointments(monthCalendar1.SelectionStart, "TestStraße", 1, car);
            dbConn.createAppointment(appointment);
            MessageBox.Show("Der Terminvorschlag wurde versendet. Sie werden auf die Home-Seite geleitet.");
            Home home = new Home();
            home.Show();
            Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }
    }
}
