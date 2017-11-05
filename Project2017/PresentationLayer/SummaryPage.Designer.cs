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
            this.CustomerListView.Location = new System.Drawing.Point(12, 12);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(727, 350);
            this.CustomerListView.TabIndex = 6;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.SelectedIndexChanged += new System.EventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // SummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 476);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.ConfirmB);
            this.Controls.Add(this.CancelB);
            this.Name = "SummaryPage";
            this.Text = "SummaryPage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button ConfirmB;
        private System.Windows.Forms.ListView CustomerListView;
    }
}