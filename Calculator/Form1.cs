using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber;
        char action;
        private Point mouseOffset;
        private bool isMouseDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                action = 'p';
                firstNumber = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                action = 'm';
                firstNumber = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                action = 'y';
                firstNumber = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                action = 'd';
                firstNumber = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            action = 'q';
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && !textBox.Text.Contains(','))
            {
                textBox.Text += ",";
            }
            else if (textBox.Text == "")
            {
                textBox.Text = "0,";           
            }
        }

        private void buttonFirstMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "-";
            }
            else if (textBox.Text == "-")
            {
                textBox.Text = "";
            }


        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (action == 'p')
            {
                if (textBox.Text != "" && firstNumber == 140)
                {
                    secondNumber = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    if (secondNumber == 12)
                    {
                        textBox.Text = "Ты классная)";
                        action = 'q';
                    }
                    else
                    {
                        textBox.Text = Convert.ToString(firstNumber + secondNumber);
                        action = 'q';
                    }
                }
                else if (textBox.Text != "")
                {
                    secondNumber = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    textBox.Text = Convert.ToString(firstNumber + secondNumber);
                    action = 'q';
                }
            }

            else if (action == 'm')
            {
                if (textBox.Text != "")
                {
                    secondNumber = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    textBox.Text = Convert.ToString(firstNumber - secondNumber);
                    action = 'q';
                }
            }

            else if (action == 'y')
            {
                if (textBox.Text != "")
                {
                    secondNumber = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    textBox.Text = Convert.ToString(firstNumber * secondNumber);
                    action = 'q';
                }
            }

            else if (action == 'd')
            {
                if (textBox.Text != "")
                {
                    secondNumber = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    textBox.Text = Convert.ToString(firstNumber / secondNumber);
                    action = 'q';
                }
            }
        }
    }
}
