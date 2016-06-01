using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boggle
{
    public partial class Game : Form
    {
        private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string VOWELS = "AEIOU";

        private int timeLeft;

        public enum Modes
        {
            Standard, Wildcard, Custom
        }

        public Game()
        {
            InitializeComponent();
        }

        public Game(int time, int rowsColumns, Modes mode)
        {
            InitializeComponent();

            timeLeft = time;
            Time.Text = time.ToString();
            
            // Adjust size of original row/column
            GamePanel.ColumnStyles[0].Width = (100F / rowsColumns) / 100;
            GamePanel.RowStyles[0].Height = (100F / rowsColumns) / 100;
            
            // Expand the TableLayoutPanel to have enough rows/columns for the specified game type
            for (int i = 1; i < rowsColumns; i++)
            {
                // ColumnCount and RowCount need to be manually incremented...
                GamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100F / rowsColumns) / 100));
                GamePanel.ColumnCount++;
                GamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100F / rowsColumns) / 100));
                GamePanel.RowCount++;
            }

            switch (mode)
            {
                case Modes.Standard:
                    GenerateStandardBoard(rowsColumns);
                    CurrentMode.Text = "Current Mode: Standard";
                    break;
                case Modes.Wildcard:
                    GenerateWildCardBoard(rowsColumns);
                    CurrentMode.Text = "Current Mode: Wild Card";
                    break;
                case Modes.Custom:
                    GenerateStandardBoard(rowsColumns);
                    CurrentMode.Text = "Current Mode: Custom";
                    break;
            }
        }

        private void GenerateStandardBoard(int boardSize)
        {
            Random rand = new Random();
            // Start with 7/10 chance of any letter and 3/10 chance of vowel
            List<bool> forceVowel = new List<bool>() {false, false, true, false, false, true, false, false, true, false};
            //i = current row, j = current column
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (forceVowel[rand.Next(0, forceVowel.Count)])
                    {
                        // Pick a random vowel and create a new label
                        char currentLetter = VOWELS[rand.Next(0, 5)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 80F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                        // Reset forceVowel to default chances
                        int currentListSize = forceVowel.Count;
                        forceVowel.RemoveRange(10, forceVowel.Count - 10);
                    }
                    else
                    {
                        // Pick a random letter of the alphabet and create a new label
                        char currentLetter = ALPHABET[rand.Next(0, 26)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 80F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                        // Increase chance of next letter being a vowel
                        forceVowel.Add(true);
                    }
                }
            }
        }

        private void GenerateWildCardBoard(int boardSize)
        {
            Random rand = new Random();
            //choose random column and row on the board for the wildcard to be placed
            int[] wildCardLocation = new int[2] {rand.Next(0, boardSize), rand.Next(0, boardSize) };
            //i = current column, j = current row
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i == wildCardLocation[0] && j == wildCardLocation[1])
                    {
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = "*",
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 120F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                    }
                    else
                    {
                        char currentLetter = ALPHABET[rand.Next(0, 26)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 80F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                    }
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            Time.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                GameTimer.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Time's Up!");
                EndEarly.Text = "Close";
            }
        }

        private void ShowScoreInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("< 3 letters: 0 points\n 4 letters: 3 points\n 5 letters: 10 points\n 6 letters: 20 points\n 7 letters: 30 points\n etc...", "Scoring Info");
        }

        private void EndEarly_Click(object sender, EventArgs e)
        {
            if (EndEarly.Text == "End Now")
            {
                GameTimer.Stop();
                Time.Text = "Stopped";
                EndEarly.Text = "Close";
            }
            else
            {
                Close();
            }
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            GameTimer.Start();
        }
    }
}
