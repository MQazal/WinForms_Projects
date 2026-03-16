using System;
using System.Linq;
using System.Windows.Forms;
using RepeatedNumberGame.Properties;

namespace RepeatedNumberGame
{
    public partial class Form1 : Form
    {
        private byte RoundNumber = 0;

        private Random random = new Random();

        private byte RandomNumber = 0;

        private byte[] arrRandomNumbers = new byte[25];

        private TextBox[] arrTextBoxes = new TextBox[25];

        private byte RoundSeconds = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private byte GetRandomNumber(byte From, byte To)
        {
            return (byte)random.Next(From, To + 1);
        }

        private void FillRandomNumbersArray()
        {
            for (byte i = 0; i < arrRandomNumbers.Length; i++)
            {
                arrRandomNumbers[i] = GetRandomNumber(0, 9);
            }
        }

        private void OrderTextBoxesArray()
        {
            arrTextBoxes = panel_RandomNumber.Controls.OfType<TextBox>().OrderBy(box => Convert.ToInt32(box.Tag)).ToArray();
        }

        private void InitilizeGameState()
        {
            btnCheck.Enabled = false;
            btnRestart.Enabled = false;
            lblTimer.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeGameState();
            OrderTextBoxesArray();
            this.BackgroundImage = Resources.BackGround4;
        }

        private bool IsRoundsNumberEqualZero()
        {
            return numGameRounds.Value == 0;
        }

        private void UpdateRoundSecondsText()
        {
            lblTimer.Text = RoundSeconds.ToString();
        }

        private void HandleRoundTimer()
        {
            if (RoundSeconds == 0)
            {
                RoundTimer.Enabled = false;
                MessageBox.Show("Time is Finish!", "End of Round", MessageBoxButtons.OK);
                StartNewRound();
            }
            else
                RoundSeconds--;
        }

        private void ShowTimer()
        {
            HandleRoundTimer();
            UpdateRoundSecondsText();
            
        }

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            ShowTimer();
        }

        private void StartNewRoundTimer()
        {
            lblTimer.Text = "15";
            RoundSeconds = 15;
            RoundTimer.Enabled = true;
        }

        private void StartNewRound()
        {
            RoundNumber++;
            if (RoundNumber <= numGameRounds.Value)
            {
                FillRandomNumbersArray();
                FillTextBoxesByRandomNumbers();
                SetRoundNumber();
                GetRandomNumberOfRound();
                tbxRepeatedTimes.Clear();
                StartNewRoundTimer();
            }
            else
            {
                MessageBox.Show("Game Over", "End", MessageBoxButtons.OK);
                ResetGame();
            }
        }

        private void SetRoundNumber()
        {
            tbxRoundNumber.Text = RoundNumber.ToString();
        }

        private void FillTextBoxesByRandomNumbers()
        {
            for (byte i = 0; i < arrRandomNumbers.Length; i++)
            {
                arrTextBoxes[i].Text = arrRandomNumbers[i].ToString();
            }
        }

        private void StartGameTimer()
        {
            lblTimer.Visible = true;
            RoundTimer.Enabled = true;
        }

        private void StartGame()
        {
            btnCheck.Enabled = true;
            btnRestart.Enabled = true;
            RoundNumber += 1;
            SetRoundNumber();
            FillRandomNumbersArray();
            FillTextBoxesByRandomNumbers();
            GetRandomNumberOfRound();
            btnStart.Enabled = false;
            tbxRepeatedTimes.Focus();
        }

        // Repeated Number's Algorithms

        private byte CountRandomNumberRepeatedTimes()
        {
            byte Counter = 0;
            for (byte i = 0; i < arrRandomNumbers.Length; i++)
            {
                if (arrRandomNumbers[i] == RandomNumber)
                    Counter++;
            }
            return Counter;
        }

        private void GetRandomNumberOfRound()
        {
            RandomNumber = GetRandomNumber(0, 9);
            tbxRepeatedNumber.Text = RandomNumber.ToString();
        }

        private bool IsRepeatedTimesTrue()
        {
            return Convert.ToInt32(tbxRepeatedTimes.Text) == CountRandomNumberRepeatedTimes();
        }

        private void HandleRepeatedNumberGuess()
        {
            if (IsRepeatedTimesTrue())
            {
                RoundTimer.Enabled = false;
                MessageBox.Show("Right Answer!", "Win", MessageBoxButtons.OK);
                StartNewRound();
            }
            else
                MessageBox.Show("Wrong Answer!", "Continue", MessageBoxButtons.OK);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            HandleRepeatedNumberGuess();
        }

        //

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsRoundsNumberEqualZero())
            {
                errorProvider1.SetError(numGameRounds, "Enter number between 1 and 10.");
                return;
            }
            errorProvider1.Clear();
            StartGameTimer();
            StartGame();
        }

        private void ClearRandomNumbersBoxes()
        {
            for (byte i = 0; i < arrTextBoxes.Length; i++)
            {
                arrTextBoxes[i].Clear();
            }
        }

        private void ClearRoundInfoBoxes()
        {
            numGameRounds.Value = 0;
            tbxRoundNumber.Clear();
            RoundNumber = 0;
            tbxRepeatedNumber.Clear();
            tbxRepeatedTimes.Clear();
        }

        private void ResetTimer()
        {
            RoundTimer.Enabled = false;
            lblTimer.Text = "15";
            RoundSeconds = 15;
        }

        private void ResetGame()
        {
            ResetTimer();
            ClearRandomNumbersBoxes();
            ClearRoundInfoBoxes();
            InitilizeGameState();
            btnStart.Enabled = true;
            tbxRepeatedTimes.Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}