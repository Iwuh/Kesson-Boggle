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

            // Expand the TableLayoutPanel to have enough rows/columns for the specified game type
            for (int i = 1; i <= rowsColumns; i++)
            {
                // ColumnCount and RowCount need to be manually incremented...
                GamePanel.ColumnStyles.Add(new ColumnStyle());
                GamePanel.ColumnCount++;
                GamePanel.RowStyles.Add(new RowStyle());
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

            GameTimer.Start();
        }

        private void GenerateStandardBoard(int boardSize)
        {
            // Populate each cell with a random letter
            Random rand = new Random();
            //i = current row, j = current column
            for (int i = 0; i <= boardSize; i++)
            {
                for (int j = 0; j <= boardSize; j++)
                {
                    char currentLetter = ALPHABET[rand.Next(0, 26)];
                    GamePanel.Controls.Add(new Label()
                    {
                        Text = currentLetter.ToString(),
                        Dock = DockStyle.Fill,
                        Font = new Font("Bodoni MT", 20F),
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter
                    }, i, j);
                }
            }
        }

        private void GenerateWildCardBoard(int boardSize)
        {
            Random rand = new Random();
            //choose random column and row on the board for the wildcard to be placed
            int[] wildCardLocation = new int[2] {rand.Next(0, boardSize+1), rand.Next(0, boardSize+1) };
            //i = current column, j = current row
            for (int i = 0; i <= boardSize; i++)
            {
                for (int j = 0; j <= boardSize; j++)
                {
                    //If currentLetterIndex is 0 - 25 then it's a letter. If it's 26 then it's the Wildcard.
                    //int currentLetterIndex = rand.Next(0, 27);
                    
                    if (i == wildCardLocation[0] && j == wildCardLocation[1])
                    {
                        PictureBox wildCard = new PictureBox()
                        {
                            Dock = DockStyle.Fill,
                            Image = Boggle.Properties.Resources.star,
                        };

                        GamePanel.Controls.Add(wildCard, i, j);
                        wildCard.Refresh();
                    }
                    else
                    {
                        char currentLetter = ALPHABET[rand.Next(0, 26)];
                        GamePanel.Controls.Add(new Label()
                        {
                            Text = currentLetter.ToString(),
                            Dock = DockStyle.Fill,
                            Font = new Font("Bodoni MT", 20F),
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
                MessageBox.Show("Time's Up!");
                EndEarly.Text = "Close";
                SystemSounds.Exclamation.Play();
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
    }
}
