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
    public partial class BookingRedigeringsForm : Form
    {
        private int bookingID;
        public int BookingID { get; set; }

        private string lokale;
        public string Lokale { get; set; }

        private DateTime start;
        public DateTime Start { get; set; }

        private DateTime slut;
        public DateTime Slut { get; set; }



        public BookingRedigeringsForm(int bookingID, string lokale, DateTime start, DateTime slut)
        {
            InitializeComponent();
            this.bookingID = bookingID;
            this.lokale = lokale;
            this.start = start;
            this.slut = slut;
        }

        private void BookingRedigeringsForm_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = start;
            slutDateTimePicker.Value = slut;
            txtBx_Lokale.Text = lokale;
        }

        private void btn_RedigerBooking_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Lokale lokale2 = (from s in ctx.Lokaler
                                  where s.LokaleNavn == txtBx_Lokale.Text
                                  select s).FirstOrDefault();

                Booking booking = (from s in ctx.Bookings
                                 where s.BookingID == bookingID
                                 select s).FirstOrDefault();
                booking.StartTidspunkt = startDateTimePicker.Value;
                booking.SlutTidspunkt = slutDateTimePicker.Value;
                booking.Lokale = lokale2;
                ctx.SaveChanges();
            }
            System.Threading.Thread bookingoversigtform = new System.Threading.Thread(() => Application.Run(new BookingOversigtForm()));
            bookingoversigtform.Start();
            this.Close();
        }

        private void btn_Slet_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Booking booking = ctx.Bookings.Where(b => b.BookingID == bookingID).First();
                ctx.Bookings.Remove(booking);
                ctx.SaveChanges();
                System.Threading.Thread bookingoversigtform = new System.Threading.Thread(() => Application.Run(new BookingOversigtForm()));
                bookingoversigtform.Start();
                this.Close();
            }
        }

    }
}
