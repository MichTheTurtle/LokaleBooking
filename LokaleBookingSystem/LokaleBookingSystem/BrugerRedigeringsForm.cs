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
    public partial class BrugerRedigeringsForm : Form
    {

        private int brugerID;
        public int BrugerID { get; set; }

        private string fornavn;
        public string Fornavn { get; set; }

        private string efternavn;
        public string Efternavn { get; set; }

        private string mail;
        public string Mail { get; set; }

        private string username;
        public string Username { get; set; }

        private string password;
        public string Password { get; set; }

        private string rettighed;
        public string Rettighed { get; set; }

        public BrugerRedigeringsForm(int brugerID,string fornavn,string efternavn,string mail,string username,string password,string rettighed)
        {
            InitializeComponent();

            this.brugerID = brugerID;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.mail = mail;
            this.username = username;
            this.password = password;
            this.rettighed = rettighed;
        }

        private void btn_Slet_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rediger_Click(object sender, EventArgs e)
        {
            System.Threading.Thread brugeroversigtform = new System.Threading.Thread(() => Application.Run(new BrugerOversigtForm()));
            brugeroversigtform.Start();
            this.Close();
        }
    }
}
