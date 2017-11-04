﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2017.BusinessLayer.Controllers;

namespace Project2017.PresentationLayer
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        private CustomerListForm customerListForm;
        private Form1 form1;
        private DateChooser dateChooser;
        private CustomerController customerController;
        private BookingController bookingController;

        public MDIParent1()
        {
            InitializeComponent();
            customerController = new CustomerController();
            bookingController = new BookingController();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (customerListForm == null)
            {
                CreateNewcustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewcustomerListForm();
            }

            customerListForm.setUpCustomerListView();
            customerListForm.Show();
        }

        private void CreateNewcustomerListForm()
        {
            customerListForm = new CustomerListForm(customerController);
            customerListForm.MdiParent = this;
            customerListForm.StartPosition = FormStartPosition.CenterParent;
            //customerListForm.WindowState = FormWindowState.Maximized;
            customerListForm.MaximizeBox = false;
            customerListForm.MinimizeBox = false;
            customerListForm.ShowIcon = false;
            customerListForm.FormBorderStyle=FormBorderStyle.None;
            customerListForm.Dock = DockStyle.Fill;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dateChooser == null)
            {
                CreateNewdateChooser();
            }
            if (dateChooser.dateChooserFormClosed)
            {
                CreateNewdateChooser();
            }

            dateChooser.Show();

        }

        private void CreateNewdateChooser()
        {
            dateChooser = new DateChooser(bookingController);
            dateChooser.MdiParent = this;
            dateChooser.StartPosition = FormStartPosition.CenterParent;
            //customerListForm.WindowState = FormWindowState.Maximized;
            dateChooser.MaximizeBox = false;
            dateChooser.MinimizeBox = false;
            dateChooser.ShowIcon = false;
            dateChooser.FormBorderStyle = FormBorderStyle.None;
            dateChooser.Dock = DockStyle.Fill;
        }
    }
}