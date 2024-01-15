namespace MM_Autohandel
{
    partial class Home
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
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1652, 135);
            this.panel1.TabIndex = 0;
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
            this.linkUsedCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUsedCar_LinkClicked);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 948);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.LinkLabel linkUsedCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkNewCar;
    }
}