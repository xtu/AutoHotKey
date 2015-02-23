using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AutoHotKey.Properties;

namespace AutoHotKey
{
    public partial class AutoHotKeyForm : Form
    {
        private bool _turnedOn;
        private string _keys;

        public AutoHotKeyForm()
        {
            InitializeComponent();
        }

        private bool TurnSwitch()
        {
            if (_turnedOn)  // stop it
            {
                btnSwitch.Text = Resources.Str_Start;
                txtInterval.Enabled = true;
                txtKey.Enabled = true;
                _turnedOn = false;
                timer1.Enabled = false;
                return true;
            }
            else  // start it
            {
                int interval;
                if (!Int32.TryParse(txtInterval.Text, out interval))
                {
                    MessageBox.Show(Resources.Err_InvalidInterval, Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                timer1.Interval = interval;
                _keys = txtKey.Text;

                btnSwitch.Text = Resources.Str_Stop;
                txtInterval.Enabled = false;
                txtKey.Enabled = false;
                _turnedOn = true;
                timer1.Enabled = true;
                return true;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_keys))
                SendKeys.Send(_keys);
        }

        private void lnkHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.xiaomingtu.com/?ref=AutoHotKey");
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }

        private void ctxTrayIcon_Opening(object sender, CancelEventArgs e)
        {
            mnuStart.Checked = _turnedOn;
            mnuStop.Checked = !_turnedOn;

            mnuStart.Enabled = !_turnedOn;
            mnuStop.Enabled = _turnedOn;
        }

        private void AutoHotKeyForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                Hide();
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void mnuRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
