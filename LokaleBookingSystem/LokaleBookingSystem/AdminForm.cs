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
using System.Xml.Serialization;
using System.IO;

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

        private void btn_Bruger_View_Click(object sender, EventArgs e)
        {
            BrugerOversigtForm bof = new BrugerOversigtForm();
            bof.Show();
        }

        private void btn_export_xml_Click(object sender, EventArgs e)
        {
            List<BookingDetails> BookingList = new List<BookingDetails>();

            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                var bookings = from b in ctx.Bookings select b;

                foreach (var booking in bookings)
                {
                    BookingDetails detail = new BookingDetails();
                    detail.ID = booking.BookingID;
                    detail.StartTidspunkt = booking.StartTidspunkt;
                    detail.SlutTidspunkt = booking.SlutTidspunkt;
                    detail.Lokale = booking.Lokale;
                    detail.BrugerID = booking.Bruger.BrugerID;
                    detail.Navn = booking.Bruger.Fornavn + " " + booking.Bruger.Efternavn;
                    BookingList.Add(detail);
                }
            }
            Serialize(BookingList);
        }

        public void Serialize(List<BookingDetails> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BookingDetails>));
            using (TextWriter writer = new StreamWriter(@"C:\bookings.xml"))
            {
                serializer.Serialize(writer, list);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread loginform = new System.Threading.Thread(() => Application.Run(new LoginForm()));
            loginform.Start();
            this.Close();
        }
    }
}