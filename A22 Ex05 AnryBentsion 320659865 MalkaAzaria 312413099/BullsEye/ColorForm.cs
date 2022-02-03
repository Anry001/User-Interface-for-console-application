using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BullsEye
{
    public partial class ColorForm : Form
    {
        private Color m_ColorOptions;

        public Color Color
        {
            get { return m_ColorOptions; }
        }

        public void EnableColors()
        {
            foreach (Button button in panelcolors.Controls)
            {
                button.Enabled = true;
                button.Text = string.Empty;
            }
        }

        public void DisableActiveColors(List<Color> i_ColorsToDisable)
        {
            foreach (Button button in panelcolors.Controls)
            {
                foreach (Color color in i_ColorsToDisable)
                {
                    if (button.BackColor == color)
                    {
                        button.Enabled = false;
                        button.Text = "In Use";
                    }
                }
            }
        }

        public ColorForm()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            m_ColorOptions = ((Button) sender).BackColor;
            Close();
        }
    }
}
