using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2017
{
    public partial class Form1 : Form
    {
        public bool form1Closed = false;
        public Form1()
        {
            InitializeComponent();
        }
        #region button click region

        private void Check_Click(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            ClearAll();
            form1Closed = true;
            this.Close();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Utility
        private void ClearAll()
        {
            Identity.Text = "";
            FirstTBox.Text = "";
            LastTBox.Text = "";
            phoneTBox.Text = "";
            AddressTBox.Text = "";
            CountryTBox.Text = "";
            PostalTBox.Text = "";
            EmailTBox.Text = "";
        }
        #endregion
    }
}
