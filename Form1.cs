using System.Data;
namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            textOutput.Text = currentCalculation;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
            string formatedCalculation = currentCalculation.ToString();
            try
            {
                textOutput.Text = new DataTable().Compute(formatedCalculation, null).ToString();
                currentCalculation = textOutput.Text;
            }
            catch (Exception ex)
            {
                textOutput.Text = "ERROR";
                currentCalculation = "";
            }
        }
        private void button_Clear_click(object sender, EventArgs e)
        {
            textOutput.Text = "0";
            currentCalculation = "";
        }
        private void button_clearEntry_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length-1,1);
            }
            textOutput.Text = currentCalculation;
        }
    }
}
