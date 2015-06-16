namespace LokaleBookingSystem
{
    partial class BookingRedigeringsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_Lokale = new System.Windows.Forms.TextBox();
            this.btn_RedigerBooking = new System.Windows.Forms.Button();
            this.slutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Slet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lokale:";
            // 
            // txtBx_Lokale
            // 
            this.txtBx_Lokale.Location = new System.Drawing.Point(112, 55);
            this.txtBx_Lokale.Name = "txtBx_Lokale";
            this.txtBx_Lokale.Size = new System.Drawing.Size(142, 20);
            this.txtBx_Lokale.TabIndex = 12;
            // 
            // btn_RedigerBooking
            // 
            this.btn_RedigerBooking.Location = new System.Drawing.Point(15, 113);
            this.btn_RedigerBooking.Name = "btn_RedigerBooking";
            this.btn_RedigerBooking.Size = new System.Drawing.Size(75, 23);
            this.btn_RedigerBooking.TabIndex = 11;
            this.btn_RedigerBooking.Text = "Rediger";
            this.btn_RedigerBooking.UseVisualStyleBackColor = true;
            this.btn_RedigerBooking.Click += new System.EventHandler(this.btn_RedigerBooking_Click);
            // 
            // slutDateTimePicker
            // 
            this.slutDateTimePicker.Location = new System.Drawing.Point(112, 27);
            this.slutDateTimePicker.Name = "slutDateTimePicker";
            this.slutDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.slutDateTimePicker.TabIndex = 10;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(112, 3);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.startDateTimePicker.TabIndex = 9;
            this.startDateTimePicker.Value = new System.DateTime(2015, 6, 15, 11, 5, 18, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Slut Tidspunkt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Tidspunkt:";
            // 
            // btn_Slet
            // 
            this.btn_Slet.Location = new System.Drawing.Point(181, 113);
            this.btn_Slet.Name = "btn_Slet";
            this.btn_Slet.Size = new System.Drawing.Size(75, 23);
            this.btn_Slet.TabIndex = 14;
            this.btn_Slet.Text = "Slet";
            this.btn_Slet.UseVisualStyleBackColor = true;
            this.btn_Slet.Click += new System.EventHandler(this.btn_Slet_Click);
            // 
            // BookingRedigeringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 148);
            this.Controls.Add(this.btn_Slet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_Lokale);
            this.Controls.Add(this.btn_RedigerBooking);
            this.Controls.Add(this.slutDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingRedigeringsForm";
            this.Text = "BookingRedigeringsForm";
            this.Load += new System.EventHandler(this.BookingRedigeringsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_Lokale;
        private System.Windows.Forms.Button btn_RedigerBooking;
        private System.Windows.Forms.DateTimePicker slutDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Slet;

    }
}