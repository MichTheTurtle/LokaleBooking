using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace LokaleBookingSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_Rediger_Lokale_Click(object sender, EventArgs e)
        {
            System.Threading.Thread registerform = new System.Threading.Thread(() => Application.Run(new LokaleRedigeringsForm()));
            registerform.Start();
            this.Close();
        }

        private void btn_View_Lokale_Click(object sender, EventArgs e)
        {
            LokaleOversigtForm lof = new LokaleOversigtForm();
            lof.Show();
        }

        private void btn_Rediger_Booking_Click(object sender, EventArgs e)
        {
            System.Threading.Thread bookingoversigtform = new System.Threading.Thread(() => Application.Run(new BookingOversigtForm()));
            bookingoversigtform.Start();
        }

        private void btn_Rediger_Bruger_Click(object sender, EventArgs e)
        {
            System.Threading.Thread registerform = new System.Threading.Thread(() => Application.Run(new RegisterForm()));
            registerform.Start();
            this.Close();
        }

        private void btn_Bruger_View_Click(object sender, EventArgs e)
        {
            BrugerOversigtForm bof = new BrugerOversigtForm();
            bof.Show();
        }
    }
}
