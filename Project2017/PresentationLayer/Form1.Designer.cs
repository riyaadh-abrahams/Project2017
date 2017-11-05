namespace Project2017
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Check = new System.Windows.Forms.Button();
            this.Identity = new System.Windows.Forms.TextBox();
            this.AddressTBox = new System.Windows.Forms.TextBox();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.FirstTBox = new System.Windows.Forms.TextBox();
            this.phoneTBox = new System.Windows.Forms.TextBox();
            this.LastTBox = new System.Windows.Forms.TextBox();
            this.CancelB = new System.Windows.Forms.Button();
            this.ContinueB = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CountryTBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.Location = new System.Drawing.Point(216, 60);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 21);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Identity
            // 
            this.Identity.Location = new System.Drawing.Point(53, 61);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(100, 20);
            this.Identity.TabIndex = 1;
            // 
            // AddressTBox
            // 
            this.AddressTBox.Location = new System.Drawing.Point(47, 249);
            this.AddressTBox.Name = "AddressTBox";
            this.AddressTBox.Size = new System.Drawing.Size(208, 20);
            this.AddressTBox.TabIndex = 2;
            // 
            // EmailTBox
            // 
            this.EmailTBox.Location = new System.Drawing.Point(47, 187);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTBox.TabIndex = 3;
            // 
            // FirstTBox
            // 
            this.FirstTBox.Location = new System.Drawing.Point(53, 119);
            this.FirstTBox.Name = "FirstTBox";
            this.FirstTBox.Size = new System.Drawing.Size(100, 20);
            this.FirstTBox.TabIndex = 4;
            // 
            // phoneTBox
            // 
            this.phoneTBox.Location = new System.Drawing.Point(47, 389);
            this.phoneTBox.Name = "phoneTBox";
            this.phoneTBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTBox.TabIndex = 5;
            // 
            // LastTBox
            // 
            this.LastTBox.Location = new System.Drawing.Point(216, 119);
            this.LastTBox.Name = "LastTBox";
            this.LastTBox.Size = new System.Drawing.Size(100, 20);
            this.LastTBox.TabIndex = 6;
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.Location = new System.Drawing.Point(482, 419);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 10;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // ContinueB
            // 
            this.ContinueB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueB.Location = new System.Drawing.Point(573, 419);
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(75, 23);
            this.ContinueB.TabIndex = 11;
            this.ContinueB.Text = "Continue";
            this.ContinueB.UseVisualStyleBackColor = true;
            this.ContinueB.Click += new System.EventHandler(this.ContinueB_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(43, 366);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(102, 20);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Contact Details";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(217, 96);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 14;
            this.SurnameLabel.Text = "Last Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(49, 96);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 20);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "First Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(47, 41);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 18);
            this.IDLabel.TabIndex = 17;
            this.IDLabel.Text = "ID";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(49, 164);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(98, 20);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email address";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(49, 226);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(100, 20);
            this.AddressLabel.TabIndex = 19;
            this.AddressLabel.Text = "Street Address";
            // 
            // CountryTBox
            // 
            this.CountryTBox.Location = new System.Drawing.Point(47, 326);
            this.CountryTBox.Name = "CountryTBox";
            this.CountryTBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTBox.TabIndex = 7;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLabel.Location = new System.Drawing.Point(49, 303);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(58, 20);
            this.CountryLabel.TabIndex = 20;
            this.CountryLabel.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.CountryTBox);
            this.Controls.Add(this.LastTBox);
            this.Controls.Add(this.phoneTBox);
            this.Controls.Add(this.FirstTBox);
            this.Controls.Add(this.EmailTBox);
            this.Controls.Add(this.AddressTBox);
            this.Controls.Add(this.Identity);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox Identity;
        private System.Windows.Forms.TextBox AddressTBox;
        private System.Windows.Forms.TextBox EmailTBox;
        private System.Windows.Forms.TextBox FirstTBox;
        private System.Windows.Forms.TextBox phoneTBox;
        private System.Windows.Forms.TextBox LastTBox;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CountryTBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label label1;
    }
}

