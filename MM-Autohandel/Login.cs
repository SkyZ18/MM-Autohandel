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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            dbConn.createConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dbConn.loginService(textBox1.Text, textBox2.Text))
            {
                Home home = new Home();
                home.Show();
            } else
            {
                MessageBox.Show("Wrong information! Try again");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
