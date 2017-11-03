namespace Project2017.PresentationLayer
{
    partial class DateChooser
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
            this.arrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.checkAvailabilityButton = new System.Windows.Forms.Button();
            this.ContinueB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.departurelDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDatePicker
            // 
            this.arrivalDatePicker.Location = new System.Drawing.Point(108, 64);
            this.arrivalDatePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.arrivalDatePicker.MinDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.arrivalDatePicker.Name = "arrivalDatePicker";
            this.arrivalDatePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDatePicker.TabIndex = 0;
            this.arrivalDatePicker.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // numRoomsUpDown
            // 
            this.numRoomsUpDown.Location = new System.Drawing.Point(108, 224);
            this.numRoomsUpDown.Name = "numRoomsUpDown";
            this.numRoomsUpDown.Size = new System.Drawing.Size(200, 20);
            this.numRoomsUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arrival Date";
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.Location = new System.Drawing.Point(542, 383);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 8;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            // 
            // checkAvailabilityButton
            // 
            this.checkAvailabilityButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvailabilityButton.Location = new System.Drawing.Point(112, 292);
            this.checkAvailabilityButton.Name = "checkAvailabilityButton";
            this.checkAvailabilityButton.Size = new System.Drawing.Size(200, 64);
            this.checkAvailabilityButton.TabIndex = 9;
            this.checkAvailabilityButton.Text = "Search";
            this.checkAvailabilityButton.UseVisualStyleBackColor = true;
            // 
            // ContinueB
            // 
            this.ContinueB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueB.Location = new System.Drawing.Point(639, 383);
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(75, 23);
            this.ContinueB.TabIndex = 10;
            this.ContinueB.Text = "Continue";
            this.ContinueB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Departure Date";
            // 
            // departurelDatePicker
            // 
            this.departurelDatePicker.Location = new System.Drawing.Point(108, 140);
            this.departurelDatePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.departurelDatePicker.MinDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.departurelDatePicker.Name = "departurelDatePicker";
            this.departurelDatePicker.Size = new System.Drawing.Size(200, 20);
            this.departurelDatePicker.TabIndex = 11;
            this.departurelDatePicker.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of Rooms";
            // 
            // DateChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departurelDatePicker);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.checkAvailabilityButton);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRoomsUpDown);
            this.Controls.Add(this.arrivalDatePicker);
            this.Name = "DateChooser";
            this.Text = "DateChooser";
            ((System.ComponentModel.ISupportInitialize)(this.numRoomsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker arrivalDatePicker;
        private System.Windows.Forms.NumericUpDown numRoomsUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button checkAvailabilityButton;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker departurelDatePicker;
        private System.Windows.Forms.Label label3;
    }
}