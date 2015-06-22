namespace LokaleBookingSystem
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_Fornavn = new System.Windows.Forms.TextBox();
            this.txtBx_Efternavn = new System.Windows.Forms.TextBox();
            this.txtBx_Mail = new System.Windows.Forms.TextBox();
            this.txtBx_Username = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back_to_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornavn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternavn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // txtBx_Fornavn
            // 
            this.txtBx_Fornavn.Location = new System.Drawing.Point(78, 6);
            this.txtBx_Fornavn.Name = "txtBx_Fornavn";
            this.txtBx_Fornavn.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Fornavn.TabIndex = 5;
            // 
            // txtBx_Efternavn
            // 
            this.txtBx_Efternavn.Location = new System.Drawing.Point(78, 32);
            this.txtBx_Efternavn.Name = "txtBx_Efternavn";
            this.txtBx_Efternavn.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Efternavn.TabIndex = 6;
            // 
            // txtBx_Mail
            // 
            this.txtBx_Mail.Location = new System.Drawing.Point(78, 58);
            this.txtBx_Mail.Name = "txtBx_Mail";
            this.txtBx_Mail.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Mail.TabIndex = 7;
            // 
            // txtBx_Username
            // 
            this.txtBx_Username.Location = new System.Drawing.Point(78, 84);
            this.txtBx_Username.Name = "txtBx_Username";
            this.txtBx_Username.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Username.TabIndex = 8;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(78, 110);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Password.TabIndex = 9;
            this.txtBx_Password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back_to_login
            // 
            this.btn_back_to_login.Location = new System.Drawing.Point(15, 136);
            this.btn_back_to_login.Name = "btn_back_to_login";
            this.btn_back_to_login.Size = new System.Drawing.Size(75, 23);
            this.btn_back_to_login.TabIndex = 11;
            this.btn_back_to_login.Text = "Tilbage";
            this.btn_back_to_login.UseVisualStyleBackColor = true;
            this.btn_back_to_login.Click += new System.EventHandler(this.btn_back_to_login_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 166);
            this.Controls.Add(this.btn_back_to_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.txtBx_Username);
            this.Controls.Add(this.txtBx_Mail);
            this.Controls.Add(this.txtBx_Efternavn);
            this.Controls.Add(this.txtBx_Fornavn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_Fornavn;
        private System.Windows.Forms.TextBox txtBx_Efternavn;
        private System.Windows.Forms.TextBox txtBx_Mail;
        private System.Windows.Forms.TextBox txtBx_Username;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back_to_login;
    }
}