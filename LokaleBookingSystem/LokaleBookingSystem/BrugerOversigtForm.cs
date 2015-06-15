using Model;
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
    public partial class BrugerOversigtForm : Form
    {
        public BrugerOversigtForm()
        {
            InitializeComponent();
        }

        private void BrugerOversigtForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 30);
            listView1.Columns.Add("Fornavn", 90);
            listView1.Columns.Add("Efternavn", 90);
            listView1.Columns.Add("Mail", 100);
            listView1.Columns.Add("Username", 90);
            listView1.Columns.Add("Rettighed", 60);

            listView1.FullRowSelect = true;

            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;



            using (var ctx = new Context())
            {
                var brugere = from b in ctx.Brugere select b;

                foreach (var bruger in brugere)
                {
                    

                    arr[0] = bruger.BrugerID.ToString();
                    arr[1] = bruger.Fornavn;
                    arr[2] = bruger.Efternavn;
                    arr[3] = bruger.Mail;
                    arr[4] = bruger.Username;
                    arr[5] = bruger.Rettidhed;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }
            }
        }
    }
}
