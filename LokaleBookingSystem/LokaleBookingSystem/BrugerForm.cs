using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokaleBookingSystem
{
    public partial class BrugerForm : Form
    {
        public BrugerForm()
        {
            InitializeComponent();
        }

        private void btn_View_Lokale_Click(object sender, EventArgs e)
        {
            LokaleOversigtForm lof = new LokaleOversigtForm();
            lof.Show();
        }

        private void btn_Rediger_Booking_Click(object sender, EventArgs e)
        {
            System.Threading.Thread bookingform = new System.Threading.Thread(() => Application.Run(new BookingForm()));
            bookingform.Start();
            this.Close();
        }

        private void btn_Booking_View_Click(object sender, EventArgs e)
        {

        }

    }
}
