namespace Gugudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTrun_Click(object sender, EventArgs e)
        {
            TBresult.Text = "구구단 출력\r\n===========";

            TBresult.Text = "";
            for (int j = 2; j <= 9; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    TBresult.Text += String.Format("[{0} x {1}] = {2}\r\n", j, i, j * i);      //j +  "x" + i + " =" +(j*i) + "\r\n";
                }
                TBresult.Text += "============\r\n";
            }
        }
    }
}