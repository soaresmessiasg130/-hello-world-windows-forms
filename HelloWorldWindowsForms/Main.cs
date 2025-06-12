using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindowsForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                button1.Text = "You clicked me!!!";

                return;
            }

            button1.Enabled = false;

            for (int i = 10; i >= 0; i--)
            {
                button1.Enabled = i == 0;

                label1.Text = i == 0 ? "Click now!!!" : "Unlocking the button in " + i;

                Thread.Sleep(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNumber1.Text) && !string.IsNullOrEmpty(tbNumber2.Text))
            {
                var number1 = Convert.ToInt32(tbNumber1.Text);
                var number2 = Convert.ToInt32(tbNumber2.Text);
                var res = (number1 * number2).ToString();

                labelResult.Text = res.ToString();
            }
        }

        private void tbNumber1_TextChanged(object sender, EventArgs e)
        {
            unlockMultiplyButton();
        }

        private void tbNumber2_TextChanged(object sender, EventArgs e)
        {
            unlockMultiplyButton();
        }

        private void unlockMultiplyButton()
        {
            btnMultiply.Enabled = !string.IsNullOrEmpty(tbNumber1.Text) && !string.IsNullOrEmpty(tbNumber2.Text);
        }
    }
}
