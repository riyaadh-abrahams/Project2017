namespace Project2017.PresentationLayer
{
    partial class SummaryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryPage));
            this.CancelB = new System.Windows.Forms.Button();
            this.ConfirmB = new System.Windows.Forms.Button();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.snameL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eAddL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelB.Location = new System.Drawing.Point(529, 410);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 1;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            // 
            // ConfirmB
            // 
            this.ConfirmB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmB.Location = new System.Drawing.Point(651, 410);
            this.ConfirmB.Name = "ConfirmB";
            this.ConfirmB.Size = new System.Drawing.Size(75, 23);
            this.ConfirmB.TabIndex = 2;
            this.ConfirmB.Text = "Confirm";
            this.ConfirmB.UseVisualStyleBackColor = true;
            // 
            // CustomerListView
            // 
            this.CustomerListView.Location = new System.Drawing.Point(12, 35);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(727, 347);
            this.CustomerListView.TabIndex = 6;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.SelectedIndexChanged += new System.EventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(74, 72);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(37, 14);
            this.nameL.TabIndex = 9;
            this.nameL.Text = "Name:";
            // 
            // snameL
            // 
            this.snameL.AutoSize = true;
            this.snameL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snameL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameL.Location = new System.Drawing.Point(210, 72);
            this.snameL.Name = "snameL";
            this.snameL.Size = new System.Drawing.Size(37, 14);
            this.snameL.TabIndex = 11;
            this.snameL.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surname:";
            // 
            // eAddL
            // 
            this.eAddL.AutoSize = true;
            this.eAddL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eAddL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eAddL.Location = new System.Drawing.Point(131, 99);
            this.eAddL.Name = "eAddL";
            this.eAddL.Size = new System.Drawing.Size(37, 14);
            this.eAddL.TabIndex = 13;
            this.eAddL.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email Address: ";
            // 
            // addL
            // 
            this.addL.AutoSize = true;
            this.addL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addL.Location = new System.Drawing.Point(92, 126);
            this.addL.Name = "addL";
            this.addL.Size = new System.Drawing.Size(37, 14);
            this.addL.TabIndex = 15;
            this.addL.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address: ";
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneL.Location = new System.Drawing.Point(84, 151);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(37, 14);
            this.phoneL.TabIndex = 17;
            this.phoneL.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Booking Details";
            // 
            // SummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 476);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eAddL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.snameL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.ConfirmB);
            this.Controls.Add(this.CancelB);
            this.Name = "SummaryPage";
            this.Text = "SummaryPage";
            this.Load += new System.EventHandler(this.SummaryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ConfirmB;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label snameL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eAddL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phoneL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}