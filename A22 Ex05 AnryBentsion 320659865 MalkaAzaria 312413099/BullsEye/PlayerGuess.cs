using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BullsEye
{
    public class PlayerGuess : UserControl
    {

        private readonly ColorForm r_ColorForm = new ColorForm();
        private ConfirmArrowAndResults m_Results = null;
        private Panel guessesPanel;
        private Button buttonGuess2;
        private Button buttonGuess3;
        private Button buttonGuess4;
        private Button buttonGuess1;

        public Panel Panel
        {
            get { return guessesPanel; }
        }

        public PlayerGuess()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.guessesPanel = new System.Windows.Forms.Panel();
            this.buttonGuess1 = new System.Windows.Forms.Button();
            this.buttonGuess2 = new System.Windows.Forms.Button();
            this.buttonGuess3 = new System.Windows.Forms.Button();
            this.buttonGuess4 = new System.Windows.Forms.Button();
            this.guessesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guessesPanel
            // 
            this.guessesPanel.Controls.Add(this.buttonGuess1);
            this.guessesPanel.Controls.Add(this.buttonGuess2);
            this.guessesPanel.Controls.Add(this.buttonGuess3);
            this.guessesPanel.Controls.Add(this.buttonGuess4);
            this.guessesPanel.Location = new System.Drawing.Point(0, 3);
            this.guessesPanel.Name = "guessesPanel";
            this.guessesPanel.Size = new System.Drawing.Size(335, 84);
            this.guessesPanel.TabIndex = 0;
            // 
            // buttonGuess1
            // 
            this.buttonGuess1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGuess1.Location = new System.Drawing.Point(6, 3);
            this.buttonGuess1.Name = "buttonGuess1";
            this.buttonGuess1.Size = new System.Drawing.Size(75, 75);
            this.buttonGuess1.TabIndex = 0;
            this.buttonGuess1.UseVisualStyleBackColor = false;
            this.buttonGuess1.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess2
            // 
            this.buttonGuess2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGuess2.Location = new System.Drawing.Point(87, 3);
            this.buttonGuess2.Name = "buttonGuess2";
            this.buttonGuess2.Size = new System.Drawing.Size(75, 75);
            this.buttonGuess2.TabIndex = 3;
            this.buttonGuess2.UseVisualStyleBackColor = false;
            this.buttonGuess2.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess3
            // 
            this.buttonGuess3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGuess3.Location = new System.Drawing.Point(168, 3);
            this.buttonGuess3.Name = "buttonGuess3";
            this.buttonGuess3.Size = new System.Drawing.Size(75, 75);
            this.buttonGuess3.TabIndex = 2;
            this.buttonGuess3.UseVisualStyleBackColor = false;
            this.buttonGuess3.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess4
            // 
            this.buttonGuess4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGuess4.Location = new System.Drawing.Point(249, 3);
            this.buttonGuess4.Name = "buttonGuess4";
            this.buttonGuess4.Size = new System.Drawing.Size(75, 75);
            this.buttonGuess4.TabIndex = 1;
            this.buttonGuess4.UseVisualStyleBackColor = false;
            this.buttonGuess4.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // PlayerGuess
            // 
            this.Controls.Add(this.guessesPanel);
            this.Name = "PlayerGuess";
            this.Size = new System.Drawing.Size(344, 104);
            this.guessesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void colorsToDisable()
        {
            List<Color> colorsToDisable = new List<Color>(4);

            foreach (Button button in guessesPanel.Controls)
            {
                if (button.BackColor.Name != "ActiveBorder")
                {
                    colorsToDisable.Add(button.BackColor);
                }
            }

            r_ColorForm.EnableColors();
            r_ColorForm.DisableActiveColors(colorsToDisable);
        }

        public void AddResult(ConfirmArrowAndResults i_Result)
        {
            m_Results = i_Result;
        }

        private void CheckThatAllButtonsBeenColored()
        {
            bool isEnabled = true;

            foreach (Button button in guessesPanel.Controls)
            {
                if (button.BackColor.Name == "ActiveBorder")
                {
                    isEnabled = false;
                }
            }

            m_Results.Enabled = isEnabled;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            colorsToDisable();
            DialogResult result = r_ColorForm.ShowDialog();
            
            if (result != DialogResult.Cancel)
            {
                ((Button)sender).BackColor = r_ColorForm.Color;
            }

            CheckThatAllButtonsBeenColored();
        }
    }
}