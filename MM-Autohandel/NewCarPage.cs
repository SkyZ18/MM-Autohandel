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
    public partial class NewCarPage : Form
    {
        private bool visibleDropdown = false;

        public NewCarPage()
        {
            InitializeComponent();
            Car[] cars = dbConn.getCars();
            label3.Text = cars[0].getBrand();
            label4.Text = cars[0].getModel();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCarPage_Load(object sender, EventArgs e)
        {
            visibleDropdown = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
