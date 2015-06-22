namespace LokaleBookingSystem
{
    partial class BookingOversigtForm
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nyBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigerBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 262);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyBookingToolStripMenuItem,
            this.redigerBookingToolStripMenuItem,
            this.sletBookingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nyBookingToolStripMenuItem
            // 
            this.nyBookingToolStripMenuItem.Name = "nyBookingToolStripMenuItem";
            this.nyBookingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nyBookingToolStripMenuItem.Text = "Ny Booking";
            this.nyBookingToolStripMenuItem.Click += new System.EventHandler(this.nyBookingToolStripMenuItem_Click);
            // 
            // redigerBookingToolStripMenuItem
            // 
            this.redigerBookingToolStripMenuItem.Name = "redigerBookingToolStripMenuItem";
            this.redigerBookingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.redigerBookingToolStripMenuItem.Text = "Rediger Booking";
            this.redigerBookingToolStripMenuItem.Click += new System.EventHandler(this.redigerBookingToolStripMenuItem_Click);
            // 
            // sletBookingToolStripMenuItem
            // 
            this.sletBookingToolStripMenuItem.Name = "sletBookingToolStripMenuItem";
            this.sletBookingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sletBookingToolStripMenuItem.Text = "Slet Booking";
            this.sletBookingToolStripMenuItem.Click += new System.EventHandler(this.sletBookingToolStripMenuItem_Click);
            // 
            // BookingOversigtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.listView1);
            this.Name = "BookingOversigtForm";
            this.Text = "BookingOversigtForm";
            this.Load += new System.EventHandler(this.BookingOversigtForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redigerBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyBookingToolStripMenuItem;
    }
}