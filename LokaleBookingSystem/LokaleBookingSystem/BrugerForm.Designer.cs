namespace LokaleBookingSystem
{
    partial class BrugerForm
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
            this.btn_Rediger_Booking = new System.Windows.Forms.Button();
            this.grp_Lokale = new System.Windows.Forms.GroupBox();
            this.btn_View_Lokale = new System.Windows.Forms.Button();
            this.grp_Booking = new System.Windows.Forms.GroupBox();
            this.btn_Booking_View = new System.Windows.Forms.Button();
            this.grp_Lokale.SuspendLayout();
            this.grp_Booking.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Rediger_Booking
            // 
            this.btn_Rediger_Booking.Location = new System.Drawing.Point(8, 19);
            this.btn_Rediger_Booking.Name = "btn_Rediger_Booking";
            this.btn_Rediger_Booking.Size = new System.Drawing.Size(93, 23);
            this.btn_Rediger_Booking.TabIndex = 1;
            this.btn_Rediger_Booking.Text = "Lav booking";
            this.btn_Rediger_Booking.UseVisualStyleBackColor = true;
            this.btn_Rediger_Booking.Click += new System.EventHandler(this.btn_Rediger_Booking_Click);
            // 
            // grp_Lokale
            // 
            this.grp_Lokale.Controls.Add(this.btn_View_Lokale);
            this.grp_Lokale.Location = new System.Drawing.Point(12, 12);
            this.grp_Lokale.Name = "grp_Lokale";
            this.grp_Lokale.Size = new System.Drawing.Size(124, 113);
            this.grp_Lokale.TabIndex = 6;
            this.grp_Lokale.TabStop = false;
            this.grp_Lokale.Text = "Lokale";
            // 
            // btn_View_Lokale
            // 
            this.btn_View_Lokale.Location = new System.Drawing.Point(6, 60);
            this.btn_View_Lokale.Name = "btn_View_Lokale";
            this.btn_View_Lokale.Size = new System.Drawing.Size(93, 23);
            this.btn_View_Lokale.TabIndex = 4;
            this.btn_View_Lokale.Text = "Se lokaler";
            this.btn_View_Lokale.UseVisualStyleBackColor = true;
            this.btn_View_Lokale.Click += new System.EventHandler(this.btn_View_Lokale_Click);
            // 
            // grp_Booking
            // 
            this.grp_Booking.Controls.Add(this.btn_Booking_View);
            this.grp_Booking.Controls.Add(this.btn_Rediger_Booking);
            this.grp_Booking.Location = new System.Drawing.Point(148, 12);
            this.grp_Booking.Name = "grp_Booking";
            this.grp_Booking.Size = new System.Drawing.Size(124, 113);
            this.grp_Booking.TabIndex = 4;
            this.grp_Booking.TabStop = false;
            this.grp_Booking.Text = "Booking";
            // 
            // btn_Booking_View
            // 
            this.btn_Booking_View.Location = new System.Drawing.Point(8, 60);
            this.btn_Booking_View.Name = "btn_Booking_View";
            this.btn_Booking_View.Size = new System.Drawing.Size(93, 23);
            this.btn_Booking_View.TabIndex = 5;
            this.btn_Booking_View.Text = "Se liste";
            this.btn_Booking_View.UseVisualStyleBackColor = true;
            this.btn_Booking_View.Click += new System.EventHandler(this.btn_Booking_View_Click);
            // 
            // BrugerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grp_Lokale);
            this.Controls.Add(this.grp_Booking);
            this.Name = "BrugerForm";
            this.Text = "BrugerForm";
            this.grp_Lokale.ResumeLayout(false);
            this.grp_Booking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rediger_Booking;
        private System.Windows.Forms.GroupBox grp_Lokale;
        private System.Windows.Forms.Button btn_View_Lokale;
        private System.Windows.Forms.GroupBox grp_Booking;
        private System.Windows.Forms.Button btn_Booking_View;

    }
}