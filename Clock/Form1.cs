using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hhmm.Text = DateTime.Now.ToString("HH:mm");
            ss.Text = DateTime.Now.ToString("ss");
            date.Text = DateTime.Now.ToString("MMM dd yyyy");
            day.Text = DateTime.Now.ToString("dddd");
        }
    }
}
