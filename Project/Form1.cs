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
        double n1 = 0;
        double n2 = 0;
        int oper = 0;
        bool deleteAfterOperation = false;
        bool activeOperation = false;
        bool darkTheme = false;

        /* 0 - ничего
         * 1 - деление
         * 2 - умножение
         * 3 - вычитание
         * 4 - сложение
         * 5 - степень
         */

        void chancheButtonMouseOverBackColor()
        {
            Button[] interfaceButtons1 = { buttonSin, buttonCos, buttonTan, buttonLg,
                                           buttonLn, buttonС, buttonD, buttonPlusMinus, buttonDiv,
                                           buttonDegree, button7, button8, button9, buttonMult,
                                           buttonSqrt, button4, button5, button6, buttonMin,
                                           buttonFactorial };
            Button[] interfaceButtons2 = { button1, button2, button3, buttonPlus,
                                           buttonOneDivX, button0, buttonPoint, buttonEquals };

            if (darkTheme)
            {
                buttonTheme.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                foreach (Button b in interfaceButtons1)
                {
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
                }
                foreach (Button b in interfaceButtons2)
                {
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
                }
            }
            else
            {
                buttonTheme.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 240, 240);
                foreach (Button b in interfaceButtons1)
                {
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 190, 100);
                }
                foreach (Button b in interfaceButtons2)
                {
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 97, 65);
                }
            }
        }

        void calculate()
        {
            switch (oper)
            {
                case 1:
                    label1.Text = (n1 / n2).ToString();
                    break;
                case 2:
                    label1.Text = (n1 * n2).ToString();
                    break;
                case 3:
                    label1.Text = (n1 - n2).ToString();
                    break;
                case 4:
                    label1.Text = (n1 + n2).ToString();
                    break;
                case 5:
                    Double res = n1;
                    if (!(n2 > 10000 || Double.IsInfinity(n2)))
                    {
                        if (n2 == 0)
                            label1.Text = "1";
                        else
                            for (int i = 0; i < Math.Abs(n2) - 1; i++)
                                res *= n1;
                    }
                    else
                    {
                        if (n1 < 0 && n2 % 2 == 1)
                            res = Double.NegativeInfinity;
                        else
                            res = Double.PositiveInfinity;
                    }
                    label1.Text = res.ToString();
                    break;
            }
        }

        void calculateAfterOperation()
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
                n1 = Double.Parse(label1.Text);
            }
            else
            {
                n1 = Double.Parse(label1.Text);
            }
            deleteAfterOperation = true;
            activeOperation = true;
        }

        public Form1()
        {
            InitializeComponent();
            chancheButtonMouseOverBackColor();
        }

        // 0
        private void button0_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-0";
                else
                    label1.Text += "0";
            }
            else
                label1.Text = "0";
            deleteAfterOperation = false;
        }

        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-1";
                else
                    label1.Text += "1";
            }
            else
            {
                label1.Text = "1";
            }
            deleteAfterOperation = false;
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-2";
                else
                    label1.Text += "2";
            }
            else
            {
                label1.Text = "2";
            }
            deleteAfterOperation = false;
        }

        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-3";
                else
                    label1.Text += "3";
            }
            else
            {
                label1.Text = "3";
            }
            deleteAfterOperation = false;
        }

        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-4";
                else
                    label1.Text += "4";
            }
            else
            {
                label1.Text = "4";
            }
            deleteAfterOperation = false;
        }

        // 5
        private void button5_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-5";
                else
                    label1.Text += "5";
            }
            else
            {
                label1.Text = "5";
            }
            deleteAfterOperation = false;
        }

        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-6";
                else
                    label1.Text += "6";
            }
            else
            {
                label1.Text = "6";
            }
            deleteAfterOperation = false;
        }

        // 7
        private void button7_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-7";
                else
                    label1.Text += "7";
            }
            else
            {
                label1.Text = "7";
            }
            deleteAfterOperation = false;
        }

        // 8
        private void button8_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-8";
                else
                    label1.Text += "8";
            }
            else
            {
                label1.Text = "8";
            }
            deleteAfterOperation = false;
        }

        // 9
        private void button9_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (label1.Text != "0" && !deleteAfterOperation)
            {
                if (label1.Text == "-0")
                    label1.Text = "-9";
                else
                    label1.Text += "9";
            }
            else
            {
                label1.Text = "9";
            }
            deleteAfterOperation = false;
        }

        // ,
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            n2 = 0;
            if (!label1.Text.Contains(","))
            {
                if (deleteAfterOperation)
                    label1.Text = "0,";
                else
                    label1.Text += ",";
            }
            deleteAfterOperation = false;
        }

        // Clear
        private void buttonС_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
                label1.Text = "0";
            oper = 0;
            deleteAfterOperation = false;
            activeOperation = false;
        }

        // BackSpace
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (Double.IsNaN(n2))
            {
                label1.Text = "0";
                n2 = 0;
            }
            if (label1.Text != "0")
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            if (label1.Text.Length == 0)
            {
                label1.Text = "0";
                deleteAfterOperation = false;
                activeOperation = false;
            }
        }

        // +/-
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            /* MessageBox.Show(n1.ToString() + "\n" + Double.IsNaN(n1).ToString() + "\n" +
                            n2.ToString() + "\n" + Double.IsNaN(n2).ToString()); */
            if (!Double.IsNaN(n2))
            {
                if (label1.Text.Remove(1, label1.Text.Length - 1) == "-")
                    label1.Text = label1.Text.Remove(0, 1);
                else
                    label1.Text = "-" + label1.Text;
                deleteAfterOperation = false;
            }
        }

        // Деление
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            calculateAfterOperation();
            oper = 1;
        }

        // Умножение
        private void buttonMult_Click(object sender, EventArgs e)
        {
            calculateAfterOperation();
            oper = 2;
        }
        
        // Вычитание
        private void buttonMin_Click(object sender, EventArgs e)
        {
            calculateAfterOperation();
            oper = 3;
        }

        // Сложение
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calculateAfterOperation();
            oper = 4;
        }

        // Равно
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            n2 = Double.Parse(label1.Text);
            calculate();
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Синус
        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Sin(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Косинус
        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Cos(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Тангенс
        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Tan(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Lg
        private void buttonLg_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Log10(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Ln
        private void buttonLn_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Log(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Степень
        private void buttonDegree_Click(object sender, EventArgs e)
        {
            calculateAfterOperation();
            oper = 5;
        }

        // Квадратный корень
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            label1.Text = Math.Sqrt(Double.Parse(label1.Text)).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Факториал
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            n2 = Double.Parse(label1.Text);
            if (n2 >= 0)
            {
                if (Math.Abs(n2) < 200)
                {
                    if (activeOperation)
                    {
                        calculate();
                    }
                    n1 = Double.Parse(label1.Text);
                    Double res = 1;
                    if (Double.Parse(label1.Text) == 0)
                        label1.Text = "1";
                    else
                    {
                        for (Double x = n1; x > 0; x--)
                            res *= x;
                    }
                    label1.Text = res.ToString();
                }
                else
                {
                    label1.Text = double.PositiveInfinity.ToString();
                }
            }
            else
            {
                label1.Text = double.NaN.ToString();
            }
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // 1/x
        private void buttonOneDivX_Click(object sender, EventArgs e)
        {
            if (activeOperation)
            {
                n2 = Double.Parse(label1.Text);
                calculate();
            }
            n1 = Double.Parse(label1.Text);
            label1.Text = (1 / n1).ToString();
            n2 = Double.Parse(label1.Text);
            deleteAfterOperation = true;
            activeOperation = false;
        }

        // Смена темы
        private void buttonTheme_Click(object sender, EventArgs e)
        {
            Button[] interfaceButtons = { buttonTheme, buttonSin, buttonCos, buttonTan, buttonLg,
                                          buttonLn, buttonС, buttonD, buttonPlusMinus, buttonDiv,
                                          buttonDegree, button7, button8, button9, buttonMult,
                                          buttonSqrt, button4, button5, button6, buttonMin,
                                          buttonFactorial, button1, button2, button3, buttonPlus,
                                          buttonOneDivX, button0, buttonPoint, buttonEquals };
            if (darkTheme)
            {
                darkTheme = false;
                buttonTheme.Text = " ";
                this.BackgroundImage = Properties.Resources._1;
                foreach (Button b in interfaceButtons)
                {
                    b.ForeColor = Color.Black;
                    b.FlatAppearance.BorderColor = Color.Black;
                }
                label1.ForeColor = Color.Black;
                buttonTheme.ForeColor = Color.Orange;
            }
            else
            {
                darkTheme = true;
                buttonTheme.Text = "🌑";
                this.BackgroundImage = Properties.Resources._2;
                foreach (Button b in interfaceButtons)
                {
                    b.ForeColor = Color.LightGray;
                    b.FlatAppearance.BorderColor = Color.LightGray;
                }
                label1.ForeColor = Color.LightGray;
                buttonTheme.ForeColor = Color.LightCyan;
            }
            chancheButtonMouseOverBackColor();
        }
    }
}
