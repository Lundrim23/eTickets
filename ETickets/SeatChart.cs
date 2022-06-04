using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETickets
{
    public partial class SeatChart : Form
    {

        private bool green;
        private bool blue;
        private bool orange;
        private bool red;
        private bool yellow;
        private bool gray;

        public static string passingText;
        public SeatChart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (green)
            {
                
                paneli1.Height += 10;
                if(paneli1.Size == paneli1.MaximumSize)
                {
                    timer1.Stop();
                    green = false;
                }


            }
            else
            {
                paneli1.Height -= 10;
                if (paneli1.Size == paneli1.MinimumSize)
                {
                    timer1.Stop();
                    green = true;
                }
            }

            
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (blue)
            {

                paneli2.Height += 10;
                if (paneli2.Size == paneli2.MaximumSize)
                {
                    timer2.Stop();
                    blue = false;
                }


            }
            else
            {
                paneli2.Height -= 10;
                if (paneli2.Size == paneli2.MinimumSize)
                {
                    timer2.Stop();
                    blue = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (orange)
            {

                paneli3.Height += 10;
                if (paneli3.Size == paneli3.MaximumSize)
                {
                    timer3.Stop();
                    orange = false;
                }


            }
            else
            {
                paneli3.Height -= 10;
                if (paneli3.Size == paneli3.MinimumSize)
                {
                    timer3.Stop();
                    orange = true;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //4
            if (red)
            {

                paneli4.Height += 10;
                if (paneli4.Size == paneli4.MaximumSize)
                {
                    timer4.Stop();
                    red = false;
                }


            }
            else
            {
                paneli4.Height -= 10;
                if (paneli4.Size == paneli4.MinimumSize)
                {
                    timer4.Stop();
                    red = true;
                }
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            //5
            if (yellow)
            {

                paneli5.Height += 10;
                if (paneli5.Size == paneli5.MaximumSize)
                {
                    timer5.Stop();
                    yellow = false;
                }


            }
            else
            {
                paneli5.Height -= 10;
                if (paneli5.Size == paneli5.MinimumSize)
                {
                    timer5.Stop();
                    yellow = true;
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //6
            if (gray)
            {

                paneli6.Height += 10;
                if (paneli6.Size == paneli6.MaximumSize)
                {
                    timer6.Stop();
                    gray = false;
                }


            }
            else
            {
                paneli6.Height -= 10;
                if (paneli6.Size == paneli6.MinimumSize)
                {
                    timer6.Stop();
                    gray = true;
                }
            }
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

       
    }
}
