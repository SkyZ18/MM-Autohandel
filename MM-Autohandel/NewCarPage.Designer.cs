namespace MM_Autohandel
{
    partial class NewCarPage
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.linkUsedCar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkNewCar = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.dropdownFilter = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.dropdownFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.linkUsedCar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkNewCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 108);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1372, 33);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 36);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dropdownFilter
            // 
            this.dropdownFilter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dropdownFilter.Controls.Add(this.button2);
            this.dropdownFilter.Controls.Add(this.label4);
            this.dropdownFilter.Controls.Add(this.label3);
            this.dropdownFilter.Controls.Add(this.textBox3);
            this.dropdownFilter.Controls.Add(this.label2);
            this.dropdownFilter.Controls.Add(this.textBox2);
            this.dropdownFilter.Controls.Add(this.textBox1);
            this.dropdownFilter.Location = new System.Drawing.Point(12, 161);
            this.dropdownFilter.Name = "dropdownFilter";
            this.dropdownFilter.Size = new System.Drawing.Size(241, 223);
            this.dropdownFilter.TabIndex = 4;
            this.dropdownFilter.Visible = false;
            this.dropdownFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.dropdownFilter_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PS";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modell";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marke";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(266, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 637);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Use Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewCarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dropdownFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "NewCarPage";
            this.Text = "NewCarPage";
            this.Load += new System.EventHandler(this.NewCarPage_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel dropdownFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}