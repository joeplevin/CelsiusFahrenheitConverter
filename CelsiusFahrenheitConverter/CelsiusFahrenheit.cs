using System.Text.RegularExpressions;
namespace CelsiusFahrenheitConverter
{
    public partial class CelsiusFahrenheit : Form
    {
        //initialize temperature scales for later use
        public double[] baseTemps = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140 };
        public double[] fahTemps = new double[14];
        public double[] celTemps = new double[14];


        public CelsiusFahrenheit()
        {
            InitializeComponent();
        }

        private void CelsiusFahrenheit_Load(object sender, EventArgs e)
        {
            // Set combobox value to avoid errors
            cbTempFormat.SelectedIndex = 0;
            // Hide error message & result label
            labelError.Visible = false;
            labelResult.Visible = false;
            //Tableview setup
            setTable();


        }

        private void tbTempInput_TextChanged(object sender, EventArgs e)
        {
            calculateTemp(tbTempInput.Text,cbTempFormat.SelectedIndex);
        }

        private void cbTempFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTemp(tbTempInput.Text,cbTempFormat.SelectedIndex);
        }
        
        //Index: 0 is Celsius, 1 is Fahrenheit
        private void calculateTemp(String input, int index)
        {
            // Check input is not null
            if (input != null)
            {
                // Check input is number
                int val;
                if (int.TryParse(input, out val))
                {
                    labelError.Visible = false;
                    labelResult.Visible = true;
                    // Check desired temperature format is selected
                    if (index != null)
                    {
                        // Convert celsius to fahrenheit
                        if (index == 0)
                        {
                            double res = Math.Round((1.8 * val) + 32, 4);
                            labelResult.Text = res + "°F";
                        }

                        // Convert fahrenheit to celsius
                        if (index == 1)
                        {
                            double res = Math.Round((val / 1.8) - 32, 4);
                            labelResult.Text = res + "°C";
                        }
                    }
                }
                else
                {
                    labelError.Visible = true;
                    labelResult.Visible = false;
                }
            }
            // Catch empty Textbox or minus sign
            if (input == "" || input == "-")
            {
                labelError.Visible = false;
                labelResult.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] cLabels = { labelR1C1, labelR1C2, labelR1C3, labelR1C4, labelR1C5, labelR1C6, labelR1C7, labelR1C8, labelR1C9, labelR1C10, labelR1C11, labelR1C12, labelR1C13, labelR1C14 };
            Label[] fLabels = { labelR2C1, labelR2C2, labelR2C3, labelR2C4, labelR2C5, labelR2C6, labelR2C7, labelR2C8, labelR2C9, labelR2C10, labelR2C11, labelR2C12, labelR2C13, labelR2C14 };
            //Switch conversion
            if (cLabels[0].Text.Equals("10"))
            {
                for (int i = 0; i < baseTemps.Length; i++)
                {
                    fLabels[i].Text = baseTemps[i].ToString();
                    cLabels[i].Text = celTemps[i].ToString();
                }
            }
            //Reset conversion
            else 
            {
                setTable();
            }
        }
        private void setTable() 
        {
            //Table labels R = row, C = column etc, cLabels is celsius row, fLabels is fahrenheit
            Label[] cLabels = { labelR1C1, labelR1C2, labelR1C3, labelR1C4, labelR1C5, labelR1C6, labelR1C7, labelR1C8, labelR1C9, labelR1C10, labelR1C11, labelR1C12, labelR1C13, labelR1C14 };
            Label[] fLabels = { labelR2C1, labelR2C2, labelR2C3, labelR2C4, labelR2C5, labelR2C6, labelR2C7, labelR2C8, labelR2C9, labelR2C10, labelR2C11, labelR2C12, labelR2C13, labelR2C14 };
            //Convert dynamically
            for (int i = 0; i < baseTemps.Length; i++)
            {
                fahTemps[i] = (baseTemps[i] * 1.8) + 32;
                celTemps[i] = (baseTemps[i] / 1.8) - 32;
                cLabels[i].Text = baseTemps[i].ToString();
                fLabels[i].Text = fahTemps[i].ToString();
            }
        }
    }
}