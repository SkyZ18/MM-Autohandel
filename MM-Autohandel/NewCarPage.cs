﻿using MM_Autohandel.db;
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


        private void NewCarPage_Load(object sender, EventArgs e)
        {
            visibleDropdown = false;
            renderCars();
            
        }


        private void linkUsedCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsedCarPage usedCarPage = new UsedCarPage();
            usedCarPage.Show();
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                Exceptions.invalidCharacter();
            } else
            {
                if (checkIn())
                {
                    string[] inputs = { textBox1.Text.ToUpper(), textBox2.Text.ToUpper(), textBox3.Text };
                    Controls.Add(panel2);
                    panel2.Controls.Clear();

                    for (int i = 0; i < inputs.Length; i++)
                    {
                        if (inputs[i] == null)
                        {
                            inputs[i] = "";
                        }

                        Console.WriteLine(inputs[i]);
                    }

                    List<Car> cars = dbConn.filterCars(inputs, "newCars");
                    loadItemsWithContext(cars);
                }
                else
                {
                    Exceptions.invalidFilter();

                }
            }
        }

        private void loadItemsWithContext(List<Car> cars)
        {
            int y = 5;
            int x = 5;

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
                termin.Name = "terminBtn";

                termin.Click += (sender, e) =>
                {
                    openAppointment(car);
                };

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

        private void openAppointment(Car car)
        {
            Termine appointment = new Termine(car);
            appointment.Show();
            Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void linkNewCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Add(panel2);
            panel2.Controls.Clear();
            renderCars();
        }

        private void renderCars()
        {
            List<Car> cars = dbConn.getCars("newCars");
            loadItemsWithContext(cars);
        }

        private bool checkIn()
        {
            if (textBox3.Text == "")
            {
                return true;
            }
            else if (int.TryParse(textBox3.Text, out _))
            {
                return true;
            }
            return false;
        }
    }
}
