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
    public partial class LokaleRedigeringsForm : Form
    {
        public LokaleRedigeringsForm()
        {
            InitializeComponent();
        }
        
        

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Lokale lokale = new Lokale() { LokaleNavn = txtBx_Opret.Text };
                ctx.Lokaler.Add(lokale);
                ctx.SaveChanges();
            }
            txtBx_Opret.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Lokale lokale = ctx.Lokaler.Where(b => b.LokaleNavn == txtBx_Slet.Text).First();
                ctx.Lokaler.Remove(lokale);
                ctx.SaveChanges();
            }
            txtBx_Slet.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                Lokale lokale = (from s in ctx.Lokaler
                                 where s.LokaleNavn == txtBx_RedigerCurrent.Text
                                 select s).FirstOrDefault();
                lokale.LokaleNavn = txtBx_RedigerNyt.Text;
                ctx.SaveChanges();
            }
            txtBx_RedigerCurrent.Clear();
            txtBx_RedigerNyt.Clear();
        }

    }
}
