namespace LokaleBookingSystem
{
    partial class AdminForm
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
            this.btn_Rediger_Lokale = new System.Windows.Forms.Button();
            this.btn_Rediger_Booking = new System.Windows.Forms.Button();
            this.grp_Lokale = new System.Windows.Forms.GroupBox();
            this.btn_View_Lokale = new System.Windows.Forms.Button();
            this.grp_Booking = new System.Windows.Forms.GroupBox();
            this.btn_export_xml = new System.Windows.Forms.Button();
            this.grp_Bruger = new System.Windows.Forms.GroupBox();
            this.btn_Bruger_View = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.grp_Lokale.SuspendLayout();
            this.grp_Booking.SuspendLayout();
            this.grp_Bruger.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Rediger_Lokale
            // 
            this.btn_Rediger_Lokale.Location = new System.Drawing.Point(6, 19);
            this.btn_Rediger_Lokale.Name = "btn_Rediger_Lokale";
            this.btn_Rediger_Lokale.Size = new System.Drawing.Size(93, 23);
            this.btn_Rediger_Lokale.TabIndex = 0;
            this.btn_Rediger_Lokale.Text = "Rediger";
            this.btn_Rediger_Lokale.UseVisualStyleBackColor = true;
            this.btn_Rediger_Lokale.Click += new System.EventHandler(this.btn_Rediger_Lokale_Click);
            // 
            // btn_Rediger_Booking
            // 
            this.btn_Rediger_Booking.Location = new System.Drawing.Point(8, 19);
            this.btn_Rediger_Booking.Name = "btn_Rediger_Booking";
            this.btn_Rediger_Booking.Size = new System.Drawing.Size(93, 23);
            this.btn_Rediger_Booking.TabIndex = 1;
            this.btn_Rediger_Booking.Text = "Se liste";
            this.btn_Rediger_Booking.UseVisualStyleBackColor = true;
            this.btn_Rediger_Booking.Click += new System.EventHandler(this.btn_Rediger_Booking_Click);
            // 
            // grp_Lokale
            // 
            this.grp_Lokale.Controls.Add(this.btn_View_Lokale);
            this.grp_Lokale.Controls.Add(this.btn_Rediger_Lokale);
            this.grp_Lokale.Location = new System.Drawing.Point(12, 12);
            this.grp_Lokale.Name = "grp_Lokale";
            this.grp_Lokale.Size = new System.Drawing.Size(124, 113);
            this.grp_Lokale.TabIndex = 3;
            this.grp_Lokale.TabStop = false;
            this.grp_Lokale.Text = "Lokale";
            // 
            // btn_View_Lokale
            // 
            this.btn_View_Lokale.Location = new System.Drawing.Point(6, 60);
            this.btn_View_Lokale.Name = "btn_View_Lokale";
            this.btn_View_Lokale.Size = new System.Drawing.Size(93, 23);
            this.btn_View_Lokale.TabIndex = 4;
            this.btn_View_Lokale.Text = "Se liste";
            this.btn_View_Lokale.UseVisualStyleBackColor = true;
            this.btn_View_Lokale.Click += new System.EventHandler(this.btn_View_Lokale_Click);
            // 
            // grp_Booking
            // 
            this.grp_Booking.Controls.Add(this.btn_export_xml);
            this.grp_Booking.Controls.Add(this.btn_Rediger_Booking);
            this.grp_Booking.Location = new System.Drawing.Point(148, 12);
            this.grp_Booking.Name = "grp_Booking";
            this.grp_Booking.Size = new System.Drawing.Size(124, 113);
            this.grp_Booking.TabIndex = 1;
            this.grp_Booking.TabStop = false;
            this.grp_Booking.Text = "Booking";
            // 
            // btn_export_xml
            // 
            this.btn_export_xml.Location = new System.Drawing.Point(8, 60);
            this.btn_export_xml.Name = "btn_export_xml";
            this.btn_export_xml.Size = new System.Drawing.Size(93, 23);
            this.btn_export_xml.TabIndex = 2;
            this.btn_export_xml.Text = "Export to XML";
            this.btn_export_xml.UseVisualStyleBackColor = true;
            this.btn_export_xml.Click += new System.EventHandler(this.btn_export_xml_Click);
            // 
            // grp_Bruger
            // 
            this.grp_Bruger.Controls.Add(this.btn_Bruger_View);
            this.grp_Bruger.Location = new System.Drawing.Point(12, 137);
            this.grp_Bruger.Name = "grp_Bruger";
            this.grp_Bruger.Size = new System.Drawing.Size(124, 113);
            this.grp_Bruger.TabIndex = 2;
            this.grp_Bruger.TabStop = false;
            this.grp_Bruger.Text = "Bruger";
            // 
            // btn_Bruger_View
            // 
            this.btn_Bruger_View.Location = new System.Drawing.Point(6, 19);
            this.btn_Bruger_View.Name = "btn_Bruger_View";
            this.btn_Bruger_View.Size = new System.Drawing.Size(93, 23);
            this.btn_Bruger_View.TabIndex = 6;
            this.btn_Bruger_View.Text = "Rediger";
            this.btn_Bruger_View.UseVisualStyleBackColor = true;
            this.btn_Bruger_View.Click += new System.EventHandler(this.btn_Bruger_View_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Logout);
            this.groupBox1.Location = new System.Drawing.Point(148, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(8, 19);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(93, 23);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Log ud";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_Bruger);
            this.Controls.Add(this.grp_Booking);
            this.Controls.Add(this.grp_Lokale);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.grp_Lokale.ResumeLayout(false);
            this.grp_Booking.ResumeLayout(false);
            this.grp_Bruger.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rediger_Lokale;
        private System.Windows.Forms.Button btn_Rediger_Booking;
        private System.Windows.Forms.GroupBox grp_Lokale;
        private System.Windows.Forms.GroupBox grp_Booking;
        private System.Windows.Forms.Button btn_View_Lokale;
        private System.Windows.Forms.GroupBox grp_Bruger;
        private System.Windows.Forms.Button btn_Bruger_View;
        private System.Windows.Forms.Button btn_export_xml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Logout;
    }
}