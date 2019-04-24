namespace BazaDanychKlientów
{
    partial class Form2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.customerLastName = new System.Windows.Forms.Label();
            this.customerNationality = new System.Windows.Forms.Label();
            this.customerAge = new System.Windows.Forms.Label();
            this.customerTelephone = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(400, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(400, 80);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(53, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Nazwisko";
            // 
            // Nationality
            // 
            this.Nationality.AutoSize = true;
            this.Nationality.Location = new System.Drawing.Point(400, 116);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(67, 13);
            this.Nationality.TabIndex = 2;
            this.Nationality.Text = "Narodowość";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(400, 149);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(32, 13);
            this.Age.TabIndex = 3;
            this.Age.Text = "Wiek";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(400, 179);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(43, 13);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.Text = "Telefon";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(400, 211);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(34, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "Adres";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(122, 50);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(26, 13);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Imię";
            this.customerName.Click += new System.EventHandler(this.customerName_Click);
            // 
            // customerLastName
            // 
            this.customerLastName.AutoSize = true;
            this.customerLastName.Location = new System.Drawing.Point(122, 80);
            this.customerLastName.Name = "customerLastName";
            this.customerLastName.Size = new System.Drawing.Size(53, 13);
            this.customerLastName.TabIndex = 7;
            this.customerLastName.Text = "Nazwisko";
            // 
            // customerNationality
            // 
            this.customerNationality.AutoSize = true;
            this.customerNationality.Location = new System.Drawing.Point(122, 116);
            this.customerNationality.Name = "customerNationality";
            this.customerNationality.Size = new System.Drawing.Size(67, 13);
            this.customerNationality.TabIndex = 8;
            this.customerNationality.Text = "Narodowość";
            // 
            // customerAge
            // 
            this.customerAge.AutoSize = true;
            this.customerAge.Location = new System.Drawing.Point(122, 149);
            this.customerAge.Name = "customerAge";
            this.customerAge.Size = new System.Drawing.Size(32, 13);
            this.customerAge.TabIndex = 9;
            this.customerAge.Text = "Wiek";
            this.customerAge.Click += new System.EventHandler(this.customerAge_Click);
            // 
            // customerTelephone
            // 
            this.customerTelephone.AutoSize = true;
            this.customerTelephone.Location = new System.Drawing.Point(122, 179);
            this.customerTelephone.Name = "customerTelephone";
            this.customerTelephone.Size = new System.Drawing.Size(43, 13);
            this.customerTelephone.TabIndex = 10;
            this.customerTelephone.Text = "Telefon";
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSize = true;
            this.customerAddress.Location = new System.Drawing.Point(122, 211);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(34, 13);
            this.customerAddress.TabIndex = 11;
            this.customerAddress.Text = "Adres";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 282);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerTelephone);
            this.Controls.Add(this.customerAge);
            this.Controls.Add(this.customerNationality);
            this.Controls.Add(this.customerLastName);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Nationality;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerLastName;
        private System.Windows.Forms.Label customerNationality;
        private System.Windows.Forms.Label customerAge;
        private System.Windows.Forms.Label customerTelephone;
        private System.Windows.Forms.Label customerAddress;
    }
}