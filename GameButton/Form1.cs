using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countdownLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.countdownSound);
            player.Play();

            Refresh();
            Thread.Sleep(300);

            countdownLabel.Text = "Starting in 3...";

            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "Starting in 2...";

            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "Starting in 1...";

            Refresh();
            Thread.Sleep(1000);

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.endSound);
            player2.Play();

            this.BackColor = Color.Green;
            countdownLabel.ForeColor = Color.Black;
            countdownLabel.Text = "Go";

            Refresh();
            Thread.Sleep(10000);

            startButton.Visible = true;
            this.BackColor = Color.Black;
            countdownLabel.Text = "Ready"
            countdownLabel.ForeColor = Color.Lime;
        }
    }
}