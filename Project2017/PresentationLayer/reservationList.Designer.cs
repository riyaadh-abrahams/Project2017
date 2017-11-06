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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationList));
            this.EditB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.ReservationListview = new System.Windows.Forms.ListView();
            this.arrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.arrL = new System.Windows.Forms.Label();
            this.depL = new System.Windows.Forms.Label();
            this.numL = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.depositLabel = new System.Windows.Forms.Label();
            this.canIBookLable = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.summaryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EditB
            // 
            this.EditB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditB.Location = new System.Drawing.Point(795, 356);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(67, 30);
            this.EditB.TabIndex = 1;
            this.EditB.Text = "Edit";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.Location = new System.Drawing.Point(868, 356);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(68, 30);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // ReservationListview
            // 
            this.ReservationListview.Location = new System.Drawing.Point(12, 39);
            this.ReservationListview.Name = "ReservationListview";
            this.ReservationListview.Size = new System.Drawing.Size(924, 311);
            this.ReservationListview.TabIndex = 7;
            this.ReservationListview.UseCompatibleStateImageBehavior = false;
            this.ReservationListview.SelectedIndexChanged += new System.EventHandler(this.ReservationListview_SelectedIndexChanged);
            // 
            // arrivalDatePicker
            // 
            this.arrivalDatePicker.Location = new System.Drawing.Point(30, 447);
            this.arrivalDatePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.arrivalDatePicker.MinDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.arrivalDatePicker.Name = "arrivalDatePicker";
            this.arrivalDatePicker.Size = new System.Drawing.Size(141, 20);
            this.arrivalDatePicker.TabIndex = 8;
            this.arrivalDatePicker.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.arrivalDatePicker.ValueChanged += new System.EventHandler(this.arrivalDatePicker_ValueChanged);
            // 
            // departureDatePicker
            // 
            this.departureDatePicker.Location = new System.Drawing.Point(224, 447);
            this.departureDatePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.departureDatePicker.MinDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.departureDatePicker.Name = "departureDatePicker";
            this.departureDatePicker.Size = new System.Drawing.Size(141, 20);
            this.departureDatePicker.TabIndex = 9;
            this.departureDatePicker.Value = new System.DateTime(2017, 12, 2, 0, 0, 0, 0);
            this.departureDatePicker.ValueChanged += new System.EventHandler(this.departureDatePicker_ValueChanged);
            // 
            // numRoomsUpDown
            // 
            this.numRoomsUpDown.Location = new System.Drawing.Point(416, 447);
            this.numRoomsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomsUpDown.Name = "numRoomsUpDown";
            this.numRoomsUpDown.Size = new System.Drawing.Size(118, 20);
            this.numRoomsUpDown.TabIndex = 10;
            this.numRoomsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomsUpDown.ValueChanged += new System.EventHandler(this.numRoomsUpDown_ValueChanged);
            this.numRoomsUpDown.Click += new System.EventHandler(this.numRoomsUpDown_Click);
            // 
            // arrL
            // 
            this.arrL.AutoSize = true;
            this.arrL.BackColor = System.Drawing.Color.White;
            this.arrL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrL.Location = new System.Drawing.Point(32, 428);
            this.arrL.Name = "arrL";
            this.arrL.Size = new System.Drawing.Size(83, 16);
            this.arrL.TabIndex = 11;
            this.arrL.Text = "Arrival Date";
            // 
            // depL
            // 
            this.depL.AutoSize = true;
            this.depL.BackColor = System.Drawing.Color.White;
            this.depL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depL.Location = new System.Drawing.Point(221, 428);
            this.depL.Name = "depL";
            this.depL.Size = new System.Drawing.Size(104, 16);
            this.depL.TabIndex = 13;
            this.depL.Text = "Departure Date";
            // 
            // numL
            // 
            this.numL.AutoSize = true;
            this.numL.BackColor = System.Drawing.Color.White;
            this.numL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numL.Location = new System.Drawing.Point(413, 428);
            this.numL.Name = "numL";
            this.numL.Size = new System.Drawing.Size(121, 16);
            this.numL.TabIndex = 14;
            this.numL.Text = "Number of Rooms";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(881, 437);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 30);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(808, 437);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(67, 30);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(37, 395);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(0, 19);
            this.depositLabel.TabIndex = 19;
            // 
            // canIBookLable
            // 
            this.canIBookLable.AutoSize = true;
            this.canIBookLable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canIBookLable.Location = new System.Drawing.Point(37, 358);
            this.canIBookLable.Name = "canIBookLable";
            this.canIBookLable.Size = new System.Drawing.Size(0, 19);
            this.canIBookLable.TabIndex = 18;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idL.Location = new System.Drawing.Point(412, 361);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(0, 19);
            this.idL.TabIndex = 20;
            // 
            // summaryButton
            // 
            this.summaryButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.Location = new System.Drawing.Point(12, 356);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(90, 30);
            this.summaryButton.TabIndex = 21;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(391, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(168, 30);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bookings";
            // 
            // reservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.canIBookLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numL);
            this.Controls.Add(this.depL);
            this.Controls.Add(this.arrL);
            this.Controls.Add(this.numRoomsUpDown);
            this.Controls.Add(this.departureDatePicker);
            this.Controls.Add(this.arrivalDatePicker);
            this.Controls.Add(this.ReservationListview);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.EditB);
            this.Name = "reservationList";
            this.Text = "reservationList";
            ((System.ComponentModel.ISupportInitialize)(this.numRoomsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.ListView ReservationListview;
        private System.Windows.Forms.DateTimePicker arrivalDatePicker;
        private System.Windows.Forms.DateTimePicker departureDatePicker;
        private System.Windows.Forms.NumericUpDown numRoomsUpDown;
        private System.Windows.Forms.Label arrL;
        private System.Windows.Forms.Label depL;
        private System.Windows.Forms.Label numL;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label canIBookLable;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
    }
}