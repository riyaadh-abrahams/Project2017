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
    public partial class DateChooser : Form
    {
        public bool dateChooserFormClosed = false;
        private BookingController myBooking;

        public DateChooser(BookingController booking)
        {
            InitializeComponent();
            myBooking = booking;
        }
        


    }
}
