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
using Project2017.BusinessLayer.Entities;

namespace Project2017.PresentationLayer
{
    public partial class Overview : Form
    {

        private int childFormNumber = 0;

        public Homepage goHome { get; set; }
        public reservationList viewList { get; set; }
        public CustomerController customerController { get; set; }
        public BookingController bookingController { get; set; }
        public DateChooser dateChooser { get; set; }
        public Form1 personal { get; set; }
        public paymentform payinglaunch { get; set; }
        public SummaryPage summary { get; set; }
        //private PaymentDetailController paymentDetailController;

        public Overview()
        {
            InitializeComponent();
            customerController = new CustomerController();
            bookingController = new BookingController();
            //paymentDetailController = new PaymentDetailController();

            if (goHome == null)
            {
                CreateHomepage();
            }
            if (goHome.HomepageFormClosed)
            {
                CreateHomepage();
            }

            goHome.Show();
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
        #region toosltrip
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
        #endregion

        # region HomePage and Reservation List

        private void CreateHomepage() 
        {
            goHome = new Homepage(customerController, bookingController, this/*, paymentDetailController*/);
            goHome.MdiParent = this;
            goHome.StartPosition = FormStartPosition.CenterParent;
            goHome.FormBorderStyle = FormBorderStyle.None;
            goHome.Dock = DockStyle.Fill;
        }

        private void CreateReservationList() 
        {
            viewList = new reservationList(customerController);
            viewList.MdiParent = this;
            viewList.StartPosition = FormStartPosition.CenterParent;
            viewList.FormBorderStyle = FormBorderStyle.None;
            viewList.Dock = DockStyle.Fill;
        }
        #endregion

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(goHome == null) {
                CreateHomepage();
            }
            if(goHome.HomepageFormClosed) {
                CreateHomepage();
            }

            goHome.Show();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(viewList==null) {
                CreateReservationList();
            }

            if(viewList.listFormClosed) {
                CreateReservationList();
            }

            viewList.setUpReservationListView();
            viewList.Show();
        }

        #region CreateStuff

        public void CreateNewdateChooser()
        {
            dateChooser = new DateChooser(this);
            dateChooser.MdiParent = this;
            dateChooser.StartPosition = FormStartPosition.CenterParent;
            //customerListForm.WindowState = FormWindowState.Maximized;
            dateChooser.MaximizeBox = false;
            dateChooser.MinimizeBox = false;
            dateChooser.ShowIcon = false;
            dateChooser.FormBorderStyle = FormBorderStyle.None;
            dateChooser.Dock = DockStyle.Fill;
        }

        public void CreatePersonalForm()
        {
            personal = new Form1(this);
            personal.StartPosition = FormStartPosition.CenterParent;
            personal.MdiParent = this;
            //dateChooserFormClosed = true;
            personal.FormBorderStyle = FormBorderStyle.None;
            personal.Dock = DockStyle.Fill;
        }

        public void CreatePaymentForm()
        {
            payinglaunch = new paymentform(this);
            payinglaunch.MdiParent = this;
            payinglaunch.StartPosition = FormStartPosition.CenterParent;
            payinglaunch.FormBorderStyle = FormBorderStyle.None;
            payinglaunch.Dock = DockStyle.Fill;
        }

        public void CreateSummaryForm()
        {
            summary = new SummaryPage(customerController);
            summary.MdiParent = this;
            summary.StartPosition = FormStartPosition.CenterParent;
            summary.FormBorderStyle = FormBorderStyle.None;
            summary.Dock = DockStyle.Fill;
        }

        #endregion
    }
}
