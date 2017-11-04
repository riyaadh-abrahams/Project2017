namespace Project2017.PresentationLayer
{
    partial class Homepage
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
            this.ExitB = new System.Windows.Forms.Button();
            this.makeReservation = new System.Windows.Forms.Button();
            this.GenerateReports = new System.Windows.Forms.Button();
            this.ViewReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitB
            // 
            this.ExitB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitB.Location = new System.Drawing.Point(448, 333);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(75, 23);
            this.ExitB.TabIndex = 0;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            // 
            // makeReservation
            // 
            this.makeReservation.Location = new System.Drawing.Point(111, 72);
            this.makeReservation.Name = "makeReservation";
            this.makeReservation.Size = new System.Drawing.Size(75, 23);
            this.makeReservation.TabIndex = 1;
            this.makeReservation.Text = "button2";
            this.makeReservation.UseVisualStyleBackColor = true;
            // 
            // GenerateReports
            // 
            this.GenerateReports.Location = new System.Drawing.Point(378, 72);
            this.GenerateReports.Name = "GenerateReports";
            this.GenerateReports.Size = new System.Drawing.Size(75, 23);
            this.GenerateReports.TabIndex = 2;
            this.GenerateReports.Text = "button3";
            this.GenerateReports.UseVisualStyleBackColor = true;
            // 
            // ViewReservations
            // 
            this.ViewReservations.Location = new System.Drawing.Point(111, 233);
            this.ViewReservations.Name = "ViewReservations";
            this.ViewReservations.Size = new System.Drawing.Size(75, 23);
            this.ViewReservations.TabIndex = 3;
            this.ViewReservations.Text = "button4";
            this.ViewReservations.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 402);
            this.Controls.Add(this.ViewReservations);
            this.Controls.Add(this.GenerateReports);
            this.Controls.Add(this.makeReservation);
            this.Controls.Add(this.ExitB);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button makeReservation;
        private System.Windows.Forms.Button GenerateReports;
        private System.Windows.Forms.Button ViewReservations;
    }
}