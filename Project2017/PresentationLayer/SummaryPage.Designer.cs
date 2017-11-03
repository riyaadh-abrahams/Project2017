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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CancelB = new System.Windows.Forms.Button();
            this.ConfirmB = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(88, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 290);
            this.listBox1.TabIndex = 0;
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
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(515, 13);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 3;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(481, 181);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 41);
            this.Delete.TabIndex = 4;
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(481, 83);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(56, 42);
            this.Edit.TabIndex = 5;
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // SummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 476);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.ConfirmB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.listBox1);
            this.Name = "SummaryPage";
            this.Text = "SummaryPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ConfirmB;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
    }
}