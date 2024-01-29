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
        private int y = 5;
        private int x = 5;

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
                Panel panel = new Panel();
                Label title = new Label();
                Label description = new Label();
                Button termin = new Button();

                panel.Location = new Point(x, y);
                panel.Size = new Size(200, 200);
                panel.BackColor = Color.Gray;

                title.Location = new Point(10 + x, 10);
                title.Size = new Size(180, 25);
                title.Font = new Font("Microsoft Sans Serif", 15);
                title.BackColor = Color.Gray;
                title.Text = car.getBrand();

                description.Location = new Point(10 + x, 40);
                description.Size = new Size(120, 100);
                description.Font = new Font("Microsoft Sans Serif", 10);
                description.BackColor = Color.Gray;
                description.Text = "Car model: " + car.getModel() + " Car whp: " + car.getWhp();

                termin.Location = new Point(x + 65, y + 170);
                termin.Size = new Size(125, 25);
                termin.BackColor = Color.LightGray;
                termin.Text = "Terminvereinbarung";

                Controls.Add(panel2);

                panel2.Controls.Add(panel);
                panel2.Controls.Add(title);
                panel2.Controls.Add(termin);
                panel2.Controls.Add(description);
                title.BringToFront();
                termin.BringToFront();
                description.BringToFront();

                x += 210;
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
