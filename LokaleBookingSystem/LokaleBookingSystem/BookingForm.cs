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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateTime.Today;
            slutDateTimePicker.Value = DateTime.Today;
        }

        private void btn_book_Click(object sender, EventArgs e)
        {

            using (var ctx = new Context())
            {
                Lokale lokale2 = (from s in ctx.Lokaler
                                  where s.LokaleNavn == txtBx_Lokale.Text
                                  select s).FirstOrDefault();

                Bruger bruger2 = (from s in ctx.Brugere
                                  where s.Username == LoginForm.Username
                                  select s).FirstOrDefault();

                if (lokale2 != null)
                {
                    Booking booking = new Booking() { StartTidspunkt = startDateTimePicker.Value, SlutTidspunkt = slutDateTimePicker.Value, Lokale = lokale2, Bruger = bruger2, SendtMail = false };
                    ctx.Bookings.Add(booking);
                    ctx.SaveChanges();
                }
                else
                    MessageBox.Show("Ugyldig lokale navn!");
                
            }
        }
    }
}
