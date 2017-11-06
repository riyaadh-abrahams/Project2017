﻿namespace Project2017.PresentationLayer
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
            this.ExpiryLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.CVSLabel = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.ContinueB = new System.Windows.Forms.Button();
            this.CardNumberTBox = new System.Windows.Forms.TextBox();
            this.CVSTBox = new System.Windows.Forms.TextBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.vL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardPaymentRadio
            // 
            this.CardPaymentRadio.AutoSize = true;
            this.CardPaymentRadio.Checked = true;
            this.CardPaymentRadio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPaymentRadio.Location = new System.Drawing.Point(72, 35);
            this.CardPaymentRadio.Name = "CardPaymentRadio";
            this.CardPaymentRadio.Size = new System.Drawing.Size(114, 24);
            this.CardPaymentRadio.TabIndex = 0;
            this.CardPaymentRadio.TabStop = true;
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
            this.CardNumberTBox.MaxLength = 16;
            this.CardNumberTBox.Name = "CardNumberTBox";
            this.CardNumberTBox.Size = new System.Drawing.Size(191, 20);
            this.CardNumberTBox.TabIndex = 13;
            // 
            // CVSTBox
            // 
            this.CVSTBox.Location = new System.Drawing.Point(75, 263);
            this.CVSTBox.MaxLength = 3;
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
            // vL
            // 
            this.vL.AutoSize = true;
            this.vL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vL.ForeColor = System.Drawing.Color.Red;
            this.vL.Location = new System.Drawing.Point(380, 123);
            this.vL.Name = "vL";
            this.vL.Size = new System.Drawing.Size(0, 16);
            this.vL.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Payment Details";
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vL);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.CVSTBox);
            this.Controls.Add(this.CardNumberTBox);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.CVSLabel);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.ExpiryLabel);
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
        private System.Windows.Forms.Label ExpiryLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label CVSLabel;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.TextBox CardNumberTBox;
        private System.Windows.Forms.TextBox CVSTBox;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.Label vL;
        private System.Windows.Forms.Label label2;
    }
}