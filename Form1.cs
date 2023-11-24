namespace Assignment_6
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
        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayRound("Rock");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayRound("Scissors");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayRound("Paper");
        }
        private void PlayRound(string userChoice)
        {
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            string[] choices = { "", "Rock", "Scissors", "Paper" };
            string computerChoiceStr = choices[computerChoice];

            lblComputerChoice.Visible = true;
            lblComputerChoice.Text = "Computer chose: " + computerChoiceStr;

            DetermineWinner(userChoice, computerChoiceStr);
        }

        private void DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                lblResult.Visible = true;
                lblResult.Text = "It's a tie! Play again.";
            }
            else if (
                (userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Scissors" && computerChoice == "Paper") ||
                (userChoice == "Paper" && computerChoice == "Rock")
            )
            {
                lblResult.Visible = true;
                lblResult.Text = "You win! " + userChoice + " beats " + computerChoice;
            }
            else
            {
                lblResult.Visible = true;
                lblResult.Text = "Computer wins! " + computerChoice + " beats " + userChoice;
            }
        }
    }
}