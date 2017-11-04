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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
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
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // makeReservation
            // 
            this.makeReservation.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeReservation.Location = new System.Drawing.Point(56, 104);
            this.makeReservation.Name = "makeReservation";
            this.makeReservation.Size = new System.Drawing.Size(127, 49);
            this.makeReservation.TabIndex = 1;
            this.makeReservation.Text = "Make Reservation";
            this.makeReservation.UseVisualStyleBackColor = true;
            this.makeReservation.Click += new System.EventHandler(this.makeReservation_Click);
            // 
            // GenerateReports
            // 
            this.GenerateReports.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReports.Location = new System.Drawing.Point(403, 105);
            this.GenerateReports.Name = "GenerateReports";
            this.GenerateReports.Size = new System.Drawing.Size(127, 49);
            this.GenerateReports.TabIndex = 2;
            this.GenerateReports.Text = "Generate Reports";
            this.GenerateReports.UseVisualStyleBackColor = true;
            // 
            // ViewReservations
            // 
            this.ViewReservations.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReservations.Location = new System.Drawing.Point(227, 104);
            this.ViewReservations.Name = "ViewReservations";
            this.ViewReservations.Size = new System.Drawing.Size(127, 49);
            this.ViewReservations.TabIndex = 3;
            this.ViewReservations.Text = "View Reservation";
            this.ViewReservations.UseVisualStyleBackColor = true;
            this.ViewReservations.Click += new System.EventHandler(this.ViewReservations_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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