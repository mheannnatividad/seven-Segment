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

            int mns = Convert.ToInt32(DateTime.Now.ToString("mm").Substring(DateTime.Now.ToString("mm").Length - 1));

            if (mns == 1)
            {
                button15mns.BackColor = System.Drawing.Color.Black;
                button18mns.BackColor = System.Drawing.Color.Black;
                button19mns.BackColor = System.Drawing.Color.Black;
                button20mns.BackColor = System.Drawing.Color.Black;
                button16mns.PerformClick();
                button17mns.PerformClick();
            }
            if (mns == 2)
            {
                button17mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button16mns.PerformClick();
                button21mns.PerformClick();
                button19mns.PerformClick();
                button18mns.PerformClick();
            }
            if (mns == 3)
            {
                button19mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button16mns.PerformClick();
                button21mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
            }
            if (mns == 4)
            {
                button15mns.BackColor = System.Drawing.Color.Black;
                button18mns.BackColor = System.Drawing.Color.Black;
                button20mns.PerformClick();
                button21mns.PerformClick();
                button16mns.PerformClick();
                button17mns.PerformClick();
            }
            if (mns == 5)
            {
                button16mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button20mns.PerformClick();
                button21mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
            }
            if (mns == 6)
            {
                button15mns.PerformClick();
                button20mns.PerformClick();
                button21mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
                button19mns.PerformClick();
            }
            if (mns == 7)
            {
                button20mns.BackColor = System.Drawing.Color.Black;
                button19mns.BackColor = System.Drawing.Color.Black;
                button21mns.BackColor = System.Drawing.Color.Black;
                button18mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button16mns.PerformClick();
                button17mns.PerformClick();
            }
            if (mns == 8)
            {
                button15mns.PerformClick();
                button20mns.PerformClick();
                button21mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
                button19mns.PerformClick();
                button16mns.PerformClick();
            }
            if (mns == 9)
            {
                button19mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button20mns.PerformClick();
                button21mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
                button16mns.PerformClick();
            }
            if (mns == 0)
            {
                button21mns.BackColor = System.Drawing.Color.Black;
                button15mns.PerformClick();
                button20mns.PerformClick();
                button17mns.PerformClick();
                button18mns.PerformClick();
                button19mns.PerformClick();
                button16mns.PerformClick();
            }

            int mns1 = Convert.ToInt32(DateTime.Now.ToString("mm").Substring(0, 1));

            if (mns1 == 1)
            {
                button22mns.BackColor = System.Drawing.Color.Black;
                button25mns.BackColor = System.Drawing.Color.Black;
                button26mns.BackColor = System.Drawing.Color.Black;
                button27mns.BackColor = System.Drawing.Color.Black;
                button23mns.PerformClick();
                button24mns.PerformClick();
            }
            if (mns1 == 2)
            {
                button24mns.BackColor = System.Drawing.Color.Black;
                button22mns.PerformClick();
                button23mns.PerformClick();
                button28mns.PerformClick();
                button26mns.PerformClick();
                button25mns.PerformClick();
            }
            if (mns1 == 3)
            {
                button26mns.BackColor = System.Drawing.Color.Black;
                button22mns.PerformClick();
                button23mns.PerformClick();
                button28mns.PerformClick();
                button24mns.PerformClick();
                button25mns.PerformClick();
            }
            if (mns1 == 4)
            {
                button22mns.BackColor = System.Drawing.Color.Black;
                button25mns.BackColor = System.Drawing.Color.Black;
                button27mns.PerformClick();
                button28mns.PerformClick();
                button23mns.PerformClick();
                button24mns.PerformClick();
            }
            if (mns1 == 5)
            {
                button23mns.BackColor = System.Drawing.Color.Black;
                button22mns.PerformClick();
                button27mns.PerformClick();
                button28mns.PerformClick();
                button24mns.PerformClick();
                button25mns.PerformClick();
            }
            if (mns1 == 0)
            {
                button28mns.BackColor = System.Drawing.Color.Black;
                button22mns.PerformClick();
                button27mns.PerformClick();
                button24mns.PerformClick();
                button25mns.PerformClick();
                button26mns.PerformClick();
                button23mns.PerformClick();
            }

            int hrs = Convert.ToInt32(DateTime.Now.ToString("hh").Substring(DateTime.Now.ToString("hh").Length - 1));

            if (hrs == 1)
            {
                button29hrs.BackColor = System.Drawing.Color.Black;
                button32hrs.BackColor = System.Drawing.Color.Black;
                button33hrs.BackColor = System.Drawing.Color.Black;
                button34hrs.BackColor = System.Drawing.Color.Black;
                button30hrs.PerformClick();
                button31hrs.PerformClick();
            }
            if (hrs == 2)
            {
                button31hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button30hrs.PerformClick();
                button35hrs.PerformClick();
                button33hrs.PerformClick();
                button32hrs.PerformClick();
            }
            if (hrs == 3)
            {
                button33hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button30hrs.PerformClick();
                button35hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
            }
            if (hrs == 4)
            {
                button29hrs.BackColor = System.Drawing.Color.Black;
                button32hrs.BackColor = System.Drawing.Color.Black;
                button34hrs.PerformClick();
                button35hrs.PerformClick();
                button30hrs.PerformClick();
                button31hrs.PerformClick();
            }
            if (hrs == 5)
            {
                button30hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button34hrs.PerformClick();
                button35hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
            }
            if (hrs == 6)
            {
                button29hrs.PerformClick();
                button34hrs.PerformClick();
                button35hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
                button33hrs.PerformClick();
            }
            if (hrs == 7)
            {
                button34hrs.BackColor = System.Drawing.Color.Black;
                button33hrs.BackColor = System.Drawing.Color.Black;
                button35hrs.BackColor = System.Drawing.Color.Black;
                button32hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button30hrs.PerformClick();
                button31hrs.PerformClick();
            }
            if (hrs == 8)
            {
                button29hrs.PerformClick();
                button34hrs.PerformClick();
                button35hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
                button33hrs.PerformClick();
                button30hrs.PerformClick();
            }
            if (hrs == 9)
            {
                button33hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button34hrs.PerformClick();
                button35hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
                button30hrs.PerformClick();
            }
            if (hrs == 0)
            {
                button35hrs.BackColor = System.Drawing.Color.Black;
                button29hrs.PerformClick();
                button34hrs.PerformClick();
                button31hrs.PerformClick();
                button32hrs.PerformClick();
                button33hrs.PerformClick();
                button30hrs.PerformClick();
            }

            int hrs1 = Convert.ToInt32(DateTime.Now.ToString("hh").Substring(0, 1));

            if (hrs1 == 1)
            {
                button36hrs.BackColor = System.Drawing.Color.Black;
                button39hrs.BackColor = System.Drawing.Color.Black;
                button40hrs.BackColor = System.Drawing.Color.Black;
                button41hrs.BackColor = System.Drawing.Color.Black;
                button37hrs.PerformClick();
                button38hrs.PerformClick();
            }
            if (hrs1 == 2)
            {
                button38hrs.BackColor = System.Drawing.Color.Black;
                button36hrs.PerformClick();
                button37hrs.PerformClick();
                button42hrs.PerformClick();
                button40hrs.PerformClick();
                button39hrs.PerformClick();
            }
            if (hrs1 == 3)
            {
                button40hrs.BackColor = System.Drawing.Color.Black;
                button36hrs.PerformClick();
                button37hrs.PerformClick();
                button42hrs.PerformClick();
                button38hrs.PerformClick();
                button39hrs.PerformClick();
            }
            if (hrs1 == 4)
            {
                button36hrs.BackColor = System.Drawing.Color.Black;
                button39hrs.BackColor = System.Drawing.Color.Black;
                button41hrs.PerformClick();
                button42hrs.PerformClick();
                button37hrs.PerformClick();
                button38hrs.PerformClick();
            }
            if (hrs1 == 5)
            {
                button37hrs.BackColor = System.Drawing.Color.Black;
                button36hrs.PerformClick();
                button41hrs.PerformClick();
                button42hrs.PerformClick();
                button38hrs.PerformClick();
                button39hrs.PerformClick();
            }
            if (hrs1 == 0)
            {
                button42hrs.BackColor = System.Drawing.Color.Black;
                button36hrs.PerformClick();
                button41hrs.PerformClick();
                button38hrs.PerformClick();
                button39hrs.PerformClick();
                button40hrs.PerformClick();
                button37hrs.PerformClick();
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

        private void label5_Click(object sender, EventArgs e)
        {
           label5.Text=DateTime.Now.ToString("tt");
        }
    }
}
