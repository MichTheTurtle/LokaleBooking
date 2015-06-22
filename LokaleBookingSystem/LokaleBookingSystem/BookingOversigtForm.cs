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
    public partial class BookingOversigtForm : Form
    {
        public BookingOversigtForm()
        {
            InitializeComponent();
        }

        private void BookingOversigtForm_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("BookingID", 70);
            listView1.Columns.Add("UserName", 70);
            listView1.Columns.Add("Påmindelse", 80);
            listView1.Columns.Add("LokaleNavn", 80);
            listView1.Columns.Add("Start", 80);
            listView1.Columns.Add("Slut", 80);

            listView1.FullRowSelect = true;

            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;

            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                var bookings = from b in ctx.Bookings select b;

                foreach (var book in bookings)
                {
                    Bruger user = book.Bruger;
                    arr[0] = book.BookingID.ToString();
                    arr[1] = book.Bruger.Username.ToString();
                    arr[2] = book.SendtMail.ToString();
                    arr[3] = book.Lokale.LokaleNavn;
                    arr[4] = book.StartTidspunkt.ToString("dd-MM-yyyy");
                    arr[5] = book.SlutTidspunkt.ToString("dd-MM-yyyy");
                    if (LoginForm.Rettighed != "Admin")
                    {
                        if (book.Bruger.Username == LoginForm.Username)
                        {
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else
                    {
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
            }
        }

        private void redigerBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
                int bookingID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                string lokale = listView1.SelectedItems[0].SubItems[3].Text;
                DateTime start = DateTime.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                DateTime slut = DateTime.Parse(listView1.SelectedItems[0].SubItems[5].Text);
                System.Threading.Thread bookingredigerform = new System.Threading.Thread(() => Application.Run(new BookingRedigeringsForm(bookingID, lokale, start, slut)));
                bookingredigerform.Start();
                this.Close();
        }

        private void sletBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Booking booking = ctx.Bookings.Where(b => b.BookingID == bookingID).First();
                ctx.Bookings.Remove(booking);
                ctx.SaveChanges();
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = true;
            }
            else
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
            }
        }

        private void nyBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread bookingform = new System.Threading.Thread(() => Application.Run(new BookingForm()));
            bookingform.Start();
        }
    }
}
