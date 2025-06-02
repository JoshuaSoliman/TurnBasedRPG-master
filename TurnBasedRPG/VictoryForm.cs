using System;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class VictoryForm : Form
    {
        public VictoryForm(string winnerName)
        {
            InitializeComponent();
            labelMessage.Text = $"🎉 CONGRATULATIONS {winnerName.ToUpper()}, YOU WON! 🎉";
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the whole app
        }
    }
}