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
using Project2017.PresentationLayer;

namespace Project2017.PresentationLayer
{
    public partial class Homepage : Form
    {
        private DateChooser chooseDate;
        private reservationList viewList;
        private Customer customer;
        private CustomerController customerController;
        public bool HomepageFormClosed = false;
        public Homepage()
        {
            InitializeComponent();
        }

        #region Form Events
        private void Homepage_Load(object sender, EventArgs e)
        {
            ShowAll(false);
        }

        private void Homepage_Activated(object sender, EventArgs e)
        {
            ShowAll(false);
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            HomepageFormClosed = true;
        }

        #endregion

        #region Button click

        private void makeReservation_Click(object sender, EventArgs e)
        {

        }

        private void CreateDateChooserForm()
        {

        }

        private void ViewReservations_Click(object sender, EventArgs e)
        {

        }

        private void CreateReservationListForm()
        {

        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            HomepageFormClosed = true;
            this.Close();
        }

        #endregion

        #region Utility methods

        private void ShowAll(bool value)
        {
            makeReservation.Visible = value;
            ViewReservations.Visible = value;
            GenerateReports.Visible = value;
            ExitB.Visible = value;
        }
        #endregion
    }
}
