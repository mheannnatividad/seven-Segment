using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Segment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(DateTime.Now.ToString("ss").Substring(DateTime.Now.ToString("ss").Length-1));
            if (sec == 1)
            {
                button1sec.BackColor = System.Drawing.Color.Black;
                button4sec.BackColor = System.Drawing.Color.Black;
                button5sec.BackColor = System.Drawing.Color.Black;
                button6sec.BackColor = System.Drawing.Color.Black;
                button2sec.PerformClick();
                button3sec.PerformClick();
            }
            if (sec == 2)
            {
                button3sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button2sec.PerformClick();
                button7sec.PerformClick();
                button5sec.PerformClick();
                button4sec.PerformClick();
            }
            if (sec == 3)
            {
                button5sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button2sec.PerformClick();
                button7sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
            }
            if (sec == 4)
            {
                button1sec.BackColor = System.Drawing.Color.Black;
                button4sec.BackColor = System.Drawing.Color.Black;
                button6sec.PerformClick();
                button7sec.PerformClick();
                button2sec.PerformClick();
                button3sec.PerformClick();
            }
            if (sec == 5)
            {
                button2sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button6sec.PerformClick();
                button7sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
            }
            if (sec == 6)
            {
                button1sec.PerformClick();
                button6sec.PerformClick();
                button7sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
                button5sec.PerformClick();

            }
            if (sec == 7)
            {
                button6sec.BackColor = System.Drawing.Color.Black;
                button5sec.BackColor = System.Drawing.Color.Black;
                button7sec.BackColor = System.Drawing.Color.Black;
                button4sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button2sec.PerformClick();
                button3sec.PerformClick();
            }
            if (sec == 8)
            {
                button1sec.PerformClick();
                button6sec.PerformClick();
                button7sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
                button5sec.PerformClick();
                button2sec.PerformClick();
            }
            if (sec == 9)
            {
                button5sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button6sec.PerformClick();
                button7sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
                button2sec.PerformClick();

            }
            if (sec == 0)
            {
                button7sec.BackColor = System.Drawing.Color.Black;
                button1sec.PerformClick();
                button6sec.PerformClick();
                button3sec.PerformClick();
                button4sec.PerformClick();
                button5sec.PerformClick();
                button2sec.PerformClick();
            }

            int sec1 = Convert.ToInt32(DateTime.Now.ToString("ss").Substring(0, 1));

            if (sec1 == 1)
            {
                button8sec.BackColor = System.Drawing.Color.Black;
                button11sec.BackColor = System.Drawing.Color.Black;
                button12sec.BackColor = System.Drawing.Color.Black;
                button13sec.BackColor = System.Drawing.Color.Black;
                button9sec.PerformClick();
                button10sec.PerformClick();
            }
            if (sec1 == 2)
            {
                button10sec.BackColor = System.Drawing.Color.Black;
                button8sec.PerformClick();
                button9sec.PerformClick();
                button14sec.PerformClick();
                button12sec.PerformClick();
                button11sec.PerformClick();
            }
            if (sec1 == 3)
            {
                button12sec.BackColor = System.Drawing.Color.Black;
                button8sec.PerformClick();
                button9sec.PerformClick();
                button14sec.PerformClick();
                button10sec.PerformClick();
                button11sec.PerformClick();
            }
            if (sec1 == 4)
            {
                button8sec.BackColor = System.Drawing.Color.Black;
                button11sec.BackColor = System.Drawing.Color.Black;
                button13sec.PerformClick();
                button14sec.PerformClick();
                button9sec.PerformClick();
                button10sec.PerformClick();
            }
            if (sec1 == 5)
            {
                button9sec.BackColor = System.Drawing.Color.Black;
                button8sec.PerformClick();
                button13sec.PerformClick();
                button14sec.PerformClick();
                button10sec.PerformClick();
                button11sec.PerformClick();
            }
            if (sec1 == 0)
            {
                button14sec.BackColor = System.Drawing.Color.Black;
                button8sec.PerformClick();
                button13sec.PerformClick();
                button10sec.PerformClick();
                button11sec.PerformClick();
                button12sec.PerformClick();
                button9sec.PerformClick();
            }



        }

        private void all(object sender, EventArgs e)
        {
            Button all = (Button)sender;
            all.BackColor = System.Drawing.Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
