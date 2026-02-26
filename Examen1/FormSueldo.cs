namespace Examen1
{
    public partial class FormSueldo : Form
    {
        public FormSueldo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttCAp_Click(object sender, EventArgs e)
        {//ISR = Cuota fija + (Sueldo − Límite inferior) × Porcentaje
            double sueldoneto = 0;
            double ISR = 0;
            double n = double.Parse(textBox1.Text);
            try { if (n == null || n <= 0)
                    MessageBox.Show("Ingrese un número entero positivo.");
                else
                {
                    if (n <= 746.04)
                        ISR = n - 0.1 * .0192;
                    else if ( n <= 6332.05)
                        ISR = 14.32 + (n - 746.04) * 0.064;
                    else if (n <= 11128.01)
                        ISR = 371.83 + (n - 6332.05) * 0.1088;
                    else if ( n <= 12935.83)
                        ISR = 893.63 + (n - 11128.01) * 0.16;
                    else if ( n <= 15487.71)
                        ISR = 1318.26 + (n - 12935.83) * 0.1792;
                    else if (n <= 31263.49)
                        ISR = 1972.12 + (n - 15487.71) * .2136;
                    else if ( n <= 49233.00)
                        ISR = 5850.76 + (n - 31263.49) * 0.2352;
                    else if ( n <= 93993.9)
                        ISR = 10837.02 + (n - 49233.00) * 0.3;
                    else if ( n <= 125325.2)
                        ISR = 26177.04 + (n - 93993.9) * 0.32;
                    else if (n <= 375975.00)
                        ISR = 38243.68 + (n - 125325.2) * 0.34;
                    else if (n > 375975.00)
                        ISR = 14119.38 + (n - 375975.00) * 0.35;

                    sueldoneto = n - ISR;
                    labelISR.Text = "ISR: " + ISR.ToString();
                    labelSueNet.Text = "Sueldo Neto: " + sueldoneto.ToString();
                }

            } catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }