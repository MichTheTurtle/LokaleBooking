namespace LokaleBookingSystem
{
    partial class BrugerOversigtForm
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
            this.contextRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sletBrugerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.givAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextRightClick;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 262);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextRightClick
            // 
            this.contextRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.givAdminToolStripMenuItem,
            this.sletBrugerToolStripMenuItem});
            this.contextRightClick.Name = "contextRightClick";
            this.contextRightClick.Size = new System.Drawing.Size(153, 70);
            this.contextRightClick.Opening += new System.ComponentModel.CancelEventHandler(this.contextRightClick_Opening);
            // 
            // sletBrugerToolStripMenuItem
            // 
            this.sletBrugerToolStripMenuItem.Name = "sletBrugerToolStripMenuItem";
            this.sletBrugerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sletBrugerToolStripMenuItem.Text = "Slet Bruger";
            this.sletBrugerToolStripMenuItem.Click += new System.EventHandler(this.sletBrugerToolStripMenuItem_Click);
            // 
            // givAdminToolStripMenuItem
            // 
            this.givAdminToolStripMenuItem.Name = "givAdminToolStripMenuItem";
            this.givAdminToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.givAdminToolStripMenuItem.Text = "Giv Admin";
            this.givAdminToolStripMenuItem.Click += new System.EventHandler(this.givAdminToolStripMenuItem_Click);
            // 
            // BrugerOversigtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 262);
            this.Controls.Add(this.listView1);
            this.Name = "BrugerOversigtForm";
            this.Text = "BrugerOversigtForm";
            this.Load += new System.EventHandler(this.BrugerOversigtForm_Load);
            this.contextRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextRightClick;
        private System.Windows.Forms.ToolStripMenuItem sletBrugerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem givAdminToolStripMenuItem;
    }
}