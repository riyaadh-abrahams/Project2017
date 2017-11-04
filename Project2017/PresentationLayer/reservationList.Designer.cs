namespace Project2017.PresentationLayer
{
    partial class reservationList
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
            this.EditB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.IDTBox = new System.Windows.Forms.TextBox();
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.ContinueB = new System.Windows.Forms.Button();
            this.ReservationListview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EditB
            // 
            this.EditB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditB.Location = new System.Drawing.Point(164, 327);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(47, 23);
            this.EditB.TabIndex = 1;
            this.EditB.Text = "Edit";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.Location = new System.Drawing.Point(233, 328);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(68, 23);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // IDTBox
            // 
            this.IDTBox.Location = new System.Drawing.Point(30, 330);
            this.IDTBox.Name = "IDTBox";
            this.IDTBox.Size = new System.Drawing.Size(100, 20);
            this.IDTBox.TabIndex = 3;
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIDLabel.Location = new System.Drawing.Point(27, 311);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(82, 18);
            this.BookingIDLabel.TabIndex = 4;
            this.BookingIDLabel.Text = "BookingID";
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.Location = new System.Drawing.Point(317, 409);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // ContinueB
            // 
            this.ContinueB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueB.Location = new System.Drawing.Point(410, 409);
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(90, 23);
            this.ContinueB.TabIndex = 6;
            this.ContinueB.Text = "Continue";
            this.ContinueB.UseVisualStyleBackColor = true;
            this.ContinueB.Click += new System.EventHandler(this.ContinueB_Click);
            // 
            // ReservationListview
            // 
            this.ReservationListview.Location = new System.Drawing.Point(30, 39);
            this.ReservationListview.Name = "ReservationListview";
            this.ReservationListview.Size = new System.Drawing.Size(470, 258);
            this.ReservationListview.TabIndex = 7;
            this.ReservationListview.UseCompatibleStateImageBehavior = false;
            // 
            // reservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 471);
            this.Controls.Add(this.ReservationListview);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.BookingIDLabel);
            this.Controls.Add(this.IDTBox);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.EditB);
            this.Name = "reservationList";
            this.Text = "reservationList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.TextBox IDTBox;
        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.ListView ReservationListview;
    }
}