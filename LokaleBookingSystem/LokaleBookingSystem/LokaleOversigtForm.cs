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
    public partial class LokaleOversigtForm : Form
    {
        public LokaleOversigtForm()
        {
            InitializeComponent();
        }

        private void LokaleOversigt_Load(object sender, EventArgs e)
        {
            
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Navn", 120);

            listView1.FullRowSelect = true;

            //Add items in the listview
            string[] arr = new string[2];
            ListViewItem itm;



            using (var ctx = new Context())
            {
                var lokaler = from b in ctx.Lokaler select b;

                foreach (var lokale in lokaler)
                {

                    arr[0] = lokale.LokaleID.ToString();
                    arr[1] = lokale.LokaleNavn;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }
            }
        }
    }
}
