using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BullsEye
{
    public partial class GameBoardForm : Form
    {
        private readonly List<PlayerGuess> r_PlayerGuesses = null;
        private readonly List<ConfirmArrowAndResults> r_PlayerResults = null;
        private List<eGameColors> m_ComputerGeneratedGuess = null;

        public GameBoardForm(int i_NumberOfGuesses)
        {
            r_PlayerGuesses = new List<PlayerGuess>(i_NumberOfGuesses);
            r_PlayerResults = new List<ConfirmArrowAndResults>(i_NumberOfGuesses);
            InitializeComponent();
            generateRandomComputerGuess();
            setTheAmountOfGuesses();
        }

        private void setTheAmountOfGuesses()
        {
            int guessYAxisLocation = 100;
            int gameFormYAxisSize = 200;
            List<Button> computerButtons = new List<Button>();

            foreach (Button button in computersGuessPanel.Controls)
            {
                computerButtons.Add(button);
            }

            for (int i = 0; i < r_PlayerGuesses.Capacity; i++)
            {
                r_PlayerGuesses.Add(new PlayerGuess());
                r_PlayerGuesses[i].Location = new System.Drawing.Point(12, guessYAxisLocation);
                r_PlayerGuesses[i].Size = new System.Drawing.Size(325, 81);
                this.ClientSize = new System.Drawing.Size(569, gameFormYAxisSize);
                this.Controls.Add(r_PlayerGuesses[i]);
                r_PlayerGuesses[i].Enabled = false;
                r_PlayerResults.Add(new ConfirmArrowAndResults(r_PlayerGuesses[i], r_PlayerGuesses, m_ComputerGeneratedGuess, computerButtons, i, this));
                r_PlayerResults[i].Location = new System.Drawing.Point(345, guessYAxisLocation);
                r_PlayerResults[i].Size = new System.Drawing.Size(300, 87);
                this.Controls.Add(r_PlayerResults[i]);
                r_PlayerResults[i].Enabled = false;
                r_PlayerGuesses[i].AddResult(r_PlayerResults[i]);
                guessYAxisLocation += 75;
                gameFormYAxisSize += 75;
            }

            r_PlayerGuesses[0].Enabled = true;
            foreach (ConfirmArrowAndResults result in r_PlayerResults)
            {
                result.AddGuessList(r_PlayerGuesses);
            }
        }

        private void generateRandomComputerGuess()
        {
            int randomIndex = 0;
            Random randomColorGenerator = new Random();
            m_ComputerGeneratedGuess = new List<eGameColors>(4);
            List<eGameColors> allGameColors = new List<eGameColors>(8)
            {
                eGameColors.Fuchsia, eGameColors.Red, eGameColors.Lime, eGameColors.Aqua,
                eGameColors.Blue, eGameColors.Yellow, eGameColors.Maroon, eGameColors.White
            };

            for (int i = 0; i < m_ComputerGeneratedGuess.Capacity; i++)
            {
                randomIndex = randomColorGenerator.Next(allGameColors.Count);
                while (m_ComputerGeneratedGuess.Contains(allGameColors[randomIndex]))
                {
                    randomIndex = randomColorGenerator.Next(allGameColors.Count);
                }

                m_ComputerGeneratedGuess.Add(allGameColors[randomIndex]);
            }
        }
    }
}