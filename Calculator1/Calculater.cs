using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Calculater : Form  
    {
        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;

        bool isOperationPerformed = false;
        float num1;
        public Calculater()
        {
            InitializeComponent();
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            Screentxt.Text = "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screentxt.Text);
            Screentxt.Text = "0";
            Operation = "-";
            isOperationPerformed = true;
        }
       

        private void Screentxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zerobtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "0";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "0";
                isOperationPerformed = false;
            }

        }

        private void Onebtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "1";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "1";
                isOperationPerformed = false;
            }
        }

        private void Twobtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "2";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "2";
                isOperationPerformed = false;
            }
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "3";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "3";
                isOperationPerformed = false;
            }
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "4";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "4";
                isOperationPerformed = false;
            }
        }

        private void Fivebtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "5";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "5";
                isOperationPerformed = false;
            }
        }
        private void Sixbtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "6";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "6";
                isOperationPerformed = false;
            }

        }
        private void Sevenbtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "7";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "7";
                isOperationPerformed = false;
            }
        }

        private void Eightbtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "8";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "8";
                isOperationPerformed = false;
            }
        }

        private void Ninebtn_Click(object sender, EventArgs e)
        {
            if (Screentxt.Text == "0" && Screentxt.Text != null)
            {
                Screentxt.Text = "9";
                isOperationPerformed = false;
            }
            else
            {
                Screentxt.Text = Screentxt.Text + "9";
                isOperationPerformed = false;
            }
        }

        private void Dotbtn_Click(object sender, EventArgs e)
        {
            if ((Screentxt.Text == "0") || (isOperationPerformed))
                Screentxt.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Screentxt.Text.Contains("."))
                    Screentxt.Text = Screentxt.Text + button.Text;

            }
            else
                Screentxt.Text = Screentxt.Text + button.Text;
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && Screentxt.TextLength > 0)
            {
                num1 = 0; Screentxt.Clear();
            }
            else if (num1 > 0 && Screentxt.TextLength > 0)
            {
                Screentxt.Clear();
            }
        }

        private void DELbtn_Click(object sender, EventArgs e)
        {
            int lenght = Screentxt.TextLength - 1;
            string text = Screentxt.Text;
            Screentxt.Clear();
            for (int i = 0; i < lenght; i++)
                Screentxt.Text = Screentxt.Text + text[i];
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screentxt.Text);
            Screentxt.Text = "0";
            Operation = "+";
            isOperationPerformed = true;
        }

        private void Eqlbtn_Click(object sender, EventArgs e)
        {
           
            SecondNumber = Convert.ToDouble(Screentxt.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Screentxt.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelCurrentOperation.Text = "";
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Screentxt.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelCurrentOperation.Text = "";
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Screentxt.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelCurrentOperation.Text = "";
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Screentxt.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Screentxt.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    labelCurrentOperation.Text = "";
                }
            }
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screentxt.Text);
            Screentxt.Text = "0";
            Operation = "*";
            isOperationPerformed = true;

        }

        private void divedbtn_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screentxt.Text);
            Screentxt.Text = "0";
            Operation = "/";
            isOperationPerformed = true;

        }

        private void Squarebtn_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screentxt.Text);
            Operation = "^";
            if (Operation == "^")
            {
                Result = (FirstNumber * FirstNumber);
                Screentxt.Text = Convert.ToString(Result);
                FirstNumber = Result;
                isOperationPerformed = true;
            }

        }
    }
}
