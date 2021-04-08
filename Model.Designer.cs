
namespace WF
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.modelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelStatusStrip = new System.Windows.Forms.StatusStrip();
            this.modelToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.modelMenuStrip.SuspendLayout();
            this.modelToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelMenuStrip
            // 
            this.modelMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.modelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.modelMenuStrip.Name = "modelMenuStrip";
            this.modelMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.modelMenuStrip.TabIndex = 0;
            this.modelMenuStrip.Text = "modelMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // modelStatusStrip
            // 
            this.modelStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.modelStatusStrip.Name = "modelStatusStrip";
            this.modelStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.modelStatusStrip.TabIndex = 1;
            this.modelStatusStrip.Text = "statusStrip1";
            // 
            // modelToolStrip
            // 
            this.modelToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.ExitButton});
            this.modelToolStrip.Location = new System.Drawing.Point(0, 28);
            this.modelToolStrip.Name = "modelToolStrip";
            this.modelToolStrip.Size = new System.Drawing.Size(800, 27);
            this.modelToolStrip.TabIndex = 2;
            this.modelToolStrip.Text = "toolStrip1";
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(63, 24);
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(57, 24);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modelToolStrip);
            this.Controls.Add(this.modelStatusStrip);
            this.Controls.Add(this.modelMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.modelMenuStrip;
            this.Name = "Model";
            this.Text = "Model";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Model_FormClosing);
            this.modelMenuStrip.ResumeLayout(false);
            this.modelMenuStrip.PerformLayout();
            this.modelToolStrip.ResumeLayout(false);
            this.modelToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip modelMenuStrip;
        public System.Windows.Forms.StatusStrip modelStatusStrip;
        public System.Windows.Forms.ToolStrip modelToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}