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
            /*
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Navn", 120);

            //Add items in the listview
            string[] arr = new string[3];
            ListViewItem itm;



            using (var ctx = new Context())
            {
                var lokaler = from b in ctx.Lokaler select b;

                foreach (var lokale in lokaler)
                {
                    //Console.WriteLine(lokale.LokaleNavn);
                    //listView1.Items.Add(lokale.LokaleNavn);

                    //Add first item
                    arr[0] = lokale.LokaleID.ToString();
                    arr[1] = lokale.LokaleNavn;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);


                }
            }
             */
        }

        private void btn_Rediger_Booking_Click(object sender, EventArgs e)
        {

        }

        private void btn_Booking_View_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rediger_Bruger_Click(object sender, EventArgs e)
        {
            System.Threading.Thread registerform = new System.Threading.Thread(() => Application.Run(new RegisterForm()));
            registerform.Start();
            this.Close();
        }

        private void btn_Bruger_View_Click(object sender, EventArgs e)
        {

        }
    }
}
