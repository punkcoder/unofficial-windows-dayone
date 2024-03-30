namespace DayOneApp
{
    partial class frmDayOne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayOne));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            vwMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vwMain).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            reloadToolStripMenuItem.Size = new Size(139, 26);
            reloadToolStripMenuItem.Text = "&Reload";
            reloadToolStripMenuItem.Click += reloadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // vwMain
            // 
            vwMain.AllowExternalDrop = true;
            vwMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vwMain.CreationProperties = null;
            vwMain.DefaultBackgroundColor = Color.White;
            vwMain.Location = new Point(0, 31);
            vwMain.Name = "vwMain";
            vwMain.Size = new Size(800, 418);
            vwMain.TabIndex = 1;
            vwMain.ZoomFactor = 1D;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "tryNotifier";
            notifyIcon1.Visible = true;
            notifyIcon1.Click += notifyIcon1_Click;
            // 
            // frmDayOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vwMain);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmDayOne";
            Text = "(Unofficial) OneDay App";
            FormClosing += frmDayOne_FormClosing;
            Load += frmDayOne_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vwMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 vwMain;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}
