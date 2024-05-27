namespace EMI_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;

            // get the input
            // (p X r X (1+r)n ) / ((1+r)n -1)
            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text) / 1200;
            n = decimal.ToInt32(termnumericUpDown.Value);

            // processing
            emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            totalPayment = emi * n;

            // Output result to label
            // output.Text = "Payment/month is: " + emi.ToString() + "\r\nTotal Payment is: " + totalPayment.ToString();

            string result = "Payment/month is: " + emi.ToString("$0.00") + "\r\n";
                    result += "Total Payment is: " + totalPayment.ToString("$0.00");
            output.Text = result;
        }

        private void termnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;

            // get the input
            // (p X r X (1+r)n ) / ((1+r)n -1)
            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text) / 1200;
            n = decimal.ToInt32(termnumericUpDown.Value);

            // processing
            emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            totalPayment = emi * n;

            // Output result to label
            // output.Text = "Payment/month is: " + emi.ToString() + "\r\nTotal Payment is: " + totalPayment.ToString();

            string result = "Payment/month is: " + emi.ToString("$0.00") + "\r\n";
            result += "Total Payment is: " + totalPayment.ToString("$0.00");
            output.Text = result;
        }

    }
}
