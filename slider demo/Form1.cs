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

        // Handler for Red scroll
        private void tbrRed_Scroll(object sender, EventArgs e)
        {

            lblRedValue.Text = "Red Value = " + tbrRed.Value.ToString();
            ColorIt();
        }

        // Handler for Green scroll
        private void tbrGreen_Scroll(object sender, EventArgs e)
        {
            lblGreenValue.Text = "Green Value = " + tbrGreen.Value.ToString();
            ColorIt();
        }

        // Handler for Blue scroll
        private void tbrBlue_Scroll(object sender, EventArgs e)
        {
            lblBlueValue.Text = "Blue Value = " + tbrBlue.Value.ToString();
            ColorIt();
        }

        // Handler for Saturation scroll
        private void tbrSaturation_Scroll(object sender, EventArgs e)
        {
            lblSaturationValue.Text = "Saturation Value = " + tbrSaturation.Value.ToString();
            ColorIt();
        }

        // Set the saturation and color of the Picture Box
        private void ColorIt()
        {
            pbxSquare.BackColor =
                Color.FromArgb(tbrSaturation.Value, tbrRed.Value, tbrGreen.Value, tbrBlue.Value);
        }

        // Handle the Quit Button click
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Handle the Reset Button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbrRed.Value = 0;
            tbrGreen.Value = 0;
            tbrBlue.Value = 0;
            tbrSaturation.Value = 255;
            lblRedValue.Text = "Red Value = 0";
            lblGreenValue.Text = "Green Value = 0";
            lblBlueValue.Text = "Blue Value = 0";
            lblSaturationValue.Text = "Saturation Value = 255";
            ColorIt();
        }

        // Handle the FormClosing event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Did you enjoyed using this program";
            MessageBox.Show(message, "The Mailman Color Mixer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
