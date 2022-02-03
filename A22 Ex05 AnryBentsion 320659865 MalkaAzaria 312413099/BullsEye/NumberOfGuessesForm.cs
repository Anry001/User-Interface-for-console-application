using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullsEye
{
    public partial class NumberOfGuessesForm : Form
    {
        private int m_NumberOfGuesses = 4;

        public NumberOfGuessesForm()
        {
            InitializeComponent();
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            m_NumberOfGuesses++;
            buttonNumberOfChances.Text = string.Format("Number of chances: {0}", (int)m_NumberOfGuesses);

            if (m_NumberOfGuesses > 10) 
            {
                m_NumberOfGuesses = 4;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameBoardForm gameBoard = new GameBoardForm(m_NumberOfGuesses); //should i create it here or make it a field?
            gameBoard.ShowDialog();
            this.Close();
        }
    }
}
