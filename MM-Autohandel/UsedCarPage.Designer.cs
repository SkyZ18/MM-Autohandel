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
            this.logoutButton = new System.Windows.Forms.Button();
            this.linkUsedCar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkNewCar = new System.Windows.Forms.LinkLabel();
            this.dropdownFilter = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.dropdownFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1663, 135);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1544, 41);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 45);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // linkUsedCar
            // 
            this.linkUsedCar.AutoSize = true;
            this.linkUsedCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUsedCar.LinkColor = System.Drawing.Color.Black;
            this.linkUsedCar.Location = new System.Drawing.Point(478, 52);
            this.linkUsedCar.Name = "linkUsedCar";
            this.linkUsedCar.Size = new System.Drawing.Size(124, 29);
            this.linkUsedCar.TabIndex = 2;
            this.linkUsedCar.TabStop = true;
            this.linkUsedCar.Text = "Gebraucht";
            this.linkUsedCar.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autohandel";
            // 
            // linkNewCar
            // 
            this.linkNewCar.AutoSize = true;
            this.linkNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewCar.LinkColor = System.Drawing.Color.Black;
            this.linkNewCar.Location = new System.Drawing.Point(294, 52);
            this.linkNewCar.Name = "linkNewCar";
            this.linkNewCar.Size = new System.Drawing.Size(193, 29);
            this.linkNewCar.TabIndex = 1;
            this.linkNewCar.TabStop = true;
            this.linkNewCar.Text = "Neue Fahrzeuge";
            this.linkNewCar.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkNewCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewCar_LinkClicked);
            // 
            // dropdownFilter
            // 
            this.dropdownFilter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dropdownFilter.Controls.Add(this.textBox2);
            this.dropdownFilter.Controls.Add(this.textBox1);
            this.dropdownFilter.Location = new System.Drawing.Point(14, 196);
            this.dropdownFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dropdownFilter.Name = "dropdownFilter";
            this.dropdownFilter.Size = new System.Drawing.Size(271, 279);
            this.dropdownFilter.TabIndex = 8;
            this.dropdownFilter.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Marke";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(299, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 796);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(17, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 346);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "dummy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "dummy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // UsedCarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 941);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dropdownFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "UsedCarPage";
            this.Text = "UsedCarPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dropdownFilter.ResumeLayout(false);
            this.dropdownFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.LinkLabel linkUsedCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkNewCar;
        private System.Windows.Forms.Panel dropdownFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}