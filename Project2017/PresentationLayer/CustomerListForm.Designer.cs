﻿namespace Project2017.PresentationLayer
{
    partial class CustomerListForm
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
            this.customerListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // customerListView
            // 
            this.customerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerListView.Location = new System.Drawing.Point(0, 0);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(945, 527);
            this.customerListView.TabIndex = 7;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 527);
            this.Controls.Add(this.customerListView);
            this.Name = "CustomerListForm";
            this.Text = "reservationList";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView customerListView;
    }
}