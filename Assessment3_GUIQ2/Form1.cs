namespace Assessment3_GUIQ2
{
    public partial class Form1 : Form
    {
        int numTries = 10;
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            randomNumber = random.Next(1, 1001);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            if (numTries <= 0)
            {
                richTextBox.Text = "No tries left! Please restart the game.\n";
                return;
            }


            int number = int.Parse(textGuess.Text);
            numTries--;

            richTextBox.Text += $"Number of tries left {numTries}\n";

            if (number < randomNumber)
            {
                richTextBox.Text += "Too Low, Try Again!\n";
            }
            else if (number > randomNumber)
            {
                richTextBox.Text += "Too High, Try Again!\n";
            }
            else if (number == randomNumber)
            {
                if (numTries > 0)
                {
                    richTextBox.Text += "Either you know the secret or you got lucky!\n";
                    return;
                }
                else if (numTries == 0)
                {
                    richTextBox.Text += "You know the secret!\n";
                    return;
                }
            }

            if (numTries == 0)
            {
                richTextBox.Text += "You should be able to do better!\n";
            }

        }

        private void textGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "Guess a number between 1 and 1000 : \n";
        }
    }
}
