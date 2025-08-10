namespace calculator
{
    public partial class DisplayController : Form
    {
        public DisplayController()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (display.TextLength > 0)
            {
                display.Text = display.Text.Remove((display.TextLength - 1));
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (display.TextLength > 0)
            {
                display.Text = "";
            }
        }
    }
}
