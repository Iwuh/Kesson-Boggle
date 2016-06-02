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
        private char[] ALPHABET = new char[100] {'A', 'A', 'A', 'A' , 'A' , 'A', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'D', 'D',
                                                          'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'F', 'F', 'G', 'G', 'G',
                                                          'H', 'H', 'H', 'H', 'H', 'H', 'I', 'I', 'I', 'I', 'I', 'I', 'I', 'J', 'K',
                                                          'L', 'L', 'L', 'L', 'M', 'M', 'N', 'N', 'N', 'N', 'N', 'N', 'N',
                                                          'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'P', 'P', 'Q', 'R', 'R', 'R', 'R', 'R', 'R',
                                                          'S', 'S', 'S', 'S', 'S', 'S', 'T', 'T', 'T', 'T', 'T', 'T', 'T', 'T', 'U', 'U', 'U',
                                                          'V', 'W', 'W', 'X', 'Y', 'Y', 'Z'};

        private char[] VOWELS = new char[35] {'A', 'A', 'A', 'A', 'A', 'A', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E',
                                                       'I', 'I', 'I', 'I', 'I', 'I', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'U', 'U', 'U', 'U'};

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
            GamePanel.ColumnStyles[0].Width = (1F / rowsColumns);
            GamePanel.RowStyles[0].Height = (1F / rowsColumns);
            
            // Expand the TableLayoutPanel to have enough rows/columns for the specified game type
            for (int i = 1; i < rowsColumns; i++)
            {
                // ColumnCount and RowCount need to be manually incremented...
                GamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100F / rowsColumns) / 100));
                GamePanel.ColumnCount++;
                GamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100F / rowsColumns) / 100));
                GamePanel.RowCount++;
            }

            // Shuffle alphabet and variable arrays
            Random shuffle = new Random();
            int n = ALPHABET.Length;
            while (n > 1)
            {
                int k = shuffle.Next(n--);
                char temp = ALPHABET[n];
                ALPHABET[n] = ALPHABET[k];
                ALPHABET[k] = temp;
            }
            n = VOWELS.Length;
            while (n > 1)
            {
                int k = shuffle.Next(n--);
                char temp = VOWELS[n];
                VOWELS[n] = VOWELS[k];
                VOWELS[k] = temp;
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
            // Start with 8/10 chance of any letter and 2/10 chance of vowel
            List<bool> forceVowel = new List<bool>() {true, false, false, false, false, true, false, false, false, false};
            // Makes it impossible to force a vowel twice in a row
            bool forceVowelDisabled = false;
            //i = current row, j = current column
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (forceVowel[rand.Next(0, forceVowel.Count)] && !forceVowelDisabled)
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
                        forceVowel.RemoveRange(10, forceVowel.Count - 10);
                        // Disable vowel force for 1 iteration
                        forceVowelDisabled = true;
                    }
                    else
                    {
                        // Pick a random letter of the alphabet and create a new label
                        char currentLetter = ALPHABET[rand.Next(0, 100)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 80F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                        // Increase chance of next letter being a vowel
                        if (forceVowelDisabled)
                        {
                            forceVowelDisabled = false;
                        }
                        else
                        {
                            forceVowel.Add(true);
                        }
                    }
                }
            }
        }

        private void GenerateWildCardBoard(int boardSize)
        {
            Random rand = new Random();
            //choose random column and row on the board for the wildcard to be placed
            int[] wildCardLocation = new int[2] {rand.Next(0, boardSize), rand.Next(0, boardSize)};
            // Start with 8/10 chance of any letter and 2/10 chance of vowel
            List<bool> forceVowel = new List<bool>() { true, false, false, false, false, true, false, false, false, false };
            // Makes it impossible to force a vowel twice in a row
            bool forceVowelDisabled = false;
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
                    else if (forceVowel[rand.Next(0, forceVowel.Count)] && !forceVowelDisabled)
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
                        forceVowel.RemoveRange(10, forceVowel.Count - 10);
                        // Disable vowel force for 1 iteration
                        forceVowelDisabled = true;
                    }
                    else
                    {
                        // Pick a random letter of the alphabet and create a new label
                        char currentLetter = ALPHABET[rand.Next(0, 100)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 80F),
                            BackColor = Color.White,
                            TextAlign = ContentAlignment.MiddleCenter
                        }, i, j);
                        // Increase chance of next letter being a vowel
                        if (forceVowelDisabled)
                        {
                            forceVowelDisabled = false;
                        }
                        else
                        {
                            forceVowel.Add(true);
                        }
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
