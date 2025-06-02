using System;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class NameInputForm : Form
    {
        public string Player1Name => textBoxPlayer1.Text.Trim();
        public string Player2Name => textBoxPlayer2.Text.Trim();

        public NameInputForm()
        {
            InitializeComponent();
        }

        private void buttonSelectCharacter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Player1Name) || string.IsNullOrWhiteSpace(Player2Name))
            {
                MessageBox.Show("Please enter names for both players.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
