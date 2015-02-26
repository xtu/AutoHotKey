namespace AutoHotKey
{
    partial class AutoHotKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoHotKeyForm));
            this.btnSwitch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkHomePage = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            resources.ApplyResources(this.btnSwitch, "btnSwitch");
            this.btnSwitch.Name = "btnSwitch";
            this.tableLayoutPanel1.SetRowSpan(this.btnSwitch, 2);
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtKey
            // 
            resources.ApplyResources(this.txtKey, "txtKey");
            this.txtKey.Name = "txtKey";
            // 
            // txtInterval
            // 
            resources.ApplyResources(this.txtInterval, "txtInterval");
            this.txtInterval.Name = "txtInterval";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSwitch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInterval, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lnkHomePage
            // 
            resources.ApplyResources(this.lnkHomePage, "lnkHomePage");
            this.lnkHomePage.Name = "lnkHomePage";
            this.lnkHomePage.TabStop = true;
            this.lnkHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHomePage_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.ctxTrayIcon;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ctxTrayIcon
            // 
            resources.ApplyResources(this.ctxTrayIcon, "ctxTrayIcon");
            this.ctxTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRestore,
            this.toolStripSeparator2,
            this.mnuStart,
            this.mnuStop,
            this.toolStripSeparator1,
            this.mnuExit});
            this.ctxTrayIcon.Name = "ctxTrayIcon";
            this.ctxTrayIcon.Opening += new System.ComponentModel.CancelEventHandler(this.ctxTrayIcon_Opening);
            // 
            // mnuRestore
            // 
            resources.ApplyResources(this.mnuRestore, "mnuRestore");
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // mnuStart
            // 
            resources.ApplyResources(this.mnuStart, "mnuStart");
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            resources.ApplyResources(this.mnuStop, "mnuStop");
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mnuExit
            // 
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // AutoHotKeyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkHomePage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoHotKeyForm";
            this.Resize += new System.EventHandler(this.AutoHotKeyForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ctxTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkHomePage;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctxTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

