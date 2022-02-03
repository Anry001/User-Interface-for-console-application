using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BullsEye
{
    public class ConfirmArrowAndResults : UserControl
    {
        private readonly PlayerGuess r_CurrentPlayerGuess = null;
        private readonly List<eGameColors> r_ComputerGeneratedColors = null;
        private readonly int r_CurrentGuessIndex = 0;
        private readonly List<Button> r_ComputerGuessButtons = null;
        private List<PlayerGuess> m_PlayerGuesses = null;
        private Button buttonArrow;
        private Button buttonResult1;
        private Button buttonResult2;
        private Button buttonResult3;
        private Button buttonResult4;
        private Panel panelResult;
        private Panel panelConfirmArrow;

        public ConfirmArrowAndResults(PlayerGuess i_CurrentPlayerGuess, List<PlayerGuess> i_PlayerGuesses, 
            List<eGameColors> i_ComputerGeneratedColors, List<Button> i_ComputerGuessButtons, int i_CurrentGuessIndex, GameBoardForm i_GameBoard)
        {
            InitializeComponent();
            r_CurrentPlayerGuess = i_CurrentPlayerGuess;
            r_ComputerGeneratedColors = i_ComputerGeneratedColors;
            r_ComputerGuessButtons = i_ComputerGuessButtons;
            r_CurrentGuessIndex = i_CurrentGuessIndex;
            m_PlayerGuesses = i_PlayerGuesses;
        }

        private void InitializeComponent()
        {
            this.buttonArrow = new System.Windows.Forms.Button();
            this.panelConfirmArrow = new System.Windows.Forms.Panel();
            this.buttonResult1 = new System.Windows.Forms.Button();
            this.buttonResult2 = new System.Windows.Forms.Button();
            this.buttonResult3 = new System.Windows.Forms.Button();
            this.buttonResult4 = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelConfirmArrow.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonArrow
            // 
            this.buttonArrow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArrow.Location = new System.Drawing.Point(3, 3);
            this.buttonArrow.Name = "buttonArrow";
            this.buttonArrow.Size = new System.Drawing.Size(84, 41);
            this.buttonArrow.TabIndex = 0;
            this.buttonArrow.Text = "-->>";
            this.buttonArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArrow.UseVisualStyleBackColor = true;
            this.buttonArrow.Click += new System.EventHandler(this.buttonArrow_Click);
            // 
            // panelConfirmArrow
            // 
            this.panelConfirmArrow.Controls.Add(this.buttonArrow);
            this.panelConfirmArrow.Location = new System.Drawing.Point(3, 23);
            this.panelConfirmArrow.Name = "panelConfirmArrow";
            this.panelConfirmArrow.Size = new System.Drawing.Size(90, 47);
            this.panelConfirmArrow.TabIndex = 1;
            // 
            // buttonResult1
            // 
            this.buttonResult1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult1.Location = new System.Drawing.Point(8, 10);
            this.buttonResult1.Name = "buttonResult1";
            this.buttonResult1.Size = new System.Drawing.Size(32, 32);
            this.buttonResult1.TabIndex = 2;
            this.buttonResult1.UseVisualStyleBackColor = false;
            // 
            // buttonResult2
            // 
            this.buttonResult2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult2.Location = new System.Drawing.Point(46, 10);
            this.buttonResult2.Name = "buttonResult2";
            this.buttonResult2.Size = new System.Drawing.Size(32, 32);
            this.buttonResult2.TabIndex = 4;
            this.buttonResult2.UseVisualStyleBackColor = false;
            // 
            // buttonResult3
            // 
            this.buttonResult3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult3.Location = new System.Drawing.Point(8, 48);
            this.buttonResult3.Name = "buttonResult3";
            this.buttonResult3.Size = new System.Drawing.Size(32, 32);
            this.buttonResult3.TabIndex = 5;
            this.buttonResult3.UseVisualStyleBackColor = false;
            // 
            // buttonResult4
            // 
            this.buttonResult4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult4.Location = new System.Drawing.Point(46, 48);
            this.buttonResult4.Name = "buttonResult4";
            this.buttonResult4.Size = new System.Drawing.Size(32, 32);
            this.buttonResult4.TabIndex = 3;
            this.buttonResult4.UseVisualStyleBackColor = false;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.buttonResult1);
            this.panelResult.Controls.Add(this.buttonResult2);
            this.panelResult.Controls.Add(this.buttonResult3);
            this.panelResult.Controls.Add(this.buttonResult4);
            this.panelResult.Enabled = false;
            this.panelResult.Location = new System.Drawing.Point(96, 3);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(89, 89);
            this.panelResult.TabIndex = 6;
            // 
            // ConfirmArrowAndResults
            // 
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelConfirmArrow);
            this.Name = "ConfirmArrowAndResults";
            this.Size = new System.Drawing.Size(205, 95);
            this.panelConfirmArrow.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        public void AddGuessList(List<PlayerGuess> i_GuessList)
        {
            m_PlayerGuesses = i_GuessList;
        }

        private void generatePlayerResult()
        {
            List<Color> resultButtons = new List<Color>();
            List<Color> computerGeneratedGuess = new List<Color>();

            foreach (eGameColors color in r_ComputerGeneratedColors)
            {
                computerGeneratedGuess.Add(Color.FromName(color.ToString()));
            }

            for (int i = 0; i < panelResult.Controls.Count; i++)
            {
                if (Color.FromName(r_ComputerGeneratedColors[i].ToString()) == r_CurrentPlayerGuess.Panel.Controls[i].BackColor)
                {
                    resultButtons.Insert(0, Color.Black);
                }
                else if (computerGeneratedGuess.Contains(r_CurrentPlayerGuess.Panel.Controls[i].BackColor))
                {
                    resultButtons.Add(Color.Yellow);
                }
            }

            for (int i = 0; i < resultButtons.Count; i++)
            {
                panelResult.Controls[i].BackColor = resultButtons[i];
            }
        }

        private void checkIfPlayerWon()
        {
            bool isWin = true;

            foreach (Button button in panelResult.Controls)
            {
                if (button.BackColor != Color.Black)
                {
                    isWin = false;
                }
            }

            if (isWin)
            {
                for (int i = 0; i < r_ComputerGeneratedColors.Count; i++)
                {
                    r_ComputerGuessButtons[i].BackColor = Color.FromName(r_ComputerGeneratedColors[i].ToString());
                }

                foreach (var guess in m_PlayerGuesses)
                {
                    guess.Enabled = false;
                }
            }
            else if (r_CurrentGuessIndex < m_PlayerGuesses.Capacity - 1)
            {
                m_PlayerGuesses[r_CurrentGuessIndex + 1].Enabled = true;
            }
            else
            {
                for (int i = 0; i < r_ComputerGeneratedColors.Count; i++)
                {
                    r_ComputerGuessButtons[i].BackColor = Color.FromName(r_ComputerGeneratedColors[i].ToString());
                }
            }
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            this.panelConfirmArrow.Enabled = false;
            r_CurrentPlayerGuess.Enabled = false;
            generatePlayerResult();
            checkIfPlayerWon();
        }
    }
}
