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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox1.Text.Contains("@"))
            {
                if (textBox2.Text == textBox3.Text)
                {
                    dbConn.createNewUser(textBox1.Text, textBox2.Text);
                    Home home = new Home();
                    home.Show();
                    Close();
                }
                else
                {
                    Exceptions.passwordDontMatch();
                }
            } else
            {
                Exceptions.invalidCharacter();
            }
        }
    }
}
