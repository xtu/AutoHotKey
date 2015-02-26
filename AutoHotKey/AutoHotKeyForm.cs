using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AutoHotKey.Properties;

namespace AutoHotKey
{
    /// <summary>
    /// The main form for this tool.
    /// </summary>
    public partial class AutoHotKeyForm : Form
    {
        /// <summary>
        /// The state of the switch.
        /// </summary>
        private bool _turnedOn;
        /// <summary>
        /// The keys to send.
        /// </summary>
        private string _keys;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHotKeyForm"/> class.
        /// </summary>
        public AutoHotKeyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Turns the switch.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the switch is successfully turned, otherwise <c>false</c>.
        /// </returns>
        private bool TurnSwitch()
        {
            if (_turnedOn)  // stop it
            {
                btnSwitch.Text = AutoHotKeyResources.Str_Start;
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
                    MessageBox.Show(AutoHotKeyResources.Err_InvalidInterval, Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                timer1.Interval = interval;
                _keys = txtKey.Text;

                btnSwitch.Text = AutoHotKeyResources.Str_Stop;
                txtInterval.Enabled = false;
                txtKey.Enabled = false;
                _turnedOn = true;
                timer1.Enabled = true;
                return true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSwitch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_keys))
                SendKeys.Send(_keys);
        }

        /// <summary>
        /// Handles the LinkClicked event of the lnkHomePage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void lnkHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.xiaomingtu.com/?ref=AutoHotKey");
        }

        /// <summary>
        /// Handles the Click event of the mnuStart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuStart_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            TurnSwitch();
        }

        /// <summary>
        /// Handles the Click event of the mnuExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }

        /// <summary>
        /// Handles the Opening event of the ctxTrayIcon control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void ctxTrayIcon_Opening(object sender, CancelEventArgs e)
        {
            mnuStart.Checked = _turnedOn;
            mnuStop.Checked = !_turnedOn;

            mnuStart.Enabled = !_turnedOn;
            mnuStop.Enabled = _turnedOn;
        }

        /// <summary>
        /// Handles the Resize event of the AutoHotKeyForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the mnuRestore control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the notifyIcon1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
