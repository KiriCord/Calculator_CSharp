using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.ActiveControl = buttonIS;
        }

        double a, b;
        char sign;
        bool znak = true;
        bool isProcent = false;
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("∞"))
                textBox1.Text = "0";
            if (textBox1.Text != "0")
                textBox1.Text += "0";

        }

        private double _mem;
        protected double Mem
        {
            get { return _mem; }
            set
            {
                _mem = value;
                textBox2.Text = $"{_mem}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "1";
            else if (textBox1.Text == "-0") textBox1.Text = "-1";
            else
                textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "2";
            else if (textBox1.Text == "-0") textBox1.Text = "-2";
            else
                textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "3";
            else if (textBox1.Text == "-0") textBox1.Text = "-3";
            else
                textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "4";
            else if (textBox1.Text == "-0") textBox1.Text = "-4";
            else
                textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "5";
            else if (textBox1.Text == "-0") textBox1.Text = "-5";
            else
                textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "6";
            else if (textBox1.Text == "-0") textBox1.Text = "-6";
            else
                textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "7";
            else if (textBox1.Text == "-0") textBox1.Text = "-7";
            else
                textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "8";
            else if (textBox1.Text == "-0") textBox1.Text = "-8";
            else
                textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == a.ToString() || textBox1.Text == "∞")
                textBox1.Text = "9";
            else if (textBox1.Text == "-0") textBox1.Text = "-9";
            else
                textBox1.Text = textBox1.Text + 9;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            //textBox1.Clear();
            sign = '+';
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            //textBox1.Clear();
            sign = '-';
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void buttonMultip_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            //textBox1.Clear();
            sign = '*';
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void buttonDivis_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            sign = '/';
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void buttonIS_Click(object sender, EventArgs e)
        {
            isProcent = false;
            switch (sign)
            {
                case '+':
                    b = a + double.Parse(textBox1.Text);
                   //textBox1.Text = b.ToString();
                    break;
                case '-':
                    b = a - double.Parse(textBox1.Text);
                    //textBox1.Text = b.ToString();
                    break;
                case '*':
                    b = a * double.Parse(textBox1.Text);
                    //textBox1.Text = b.ToString();
                    break;
                case '/':

                    b = a / double.Parse(textBox1.Text);
                    //textBox1.Text = b.ToString();
                    break;
                case '√':
                    b = Math.Sqrt(double.Parse(textBox1.Text));
                    //textBox1.Text = b.ToString();
                    break;
                case '1': //  1/x

                    b = 1 / a;
                    //textBox1.Text = b.ToString();
                    break;
                case 'Y':
                    b = Math.Pow(a, double.Parse(textBox1.Text));
                    label1.Text = label1.Text + textBox1.Text;
                    //textBox1.Text = b.ToString();
                    break;
                case 'Q':
                    b = Math.Pow(Math.Abs(double.Parse(textBox1.Text)), (1 / a));
                    label1.Text = label1.Text + textBox1.Text;
                    //textBox1.Text = b.ToString();

                    break;
                default:
                    break;
            }
            if (double.IsInfinity(b) || double.IsNaN(b))
            {
                textBox1.Text = "Некорректный ввод";
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
                buttonC.Enabled = true;
            }
            else
            {
                textBox1.Text = b.ToString();
            }

            label1.Text = "";
        }

        public static bool CheckNaNInfs(string textbox) =>
          textbox == NumberFormatInfo.CurrentInfo.NaNSymbol || textbox.Contains("∞") || textbox.Contains("Некорректный ввод");

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            buttonPoint.Enabled = true;
            sign = '0';
            a = 0;
            znak = true;

            foreach (Control item in Controls)
            {
                item.Enabled = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            //label1.Text = "";
            buttonPoint.Enabled = true;
            sign = '0';
            znak = true;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Sqrt(a);// / double.Parse(textBox1.Text);
            textBox1.Text = b.ToString();
            // textBox1.Clear();
            label1.Text = "√" + a.ToString();
            sign = '√';
            znak = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            if (textBox1.TextLength == 0)
                textBox1.Text = "0";
        }

        private void инженерныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Width = 415;
            if (Form1.ActiveForm.Width < 415)
            {
                for (int i = 0; i <= 169; i++)
                {
                    Form1.ActiveForm.Width++;
                }

                for (int i = 0; i <= 164; i++)
                {
                    textBox1.Width++;
                }
            }
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e) //обычный
        {
            //Form1.ActiveForm.Width = 246;
            if (Form1.ActiveForm.Width > 246)
            {
                for (int i = Form1.ActiveForm.Width; i >= 246; i--)
                {
                    Form1.ActiveForm.Width--;
                }
                for (int i = textBox1.Width; i >= 206; i--) //164
                {
                    textBox1.Width--;
                }
            }
        }

        private void тёмнаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Black;
            //button1.BackColor = Color.Black;
            foreach (Control control in Controls)
            {
                control.BackColor = Color.FromArgb(45, 45, 48);
            }
            foreach (Control control1 in Controls)
            {
                control1.ForeColor = Color.White;
            }

        }

        private void светлаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = DefaultBackColor;
            foreach (Control control in Controls)
            {
                control.BackColor = Control.DefaultBackColor;
            }
            foreach (Control control1 in Controls)
            {
                control1.ForeColor = Color.Black;
            }
        }

        private void buttonDivX_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = 1 / a;// double.Parse(textBox1.Text);
            textBox1.Text = b.ToString();
            // textBox1.Clear();
            label1.Text = "1/" + a.ToString();
            sign = '1';
            znak = true;
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = a * a;
            textBox1.Text = b.ToString();
            label1.Text = a.ToString() + "^2";
            znak = true;
        }

        private void buttonSqr3_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = a * a * a;
            textBox1.Text = b.ToString();
            label1.Text = a.ToString() + "^3";
            znak = true;
        }

        private void buttonSqrY_Click(object sender, EventArgs e)
        {

            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "^";
            sign = 'Y';
            znak = true;
            textBox1.Text = "";
            // b = a * double.Parse(textBox1.Text);
            //textBox1.Text = b.ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
                b = Math.Round(Math.Sin(a), 8);
            else
                b = Math.Round(Math.Sin(ToRadians(a)), 8);
            textBox1.Text = b.ToString();
            label1.Text = "Sin(" + a.ToString() + ")";
            znak = true;
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
                b = Math.Round(Math.Cos(a), 8);
            else
                b = Math.Round(Math.Cos(ToRadians(a)), 8);
            textBox1.Text = b.ToString();
            label1.Text = "Cos(" + a.ToString() + ")";
            znak = true;
        }

        public static double ToAngles(double x) => x * 180 / Math.PI;
        public static double ToRadians(double x) => x * Math.PI / 180;

        public string Tan(string x, bool isRad)
        {
            a = double.Parse(textBox1.Text);
            var radians = isRad ? a : ToRadians(a);
            var angle = isRad ? ToAngles(a) : a;
            if (Math.Round(angle, 2) % 180 != 0 && Math.Round(angle, 2) % 90 == 0)
                return "не число";
            return Math.Tan(radians).ToString();

        }
        private void button_Click(object sender, EventArgs e)
        {

            textBox1.Text = Tan(textBox1.Text, radioButton2.Checked);
            label1.Text = "Tan(" + a.ToString() + ")";
            znak = true;
        }

        public static double Factorial(string x)
        {
            try
            {
                var t = int.Parse(x);
                if (t >= 20)
                {
                    return double.PositiveInfinity;
                }
                if (t == 0)
                    return 1d;
                return Enumerable
                    .Range(1, t)
                    .Aggregate((acc, i) => acc * i);
            }
            catch (Exception)
            {
                return double.PositiveInfinity;
            }
        }
        private void buttonFactor_Click(object sender, EventArgs e)
        {

            a = double.Parse(textBox1.Text);
            b = Factorial(a.ToString());// / double.Parse(textBox1.Text);

            textBox1.Text = b.ToString();
            // textBox1.Clear();
            label1.Text = a.ToString() + "!";
            znak = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CheckNaNInfs(textBox1.Text) || textBox1.Text.Contains("не число"))
            {
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
                buttonC.Enabled = true;
            }

            if(textBox1.Text.Contains("∞") )
            {
                textBox1.Text.Contains("Некорректный ввод");
            }

            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "0";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            switch (number)
            {
                case '1':
                    button1_Click(textBox1, new EventArgs());
                    break;
                case '2':
                    button2_Click(textBox1, new EventArgs());
                    break;
                case '3':
                    button3_Click(textBox1, new EventArgs());
                    break;
                case '4':
                    button4_Click(textBox1, new EventArgs());
                    break;
                case '5':
                    button5_Click(textBox1, new EventArgs());
                    break;
                case '6':
                    button6_Click(textBox1, new EventArgs());
                    break;
                case '7':
                    button7_Click(textBox1, new EventArgs());
                    break;
                case '8':
                    button8_Click(textBox1, new EventArgs());
                    break;
                case '9':
                    button9_Click(textBox1, new EventArgs());
                    break;
                case '0':
                    button0_Click(textBox1, new EventArgs());
                    break;
                case (char)Keys.Back:
                    buttonBackspace_Click(textBox1, new EventArgs());
                    break;
                case '+':
                    buttonPlus_Click(textBox1, new EventArgs());
                    break;
                case '-':
                    buttonMinus_Click(textBox1, new EventArgs());
                    break;
                case '/':
                    buttonDivis_Click(textBox1, new EventArgs());
                    break;
                case '*':
                    buttonMultip_Click(textBox1, new EventArgs());
                    break;
                case '.':
                    buttonPoint_Click(textBox1, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Log(a);
            textBox1.Text = b.ToString();
            label1.Text = "Ln(" + a.ToString() + ")";
            znak = true;
        }

        private void buttonLog10_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Log10(a);
            textBox1.Text = b.ToString();
            label1.Text = "log10(" + a.ToString() + ")";
            znak = true;
        }

        private void buttonModule_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Abs(a);
            textBox1.Text = b.ToString();
            label1.Text = "|" + a.ToString() + "|";
            znak = true;
        }

        private void buttonSqrtY_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            label1.Text = a.ToString() + "√"; ;
            sign = 'Q';
            znak = true;
            textBox1.Text = "";
        }

        private void buttonSqrt3_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Sign(a) * Math.Pow(Math.Abs(a), (1 / 3d));
            textBox1.Text = b.ToString();
            label1.Text = "∛" + a.ToString();
            znak = true;
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            znak = true;
            textBox1.Text = Math.E.ToString();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            znak = true;
            textBox1.Text = Math.PI.ToString();
        }

        private void buttonAsin_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
                b = Math.Asin(a);
            else
                b = ToAngles(Math.Asin(a));
            //b = Math.Asin(ToRadians(a));
            textBox1.Text = b.ToString();
            label1.Text = "Asin(" + a.ToString() + ")";
            znak = true;
        }

        private void buttonAcos_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
                b = Math.Acos(a);
            else
                b = ToAngles(Math.Acos(a));
            textBox1.Text = b.ToString();
            label1.Text = "Acos(" + a.ToString() + ")";
            znak = true;
        }

        private void buttonAtan_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
                b = Math.Atan(a);
            else
                b = ToAngles(Math.Atan(a));
            textBox1.Text = b.ToString();
            label1.Text = "Atan(" + a.ToString() + ")";
            znak = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Pow(a, 10);
            textBox1.Text = b.ToString();
            label1.Text = "10^" + a.ToString();
            znak = true;
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            double c = double.Parse(textBox1.Text);
            b = a * c / 100;
            textBox1.Text = b.ToString();
            if (isProcent == false)
            {
                label1.Text = b.ToString();
                isProcent = true;
            }
            else
                isProcent = false;
            znak = true;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            Mem = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            Mem += double.Parse(textBox1.Text);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            Mem -= double.Parse(textBox1.Text);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Info = MessageBox.Show("Калькулятор \nСделал: Рахманов Артур",
                                                                "Справка",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information,
                                                                MessageBoxDefaultButton.Button1,
                                                                MessageBoxOptions.DefaultDesktopOnly);
            if (Info == DialogResult.OK)
                this.Activate();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "∞")
                return;
            else
            {
                textBox1.Text = textBox1.Text + ",";
                buttonPoint.Enabled = false;
            }*/
            if (!textBox1.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                textBox1.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }
    }
}
