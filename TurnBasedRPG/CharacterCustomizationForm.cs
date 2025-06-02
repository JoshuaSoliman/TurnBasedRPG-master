using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class CharacterCustomizationForm : Form
    {
        private Character player1;
        private Character player2;

        private int currentPlayerIndex = 1;
        private Character currentPlayer;

        // Static variant index: 1 or 2 per player
        private int[] classVariantIndex = new int[3]; // [0 unused, 1 = p1, 2 = p2]

        public CharacterCustomizationForm(string player1Name, ClassType player1Class, string player2Name, ClassType player2Class)
        {
            InitializeComponent();

            player1 = new Character(player1Name, player1Class);
            player2 = new Character(player2Name, player2Class);

            currentPlayer = player1;
            currentPlayerIndex = 1;

            classVariantIndex[1] = 1;
            classVariantIndex[2] = 1;

            UpdateUI();
        }

        private void UpdateUI()
        {
            labelTitle.Text = "Customize Your Character";

            labelPlayer1Name.Text = player1.Name;
            labelPlayer2Name.Text = player2.Name;
            labelCurrentPlayer.Text = $"Current: {currentPlayer.Name}";

            UpdateCharacterImage(pictureBoxPlayer1, player1.Class, classVariantIndex[1]);
            UpdateCharacterImage(pictureBoxPlayer2, player2.Class, classVariantIndex[2]);
        }

        private void UpdateCharacterImage(PictureBox pb, ClassType classType, int variant)
        {
            string imageName = $"{classType}{variant}.png"; // e.g., Athlete1.png

            // Construct the path: ...\YourProjectName\Resources\Athlete1.png
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Resources", imageName);

            if (System.IO.File.Exists(imagePath))
            {
                pb.Image = Image.FromFile(imagePath);
            }
            else
            {
                pb.Image = null;
                MessageBox.Show($"Image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonNextVariant_Click(object sender, EventArgs e)
        {
            classVariantIndex[currentPlayerIndex]++;
            if (classVariantIndex[currentPlayerIndex] > 2)
                classVariantIndex[currentPlayerIndex] = 1;
            UpdateUI();
        }

        private void buttonPrevVariant_Click(object sender, EventArgs e)
        {
            classVariantIndex[currentPlayerIndex]--;
            if (classVariantIndex[currentPlayerIndex] < 1)
                classVariantIndex[currentPlayerIndex] = 2;
            UpdateUI();
        }

        private void buttonNextPlayer_Click(object sender, EventArgs e)
        {
            if (currentPlayerIndex == 1)
            {
                currentPlayer = player2;
                currentPlayerIndex = 2;
                UpdateUI();
            }
            else
            {
                // Assign the selected variant to each player's Character object
                player1.Variant = classVariantIndex[1];
                player2.Variant = classVariantIndex[2];

                // Pass customization data to main game
                Form1 mainForm = new Form1(player1, player2);
                mainForm.Show();
                this.Close();
            }
        }
    }
}