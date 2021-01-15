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

    
    public partial class calculatorForm : Form
    {
        double n1, n2;
        string operation;
        bool n1Entered = false;
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "1"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            answerText.Text = answerText.Text + "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            answerText.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            int l = answerText.Text.Length;
            if(l > 0)
                answerText.Text = answerText.Text.Remove(l - 1, 1);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int l = answerText.Text.Length;
            if (l > 0)
            {
                n1 = double.Parse(answerText.Text);
                operation = "+";
                n1Entered = true;
                answerText.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            int l = answerText.Text.Length;
            if (l > 0)
            {
                n1 = double.Parse(answerText.Text);
                operation = "-";
                n1Entered = true;
                answerText.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            int l = answerText.Text.Length;
            if (l > 0)
            {
                n1 = double.Parse(answerText.Text);
                operation = "*";
                n1Entered = true;
                answerText.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            int l = answerText.Text.Length;
            if (l > 0)
            {
                n1 = double.Parse(answerText.Text);
                operation = "/";
                n1Entered = true;
                answerText.Text = "";
            }
            else
            {
                MessageBox.Show("Enter Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
           var ans = 0d;
            int l = answerText.Text.Length;
            if (l > 0 && n1Entered)
            {
                n2 = double.Parse(answerText.Text);
                switch (operation)
                {
                    case "+":
                        ans = n1 + n2;
                        answerText.Text = ans.ToString();
                        break;
                    case "-":
                        ans = n1 - n2;
                        answerText.Text = ans.ToString();
                        break;
                    case "*":
                        ans = n1 * n2;
                        answerText.Text = ans.ToString();
                        break;
                    case "/":
                        ans = float.Parse(n1.ToString()) / float.Parse(n2.ToString());
                        answerText.Text = ans.ToString();
                        break;
                }

                n1Entered = false;
                n1 = ans;

            }
            else
            {
                MessageBox.Show("Enter Number First", "Error" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
    }
}
