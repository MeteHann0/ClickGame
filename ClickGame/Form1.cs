namespace ClickGame
{
    public partial class Form1 : Form
    {


        System.Windows.Forms.Timer timer;
        bool gameStarted = false;
        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        int count;
        int timeLeft;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                timeLeft = Convert.ToInt32(comboBox1.Text);
                timer1.Start();
            }
            else
            {
                count = Convert.ToInt32(richTextBox1.Text);
                count++;
                richTextBox1.Text = count.ToString();
            }


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeLeft--;
            label2.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                timer1.Stop();
                gameStarted = false;
                MessageBox.Show("Time is over! Your score is " + count);
                richTextBox2.Text += comboBox1.Text + "s" + " ==== " + count.ToString() + " click" + "\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                richTextBox1.Text = "0";
                gameStarted = true;
                timeLeft = Convert.ToInt32(comboBox1.Text);
                timer1.Start();
            }

        }



        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        
    }
}
