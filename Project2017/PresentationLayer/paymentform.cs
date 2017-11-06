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
    public partial class paymentform : Form
    {

        public enum paymentType
        {
            CreditCard = 0,
            Paylater = 1
        }
        private paymentType paytype;
        private SummaryPage summary;
        private Customer customer;
        private CustomerController customerController;
        public bool formClose=false;
        Overview overView;

        public paymentform(Overview overView)
        {
            InitializeComponent();
            this.overView = overView;
            customerController = overView.customerController;
            ShowAll(true, paymentType.CreditCard);

            ExpiryDatePicker.Format = DateTimePickerFormat.Custom;
            ExpiryDatePicker.CustomFormat = "MM/yyyy";
            ExpiryDatePicker.ShowUpDown = true;
        }
        #region Radio Buttons
        private void CardPaymentRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cardPayment = sender as RadioButton;

            if(cardPayment != null)
            {
                if (cardPayment.Checked)
                {
                    this.Text = "CardPayment";
                    paytype = paymentType.CreditCard;
                    ShowAll(true, paytype);
                }
            }
        }

        private void PayLaterRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton paylater = sender as RadioButton;
            this.Text = "pay Later";
            paytype = paymentType.Paylater;
            ShowAll(true, paytype);
        }

        #endregion

        #region Form events Click

        private void button1_Click(object sender, EventArgs e)
        {
            formClose = true;
            this.Hide();
        }
        private void ContinueB_Click(object sender, EventArgs e)
        {
            if (paytype == paymentType.Paylater)
            {
                overView.myBooking.DepositPaid = false;
                overView.myBooking.PaymentID = null;
                vL.Visible = false;

                if (overView.summary == null)
                {
                    overView.CreateSummaryForm();
                }

                if (overView.summary.SummaryFormClosed)
                {
                    overView.CreateSummaryForm();
                }
                overView.summary.Show();
            }
            else
            {
                if (verifyInputs())
                {
                    overView.myBooking.DepositPaid = true;
                    overView.myPaymentDetail = new PaymentDetail();
                    overView.myPaymentDetail.CreditCardNumber = CardNumberTBox.Text;
                    overView.myPaymentDetail.ExpiryMonth = ExpiryDatePicker.Value.Month;
                    overView.myPaymentDetail.ExpiryMonth = ExpiryDatePicker.Value.Year;
                    overView.myPaymentDetail.CVC = CVSTBox.Text;
                    overView.myPaymentDetail.PaymentID = overView.RandomString(9);
                    overView.myBooking.PaymentID = overView.myPaymentDetail.PaymentID;
                    vL.Visible = false;

                    if (overView.summary == null)
                    {
                        overView.CreateSummaryForm();
                    }

                    if (overView.summary.SummaryFormClosed)
                    {
                        overView.CreateSummaryForm();
                    }
                    overView.summary.Show();


                }
                else
                {
                    vL.Visible = true;
                    vL.Text = "Error! Check input values";
                }
            }
            
        }


        #endregion

        #region utility methods

        private void ShowAll(bool value, paymentType paytype)
        {
            

            if (!(value))
            {
                CardPaymentRadio.Checked = false;
                PayLaterRadio.Checked = false;
            }
            if ((paytype == paymentType.CreditCard))
            {
                CardLabel.Visible = value;
                CVSLabel.Visible = value;
                ExpiryLabel.Visible = value;

                CardNumberTBox.Visible = value;
                CVSTBox.Visible = value;
                ExpiryDatePicker.Visible = value;
            }
            else
            {
                CardLabel.Visible = false;
                CVSLabel.Visible = false;
                ExpiryLabel.Visible = false;

                CardNumberTBox.Visible = false;
                CVSTBox.Visible = false;
                ExpiryDatePicker.Visible = false;
            }

        }

        private void ClearAll()
        {
            CardNumberTBox.Text = "";
            CVSTBox.Text = "";
            //piryDatePicker.
            // I am not sure of the date time picker

        }

        private bool verifyInputs()
        {
            if (CardNumberTBox.Text.All(Char.IsDigit) 
                && CVSTBox.Text.All(Char.IsDigit)
                && CardNumberTBox.Text.Length==16
                && CVSTBox.Text.Length==3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        
    }
}
