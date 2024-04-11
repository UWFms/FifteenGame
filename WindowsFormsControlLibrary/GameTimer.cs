using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class GameTimer : UserControl
    {
        public GameTimer()
        {
            InitializeComponent();
        }
        public void Start()
        {
            display.Text = "00:00:00";
        }
        public void StartGame()
        {
            display.Text = "00:00:00";
            timer.Enabled = true;
            date = new DateTime(0, 0);
        }
        public void Stop()
        {
            timer.Enabled = false;
            display.Text = "00:00:00";
        }
        DateTime date;
        private void timer_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            display.Text = date.ToString("HH:mm:ss");
        }

        public string GetTimer()
        {
            return display.Text;
        }
    }
}
