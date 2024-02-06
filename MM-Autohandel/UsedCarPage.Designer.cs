namespace MM_Autohandel
{
    partial class UsedCarPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.linkUsedCar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkNewCar = new System.Windows.Forms.LinkLabel();
            this.dropdownFilter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.dropdownFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.linkUsedCar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkNewCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 108);
            this.panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(534, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1372, 33);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 36);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // linkUsedCar
            // 
            this.linkUsedCar.AutoSize = true;
            this.linkUsedCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUsedCar.LinkColor = System.Drawing.Color.Black;
            this.linkUsedCar.Location = new System.Drawing.Point(425, 42);
            this.linkUsedCar.Name = "linkUsedCar";
            this.linkUsedCar.Size = new System.Drawing.Size(103, 25);
            this.linkUsedCar.TabIndex = 2;
            this.linkUsedCar.TabStop = true;
            this.linkUsedCar.Text = "Gebraucht";
            this.linkUsedCar.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkUsedCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUsedCar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autohandel";
            // 
            // linkNewCar
            // 
            this.linkNewCar.AutoSize = true;
            this.linkNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewCar.LinkColor = System.Drawing.Color.Black;
            this.linkNewCar.Location = new System.Drawing.Point(261, 42);
            this.linkNewCar.Name = "linkNewCar";
            this.linkNewCar.Size = new System.Drawing.Size(158, 25);
            this.linkNewCar.TabIndex = 1;
            this.linkNewCar.TabStop = true;
            this.linkNewCar.Text = "Neue Fahrzeuge";
            this.linkNewCar.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkNewCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewCar_LinkClicked);
            // 
            // dropdownFilter
            // 
            this.dropdownFilter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dropdownFilter.Controls.Add(this.button2);
            this.dropdownFilter.Controls.Add(this.textBox3);
            this.dropdownFilter.Controls.Add(this.label4);
            this.dropdownFilter.Controls.Add(this.textBox5);
            this.dropdownFilter.Controls.Add(this.label3);
            this.dropdownFilter.Controls.Add(this.textBox4);
            this.dropdownFilter.Controls.Add(this.label2);
            this.dropdownFilter.Location = new System.Drawing.Point(12, 157);
            this.dropdownFilter.Name = "dropdownFilter";
            this.dropdownFilter.Size = new System.Drawing.Size(241, 223);
            this.dropdownFilter.TabIndex = 8;
            this.dropdownFilter.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(266, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 637);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Use Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "PS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modell";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marke";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(14, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 22);
            this.textBox5.TabIndex = 12;
            // 
            // UsedCarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dropdownFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsedCarPage";
            this.Text = "UsedCarPage";
            this.Load += new System.EventHandler(this.UsedCarPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dropdownFilter.ResumeLayout(false);
            this.dropdownFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.LinkLabel linkUsedCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkNewCar;
        private System.Windows.Forms.Panel dropdownFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}