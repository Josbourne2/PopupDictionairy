﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popup_Dictionairy
{
    public partial class DictionairyForm : Form
    {
        int interval;

        public DictionairyForm()
        {
            interval = SettingsManager.Current.QuestionIntervalSeconds;            
            InitializeComponent();
        }

        private void DictionairyForm_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Popup Dictionairy";
            notifyIcon1.BalloonTipText = String.Format("The program will popup every {0} seconds. Click here if you want to be asked extra questions.",interval.ToString());

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       
    }
}
