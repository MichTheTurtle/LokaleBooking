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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string Username { get; set; }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            System.Threading.Thread registerform = new System.Threading.Thread(() => Application.Run(new RegisterForm()));
            registerform.Start();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            using (var ctx = new Context())
            {
                if (ctx.Brugere.Any(o => o.Username == txtBx_BrugerNavn.Text))
                {

                    Bruger bruger = (from s in ctx.Brugere
                                     where s.Username == txtBx_BrugerNavn.Text
                                     select s).FirstOrDefault();

                    if (bruger.Password == txtBx_Password.Text)
                    {
                        if (bruger.Rettidhed == "Admin")
                        {
                            System.Threading.Thread adminform = new System.Threading.Thread(() => Application.Run(new AdminForm()));
                            adminform.Start();
                            Username = bruger.Username;
                            this.Close();
                        }
                        else
                        {
                            System.Threading.Thread lokaleform = new System.Threading.Thread(() => Application.Run(new LokaleRedigeringsForm()));
                            lokaleform.Start();
                            Username = bruger.Username;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
