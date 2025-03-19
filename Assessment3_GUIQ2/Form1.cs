namespace Assessment3_GUIQ2
{
    public partial class Form1 : Form
    {
        int numTries = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            numTries--;

            Random random = new Random();
            int randomNumber = random.Next(1, 1001);

            richTextBox.Text = "Guess a number between 1 and 1000 : \n";

            int number = int.Parse(textGuess.Text);
            
            richTextBox.Text += $"Number of tries left {numTries}\n";

            if (number < randomNumber && numTries != 0)
            {
               richTextBox.Text += "Too Low, Try Again!\n";
            }
            else if (number > randomNumber && numTries != 0)
            {
                richTextBox.Text += "Too High, Try Again!\n";
            }
            else if (number == randomNumber)
            {
                if (numTries > 0)
                {
                    richTextBox.Text += "Either you know the secret or you got lucky!\n";
                }
                else if (numTries == 0)
                {
                        richTextBox.Text += "You know the secret!\n";
                }
            }

            if (numTries == 0)
            {
                richTextBox.Text += "You should be able to do better!\n";
            }

        }
    }
}
