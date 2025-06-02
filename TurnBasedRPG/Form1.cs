using System;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class Form1 : Form
    {
        private Character player1;
        private Character player2;

        private bool isPlayer1Turn;
        private Random rand = new Random();

        // New constructor accepting player characters
        public Form1(Character p1, Character p2)
        {
            InitializeComponent();

            player1 = p1;
            player2 = p2;

            // Randomly decide who starts first
            isPlayer1Turn = rand.Next(2) == 0;
            LoadCharacterImages();
            UpdateUI();
        }

        // Removed the old StartGame method that creates default characters

        private void UpdateUI(string actionLog = "")
        {
            labelP1Stats.Text = $"{player1.Name} ({player1.Class})\nHP: {player1.Hp}/{player1.MaxHp}\nStress: {player1.Stress}/{player1.MaxStress}";
            labelP2Stats.Text = $"{player2.Name} ({player2.Class})\nHP: {player2.Hp}/{player2.MaxHp}\nStress: {player2.Stress}/{player2.MaxStress}";

            labelTurnInfo.Text = actionLog + "\n" + (isPlayer1Turn ? $"{player1.Name}'s turn." : $"{player2.Name}'s turn.");

            // Refresh HP bars by forcing repaint
            panelP1HPBar.Invalidate();
            panelP2HPBar.Invalidate();

            // Enable or disable buttons based on current player's stun state
            bool isStunned = GetCurrentPlayer().IsStunned;
            buttonAttack.Enabled = !isStunned;
            buttonTaunt.Enabled = !isStunned;
            buttonDefend.Enabled = !isStunned;

            if (isStunned)
            {
                string skipLog = $"\n{GetCurrentPlayer().Name} is stunned! Skipping their turn...";
                EndTurn(skipLog);
                return; // Prevent double UpdateUI
            }
        }

        private void LoadCharacterImages()
        {
            LoadCharacterImage(pictureBoxPlayer1, player1.Class, player1.Variant, false);  // Normal
            LoadCharacterImage(pictureBoxPlayer2, player2.Class, player2.Variant, true);   // Mirrored
        }

        private void LoadCharacterImage(PictureBox pb, ClassType classType, int variant, bool mirror)
        {
            string imageName = $"{classType}{variant}.png";
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Resources", imageName);

            if (System.IO.File.Exists(imagePath))
            {
                Image img = Image.FromFile(imagePath);

                if (mirror)
                {
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX); // Mirror horizontally
                }

                pb.Image = img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage; // Or Zoom
            }
            else
            {
                pb.Image = null;
                MessageBox.Show($"Image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Character GetCurrentPlayer() => isPlayer1Turn ? player1 : player2;
        private Character GetOpponentPlayer() => isPlayer1Turn ? player2 : player1;

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            var attacker = GetCurrentPlayer();
            var defender = GetOpponentPlayer();

            string log = attacker.AttackTarget(defender);

            CheckGameOver();
            EndTurn(log);
        }

        private void buttonTaunt_Click(object sender, EventArgs e)
        {
            var attacker = GetCurrentPlayer();
            var defender = GetOpponentPlayer();

            string log = attacker.Taunt(defender);

            CheckGameOver();
            EndTurn(log);
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            var defender = GetCurrentPlayer();
            string log = defender.Defend();

            EndTurn(log);
        }

        private void EndTurn(string log = "")
        {
            var current = GetCurrentPlayer();
            var opponent = GetOpponentPlayer();

            current.EndTurnReset();
            string passiveLog = "";

            if (current.PassiveTriggered)
            {
                passiveLog += $"\n{current.Name}'s passive effect has activated!";
                current.PassiveTriggered = false; // reset
            }

            if (opponent.PassiveTriggered)
            {
                passiveLog += $"\n{opponent.Name}'s passive effect has activated!";
                opponent.PassiveTriggered = false;
            }

            isPlayer1Turn = !isPlayer1Turn;

            UpdateUI(log + passiveLog);
        }

        private void CheckPassiveTriggers(Character current, Character opponent)
        {
            // Trigger passive effects (some already handled internally)
            current.ApplyPassiveEffects();
            opponent.ApplyPassiveEffects();
        }

        private void CheckGameOver()
        {
            if (!player1.IsAlive)
            {
                ShowVictory(player2.Name);
            }
            else if (!player2.IsAlive)
            {
                ShowVictory(player1.Name);
            }
        }

        private void ShowVictory(string winnerName)
        {
            DisableButtons();
            VictoryForm victoryForm = new VictoryForm(winnerName);
            victoryForm.Show();
            this.Hide(); // Optional: hide main form
        }

        private void DisableButtons()
        {
            buttonAttack.Enabled = false;
            buttonTaunt.Enabled = false;
            buttonDefend.Enabled = false;
        }

        private void panelP1HPBar_Paint(object sender, PaintEventArgs e)
        {
            DrawHPBar(e.Graphics, player1, panelP1HPBar);
        }

        private void panelP2HPBar_Paint(object sender, PaintEventArgs e)
        {
            DrawHPBar(e.Graphics, player2, panelP2HPBar);
        }
        private void DrawHPBar(Graphics g, Character player, Panel panel)
        {
            if (player == null) return;

            float percent = (float)player.Hp / player.MaxHp;
            int width = (int)(panel.Width * percent);
            Color barColor;

            if (percent > 0.5f)
                barColor = Color.Green;
            else if (percent > 0.3f)
                barColor = Color.Orange;
            else if (percent > 0)
                barColor = Color.Red;
            else
                barColor = Color.Transparent;

            using (Brush brush = new SolidBrush(barColor))
            {
                g.FillRectangle(brush, 0, 0, width, panel.Height);
            }

            // Optional: draw a border
            using (Pen borderPen = new Pen(Color.Black))
            {
                g.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
            }

            string hpText = $"{player.Hp}/{player.MaxHp}";
            using (Font font = new Font("Arial", 10, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.White))
            using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString(hpText, font, textBrush, new RectangleF(0, 0, panel.Width, panel.Height), format);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void labelTurnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
