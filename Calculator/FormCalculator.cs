namespace Calculator
{
    public partial class FormCalculator : Form
    {
        Calculator calculator = new Calculator();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 0;
            labelCalculus.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 1;
            labelCalculus.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 2;
            labelCalculus.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 3;
            labelCalculus.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 4;
            labelCalculus.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 5;
            labelCalculus.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 6;
            labelCalculus.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 7;
            labelCalculus.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 8;
            labelCalculus.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += 9;
            labelCalculus.Text += 9;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            labelCalculus.Text += " + ";
            calculator.Operator = "+";
            textBoxNumbers.Clear();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            labelCalculus.Text += " - ";
            calculator.Operator = "-";
            textBoxNumbers.Clear();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            labelCalculus.Text += " * ";
            calculator.Operator = "*";
            textBoxNumbers.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            labelCalculus.Text += " / ";
            calculator.Operator = "/";
            textBoxNumbers.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculator.Number2 = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Clear();
            labelCalculus.Text += " = ";
            labelCalculus.Text += String.Format("{0}", calculator.Calculate());
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            calculator.Operator = "^";
            labelCalculus.Text += " ^ ";
            textBoxNumbers.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Clear();
            labelCalculus.Text = "";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            calculator.Number1 = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Clear();
            labelCalculus.Text = String.Format("Square root of {0} = {1}", calculator.Number1, calculator.CalculateSquareRoot());
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += ".";
            labelCalculus.Text += ".";
        }
    }
}