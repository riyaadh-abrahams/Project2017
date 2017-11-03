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
            this.CardPaymentRadio = new System.Windows.Forms.RadioButton();
            this.PayLaterRadio = new System.Windows.Forms.RadioButton();
            this.CardNumberTBox = new System.Windows.Forms.TextBox();
            this.CardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CVSTBox = new System.Windows.Forms.TextBox();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.ExpiryLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.CVSLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // CardNumberTBox
            // 
            this.CardNumberTBox.Location = new System.Drawing.Point(72, 121);
            this.CardNumberTBox.Name = "CardNumberTBox";
            this.CardNumberTBox.Size = new System.Drawing.Size(149, 20);
            this.CardNumberTBox.TabIndex = 3;
            this.CardNumberTBox.TextChanged += new System.EventHandler(this.CardNumberTBox_TextChanged);
            // 
            // CardTypeComboBox
            // 
            this.CardTypeComboBox.FormattingEnabled = true;
            this.CardTypeComboBox.Location = new System.Drawing.Point(268, 121);
            this.CardTypeComboBox.Name = "CardTypeComboBox";
            this.CardTypeComboBox.Size = new System.Drawing.Size(48, 21);
            this.CardTypeComboBox.TabIndex = 4;
            this.CardTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CardTypeComboBox_SelectedIndexChanged);
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Location = new System.Drawing.Point(72, 189);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ExpiryDatePicker.TabIndex = 5;
            this.ExpiryDatePicker.ValueChanged += new System.EventHandler(this.ExpiryDatePicker_ValueChanged);
            // 
            // CVSTBox
            // 
            this.CVSTBox.Location = new System.Drawing.Point(72, 262);
            this.CVSTBox.Name = "CVSTBox";
            this.CVSTBox.Size = new System.Drawing.Size(74, 20);
            this.CVSTBox.TabIndex = 6;
            this.CVSTBox.TextChanged += new System.EventHandler(this.CVSTBox_TextChanged);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(564, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CVSLabel);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.ExpiryLabel);
            this.Controls.Add(this.CardTypeLabel);
            this.Controls.Add(this.CVSTBox);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.CardTypeComboBox);
            this.Controls.Add(this.CardNumberTBox);
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
        private System.Windows.Forms.TextBox CardNumberTBox;
        private System.Windows.Forms.ComboBox CardTypeComboBox;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.TextBox CVSTBox;
        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.Label ExpiryLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label CVSLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}