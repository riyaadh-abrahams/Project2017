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

namespace Project2017.PresentationLayer
{
    public partial class paymentform : Form
    {
        private Pay
        public paymentform()
        {
            InitializeComponent();
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
                    p
                }
            }
        }

        private void PayLaterRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Form events

        private void CardNumberTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExpiryDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CVSTBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region utility methods

        private void ShowAll(bool value)
        {
            CardLabel.Visible = value;
            CardTypeLabel.Visible = value;
            CVSLabel.Visible = value;
            ExpiryLabel.Visible = value;

            if (!(value))
            {
                CardPaymentRadio.Checked = false;
                PayLaterRadio.Checked = false;
            }



        }
        #endregion

    }
}
