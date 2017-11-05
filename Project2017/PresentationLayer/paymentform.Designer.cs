namespace Project2017.PresentationLayer
{
    partial class paymentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentform));
            this.CardPaymentRadio = new System.Windows.Forms.RadioButton();
            this.PayLaterRadio = new System.Windows.Forms.RadioButton();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.ExpiryLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.CVSLabel = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.ContinueB = new System.Windows.Forms.Button();
            this.CardNumberTBox = new System.Windows.Forms.TextBox();
            this.CVSTBox = new System.Windows.Forms.TextBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CardPaymentRadio
            // 
            this.CardPaymentRadio.AutoSize = true;
            this.CardPaymentRadio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPaymentRadio.Location = new System.Drawing.Point(72, 35);
            this.CardPaymentRadio.Name = "CardPaymentRadio";
            this.CardPaymentRadio.Size = new System.Drawing.Size(114, 24);
            this.CardPaymentRadio.TabIndex = 0;
            this.CardPaymentRadio.Text = "Card Payment";
            this.CardPaymentRadio.UseVisualStyleBackColor = true;
            this.CardPaymentRadio.CheckedChanged += new System.EventHandler(this.CardPaymentRadio_CheckedChanged);
            // 
            // PayLaterRadio
            // 
            this.PayLaterRadio.AutoSize = true;
            this.PayLaterRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLaterRadio.Location = new System.Drawing.Point(469, 35);
            this.PayLaterRadio.Name = "PayLaterRadio";
            this.PayLaterRadio.Size = new System.Drawing.Size(93, 23);
            this.PayLaterRadio.TabIndex = 2;
            this.PayLaterRadio.Text = "Pay later";
            this.PayLaterRadio.UseVisualStyleBackColor = true;
            this.PayLaterRadio.CheckedChanged += new System.EventHandler(this.PayLaterRadio_CheckedChanged);
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTypeLabel.Location = new System.Drawing.Point(268, 102);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(72, 16);
            this.CardTypeLabel.TabIndex = 7;
            this.CardTypeLabel.Text = "Card Type";
            // 
            // ExpiryLabel
            // 
            this.ExpiryLabel.AutoSize = true;
            this.ExpiryLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryLabel.Location = new System.Drawing.Point(72, 170);
            this.ExpiryLabel.Name = "ExpiryLabel";
            this.ExpiryLabel.Size = new System.Drawing.Size(81, 16);
            this.ExpiryLabel.TabIndex = 8;
            this.ExpiryLabel.Text = "Expiry Date";
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardLabel.Location = new System.Drawing.Point(72, 102);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(92, 16);
            this.CardLabel.TabIndex = 9;
            this.CardLabel.Text = "Card Number";
            // 
            // CVSLabel
            // 
            this.CVSLabel.AutoSize = true;
            this.CVSLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVSLabel.Location = new System.Drawing.Point(72, 243);
            this.CVSLabel.Name = "CVSLabel";
            this.CVSLabel.Size = new System.Drawing.Size(60, 16);
            this.CVSLabel.TabIndex = 10;
            this.CVSLabel.Text = "CVS No.";
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.Location = new System.Drawing.Point(456, 347);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 11;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContinueB
            // 
            this.ContinueB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContinueB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueB.Location = new System.Drawing.Point(564, 347);
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(75, 23);
            this.ContinueB.TabIndex = 12;
            this.ContinueB.Text = "Continue";
            this.ContinueB.UseVisualStyleBackColor = true;
            this.ContinueB.Click += new System.EventHandler(this.ContinueB_Click);
            // 
            // CardNumberTBox
            // 
            this.CardNumberTBox.Location = new System.Drawing.Point(75, 122);
            this.CardNumberTBox.Name = "CardNumberTBox";
            this.CardNumberTBox.Size = new System.Drawing.Size(100, 20);
            this.CardNumberTBox.TabIndex = 13;
            // 
            // CVSTBox
            // 
            this.CVSTBox.Location = new System.Drawing.Point(75, 263);
            this.CVSTBox.Name = "CVSTBox";
            this.CVSTBox.Size = new System.Drawing.Size(100, 20);
            this.CVSTBox.TabIndex = 14;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Location = new System.Drawing.Point(75, 190);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(147, 20);
            this.ExpiryDatePicker.TabIndex = 15;
            // 
            // CardTypeComboBox
            // 
            this.CardTypeComboBox.FormattingEnabled = true;
            this.CardTypeComboBox.Location = new System.Drawing.Point(271, 120);
            this.CardTypeComboBox.Name = "CardTypeComboBox";
            this.CardTypeComboBox.Size = new System.Drawing.Size(69, 21);
            this.CardTypeComboBox.TabIndex = 16;
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.CardTypeComboBox);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.CVSTBox);
            this.Controls.Add(this.CardNumberTBox);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.CVSLabel);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.ExpiryLabel);
            this.Controls.Add(this.CardTypeLabel);
            this.Controls.Add(this.PayLaterRadio);
            this.Controls.Add(this.CardPaymentRadio);
            this.Name = "paymentform";
            this.Text = "paymentform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CardPaymentRadio;
        private System.Windows.Forms.RadioButton PayLaterRadio;
        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.Label ExpiryLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label CVSLabel;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.TextBox CardNumberTBox;
        private System.Windows.Forms.TextBox CVSTBox;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.ComboBox CardTypeComboBox;
    }
}