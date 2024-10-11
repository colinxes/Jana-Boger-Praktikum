namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        private string StringBuilder = "";
        private double NumberValue;
        private double NumberResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void zahl_0_Click(object sender, EventArgs e)
        {
            DoSomething("0");
        }
        //Click event
        private void DoSomething(string something)
        {
            StringBuilder += something;
            rechnung.Text = StringBuilder;
            //show {StringBuilder}
        }

        private void zahl_1_Click(object sender, EventArgs e)
        {
            DoSomething("1");
        }
        private void zahl_2_Click(object sender, EventArgs e)
        {
            DoSomething("2");
        }
        private void zahl_3_Click(object sender, EventArgs e)
        {
            DoSomething("3");
        }
        private void zahl_4_Click(object sender, EventArgs e)
        {
            DoSomething("4");
        }
        private void zahl_5_Click(object sender, EventArgs e)
        {
            DoSomething("5");
        }
        private void zahl_6_Click(object sender, EventArgs e)
        {
            DoSomething("6");
        }
        private void zahl_7_Click(object sender, EventArgs e)
        {
            DoSomething("7");
        }
        private void zahl_8_Click(object sender, EventArgs e)
        {
            DoSomething("8");
        }
        private void zahl_9_Click(object sender, EventArgs e)
        {
            DoSomething("9");
        }
        private void zeichenKomma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StringBuilder))
            {
                DoSomething("0,");
            }
            else
            {
                DoSomething(",");
            }
        }
        private void zeichenPlus_Click(object sender, EventArgs e)
        {
            if (NumberValue != 0.0F)
            {
                // Addieren
                NumberValue = Calculate();
            }
            else
                NumberValue = Convert.ToDouble(StringBuilder);

            StringBuilder = string.Empty;
            StringBuilder = "";
            DoSomething("+");
            //NumberValue = Convert.ToDouble(StringBuilder);
            //DoSomething("");
        }
        private void zeichenMinus_Click(object sender, EventArgs e)
        {
            if (NumberValue != 0.0F)
            {
                // Subtrahieren
                NumberValue = Calculate();
            }
            else
                NumberValue = Convert.ToDouble(StringBuilder);

            StringBuilder = string.Empty;
            StringBuilder = "";
            DoSomething("-");
            //NumberValue = Convert.ToDouble(StringBuilder);
            //DoSomething("");
        }
        private void zeichenMal_Click(object sender, EventArgs e)
        {
            if (NumberValue != 0.0F)
            {
                // Multipliziere
                NumberValue = Calculate();
            }
            else
                NumberValue = Convert.ToDouble(StringBuilder);

            StringBuilder = string.Empty;
            StringBuilder = "";
            DoSomething("*");
            //NumberValue = Convert.ToDouble(StringBuilder);
            //DoSomething("");
        }

        private void zeichenGeteilt_Click(object sender, EventArgs e)
        {
            if (NumberValue != 0.0F)
            {
                // Dividieren
                NumberValue = Calculate();
            }
            else
                NumberValue = Convert.ToDouble(StringBuilder);

            StringBuilder = string.Empty;
            StringBuilder = "";
            DoSomething("/");
            //NumberValue = Convert.ToDouble(StringBuilder);
            //DoSomething("");
        }

        private void zeichenErase_Click(object sender, EventArgs e)
        {
            rechnung.Text = string.Empty;
            ergebnis.Text = string.Empty;
            NumberResult = 0.0F;
            StringBuilder = string.Empty;
            NumberValue = 0.0F;
        }

        private void zeichenEquals_Click(object sender, EventArgs e)
        {
            NumberResult = Calculate();

            //    if (StringBuilder[0] == '+')
            //    {
            //        StringBuilder.Replace("+", "");
            //        Convert.ToDouble(StringBuilder);
            //        //Addieren
            //    }
            //    if (StringBuilder[0] == '-')
            //    {
            //        StringBuilder.Replace("-", "");
            //        Convert.ToDouble(StringBuilder);
            //        //Multiplizieren
            //    }
            //    if (StringBuilder[0] == '*')
            //    {
            //        StringBuilder.Replace("*", "");
            //        Convert.ToDouble(StringBuilder);
            //        //Multiplizieren
            //    }
            //    if (StringBuilder[0] == '/')
            //    {
            //        StringBuilder.Replace("/", "");
            //        Convert.ToDouble(StringBuilder);
            //        //Dividieren
            //    }
            //show {ergebnis}

            rechnung.Text = string.Empty;
            ergebnis.Text = NumberResult.ToString();
            StringBuilder = string.Empty;
            NumberValue = 0.0F;
        }

        private double Calculate()
        {
            switch (StringBuilder[0])
            {
                case '/':
                    StringBuilder = StringBuilder.Replace("/", "");
                    return Divide();
                case '+':
                    StringBuilder = StringBuilder.Replace("+", "");
                    return Add();
                case '-':
                    StringBuilder = StringBuilder.Replace("-", "");
                    return Minus();
                case '*':
                    StringBuilder = StringBuilder.Replace("*", "");
                    return Mal();
                default:
                    return 0.0F;
            }
        }

        private double Divide()
        {
            return NumberValue / Convert.ToDouble(StringBuilder);
        }
        
        private double Add()
        {
            return NumberValue + Convert.ToDouble(StringBuilder);
        }
        private double Minus()
        {
            return NumberValue - Convert.ToDouble(StringBuilder);
        }
        private double Mal()
        {
            return NumberValue * Convert.ToDouble(StringBuilder);
        }
    }
}