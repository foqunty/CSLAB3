namespace CSLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        int CountEvenDigits (int number)
        {
            number = Math.Abs(number);
            if (number == 0)
            {
                return 1;
            }
            int count = 0;
            while (number > 0)
            {
                if((number% 10) % 2 == 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(textBox1.Text, out number))
            {
                label1.Text = SumDigits(number).ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            label1.Text = CountEvenDigits(number).ToString();
        }
    }
}
