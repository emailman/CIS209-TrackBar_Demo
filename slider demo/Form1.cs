using System;
using System.Drawing;
using System.Windows.Forms;

namespace slider_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbrRed_Scroll(object sender, EventArgs e)
        {

            lblRedValue.Text = "Red Value = " + tbrRed.Value.ToString();
            ColorIt();
        }

        private void tbrGreen_Scroll(object sender, EventArgs e)
        {
            lblGreenValue.Text = "Green Value = " + tbrGreen.Value.ToString();
            ColorIt();
        }

        private void tbrBlue_Scroll(object sender, EventArgs e)
        {
            lblBlueValue.Text = "Blue Value = " + tbrBlue.Value.ToString();
            ColorIt();
        }

        private void tbrSaturation_Scroll(object sender, EventArgs e)
        {
            lblSaturationValue.Text = "Saturation Value = " + tbrSaturation.Value.ToString();
            ColorIt();
        }

        private void ColorIt()
        {
            pbxSquare.BackColor =
                Color.FromArgb(tbrSaturation.Value, tbrRed.Value, tbrGreen.Value, tbrBlue.Value);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbrRed.Value = 0;
            tbrGreen.Value = 0;
            tbrBlue.Value = 0;
            tbrSaturation.Value = 0;
            lblRedValue.Text = "Red Value = 0";
            lblGreenValue.Text = "Green Value = 0";
            lblBlueValue.Text = "Blue Value = 0";
            lblSaturationValue.Text = "Saturation Value = 0";
            ColorIt();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Did you enjoyed using this program";
            MessageBox.Show(message, "The Mailman Color Mixer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
