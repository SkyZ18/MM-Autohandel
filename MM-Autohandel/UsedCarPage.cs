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
    public partial class UsedCarPage : Form
    {
        private bool visibleDropdown = false;
        private int y = 230;
        private int x = 230;
        private int top = 5;
        private int left = 5;

        public UsedCarPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkNewCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewCarPage newCarPage = new NewCarPage();
            newCarPage.Show();
            Close();
            dbConn.createConnection();
        }

        private void UsedCarPage_Load(object sender, EventArgs e)
        {
            visibleDropdown = false;
            List<Car> cars = dbConn.getCars("usedCars");
            foreach (Car car in cars)
            {
                Panel item = new Panel();
                item.Height = y;
                item.Width = x;
                item.BackColor = Color.Black;
                item.Left = left;
                item.Top = top;
                panel2.Controls.Add(item);
                left += 240;
                Console.WriteLine(car.getBrand());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (visibleDropdown)
            {
                dropdownFilter.Visible = false;
                visibleDropdown = false;
            }
            else
            {
                dropdownFilter.Visible = true;
                visibleDropdown = true;
            }
        }
    }
}
