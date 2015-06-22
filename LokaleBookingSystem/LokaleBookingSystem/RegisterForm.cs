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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context(Properties.Settings.Default.sqlDB))
            {
                if (!ctx.Brugere.Any(o => o.Username == txtBx_Username.Text))
                {
                    Bruger bruger = new Bruger() { Fornavn = txtBx_Fornavn.Text, Efternavn = txtBx_Efternavn.Text, Mail = txtBx_Mail.Text, Username = txtBx_Username.Text, Password = txtBx_Password.Text, Rettidhed = "Bruger" };
                    ctx.Brugere.Add(bruger);
                    ctx.SaveChanges();

                    System.Threading.Thread loginform = new System.Threading.Thread(() => Application.Run(new LoginForm()));
                    loginform.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already used!");
                    
                }
            }
        }
    }
}
