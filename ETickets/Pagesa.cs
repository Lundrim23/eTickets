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
    public partial class Pagesa : Form
    {
        public Pagesa()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
          //  bunifuCheckBox1.Checked = bunifuCheckBox2.Checked = bunifuCheckBox3.Checked = false;
          //  ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;

        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           // bunifuCheckBox1.Checked = bunifuCheckBox2.Checked = bunifuCheckBox3.Checked = false;
          //  ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void bunifuCheckBox3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           // bunifuCheckBox1.Checked = bunifuCheckBox2.Checked = bunifuCheckBox3.Checked = false;
          //  ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            string msg = "Faleminderit";
            MessageBox.Show("Tiketen e keni porositur me sukses! ", msg);
        }

        private void Pagesa_Load(object sender, EventArgs e)
        {
            lblKarroca.Text = "Karroca e blerjeve: " + Form1.passingText;
        }

        bool mouseDown;
        private Point offset;
        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);


            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
