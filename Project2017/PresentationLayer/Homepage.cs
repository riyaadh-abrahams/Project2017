using System;
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
        private DateChooser dateChooser;
        private CustomerController customerController;
        private Overview overView;
        private BookingController b;
        //private PaymentDetailController p;
        public bool HomepageFormClosed = false;
        public Homepage(Overview o)
        {
            InitializeComponent();
            this.overView = o;
            closeStuff();
            customerController = overView.customerController;
            this.b = overView.bookingController;

            //this.p = p;
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

        private void CreateDateChooserForm()
        {
            dateChooser = new DateChooser(overView);
            dateChooser.StartPosition = FormStartPosition.CenterParent;
            HomepageFormClosed = true;
        }

        private void makeReservation_Click(object sender, EventArgs e)
        {

            overView.CreateNewdateChooser();
            overView.dateChooser.Show();
        }


        private void ViewReservations_Click(object sender, EventArgs e)
        {
            overView.CreateReservationListForm();
            overView.viewList.Show();
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

        public void closeStuff()
        {
            if (overView.dateChooser != null)
                overView.dateChooser.Close();
            if (overView.personal != null)
                overView.personal.Close();
            if (overView.payinglaunch != null)
                overView.payinglaunch.Close();
            if (overView.summary != null)
                overView.summary.Close();
            if (overView.viewList != null)
                overView.viewList.Close();
            if (overView.customerListForm != null)
                overView.customerListForm.Close();
        }
        #endregion

        private void viewCustButton_Click(object sender, EventArgs e)
        {
            overView.CreateCustomerListForm();
            overView.customerListForm.Show();
        }
    }
}
