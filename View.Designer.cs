
namespace WF
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.viewStatusStrip = new System.Windows.Forms.StatusStrip();
            this.viewMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddSong = new System.Windows.Forms.ToolStripButton();
            this.EditSong = new System.Windows.Forms.ToolStripButton();
            this.DeleteSong = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.viewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.viewMenuStrip.SuspendLayout();
            this.viewToolStrip.SuspendLayout();
            this.viewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.viewStatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 367);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.viewMenuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.viewToolStrip);
            // 
            // viewStatusStrip
            // 
            this.viewStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.viewStatusStrip.Name = "viewStatusStrip";
            this.viewStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.viewStatusStrip.TabIndex = 1;
            this.viewStatusStrip.Text = "viewStatusStrip";
            // 
            // viewMenuStrip
            // 
            this.viewMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.viewMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.viewMenuStrip.Name = "viewMenuStrip";
            this.viewMenuStrip.Size = new System.Drawing.Size(800, 30);
            this.viewMenuStrip.TabIndex = 0;
            this.viewMenuStrip.Text = "viewMenuStrip";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.addToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStrip
            // 
            this.viewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSong,
            this.EditSong,
            this.DeleteSong,
            this.toolStripComboBox1});
            this.viewToolStrip.Location = new System.Drawing.Point(4, 30);
            this.viewToolStrip.Name = "viewToolStrip";
            this.viewToolStrip.Size = new System.Drawing.Size(374, 31);
            this.viewToolStrip.TabIndex = 1;
            this.viewToolStrip.Text = "viewToolStrip";
            this.viewToolStrip.Visible = false;
            // 
            // AddSong
            // 
            this.AddSong.Image = ((System.Drawing.Image)(resources.GetObject("AddSong.Image")));
            this.AddSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSong.Name = "AddSong";
            this.AddSong.Size = new System.Drawing.Size(61, 28);
            this.AddSong.Text = "Add";
            this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
            // 
            // EditSong
            // 
            this.EditSong.Image = ((System.Drawing.Image)(resources.GetObject("EditSong.Image")));
            this.EditSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSong.Name = "EditSong";
            this.EditSong.Size = new System.Drawing.Size(59, 28);
            this.EditSong.Text = "Edit";
            // 
            // DeleteSong
            // 
            this.DeleteSong.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSong.Image")));
            this.DeleteSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSong.Name = "DeleteSong";
            this.DeleteSong.Size = new System.Drawing.Size(77, 28);
            this.DeleteSong.Text = "Delete";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            // 
            // viewContextMenuStrip
            // 
            this.viewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.viewContextMenuStrip.Name = "viewContextMenuStrip";
            this.viewContextMenuStrip.Size = new System.Drawing.Size(123, 76);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.viewMenuStrip;
            this.Name = "View";
            this.Text = "View";
            this.Activated += new System.EventHandler(this.View_Activated);
            this.Deactivate += new System.EventHandler(this.View_Deactivate);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.viewMenuStrip.ResumeLayout(false);
            this.viewMenuStrip.PerformLayout();
            this.viewToolStrip.ResumeLayout(false);
            this.viewToolStrip.PerformLayout();
            this.viewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip viewStatusStrip;
        private System.Windows.Forms.MenuStrip viewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStrip viewToolStrip;
        private System.Windows.Forms.ToolStripButton AddSong;
        private System.Windows.Forms.ToolStripButton EditSong;
        private System.Windows.Forms.ToolStripButton DeleteSong;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip viewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}