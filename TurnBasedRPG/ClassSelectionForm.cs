using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class ClassSelectionForm : Form
    {
        private string player1Name;
        private string player2Name;

        private Dictionary<ClassType, ClassInfo> classData;

        private ClassType? player1Selection = null;
        private ClassType? player2Selection = null;

        private int currentPlayerSelecting = 1;

        public ClassSelectionForm(string p1Name, string p2Name)
        {
            InitializeComponent();

            player1Name = p1Name;
            player2Name = p2Name;

            labelPlayer1Choice.Text = $"Player 1 ({player1Name}): Not selected";
            labelPlayer2Choice.Text = $"Player 2 ({player2Name}): Not selected";

            labelTitle.Text = $"Player {currentPlayerSelecting} ({player1Name}) - Choose your class";

            SetupClassData();
            CreateClassButtons();
        }

        private void SetupClassData()
        {
            classData = new Dictionary<ClassType, ClassInfo>()
            {
                { ClassType.Athlete, new ClassInfo("Athlete", 100, 10, 9, 1, 20, 5,
                    "Passive: When stress max, stunned 2 turns + attack doubled for 2 turns.") },

                { ClassType.Brainiac, new ClassInfo("Brainiac", 80, 3, 4, 9, 20, 10,
                    "Passive: When attacked gain 2 stress; when opponent max stress, they lose 20% of max stress.") },

                { ClassType.Clown, new ClassInfo("Clown", 90, 7, 6, 5, 15, 7,
                    "Passive: Removes 3 stress every turn; 10% chance to stun opponent (blocks opponent passives).") },

                { ClassType.NewStudent, new ClassInfo("New Student", 85, 4, 4, 4, 15, 9,
                    "Passive: Recovers 5 HP, +1 Attack, Defense and Wits every turn.") },

                { ClassType.Prodigy, new ClassInfo("Prodigy", 80, 15, 15, 8, 10, 5,
                    "Passive: 10% chance to double attack and stress damage.") },
            };
        }

        private void CreateClassButtons()
        {
            panelClassButtons.Controls.Clear();

            foreach (var kvp in classData)
            {
                var btn = new Button()
                {
                    Text = kvp.Value.Name,
                    Tag = kvp.Key,
                    Size = new Size(90, 60),
                    Margin = new Padding(10),
                    BackColor = Color.LightGray,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                };

                btn.MouseHover += ClassButton_MouseHover;
                btn.MouseLeave += ClassButton_MouseLeave;
                btn.Click += ClassButton_Click;

                panelClassButtons.Controls.Add(btn);
            }
        }

        private void ClassButton_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var classType = (ClassType)btn.Tag;
            var info = classData[classType];

            labelClassDescription.Text = info.PassiveDescription;
            labelClassStats.Text =
                $"MaxHp: {info.MaxHp}\n" +
                $"Attack: {info.Attack}\n" +
                $"Defense: {info.Defense}\n" +
                $"Wits: {info.Wits}\n" +
                $"Stress Cap: {info.MaxStress}\n" +
                $"Mental Strength: {info.MentalStrength}";
        }

        private void ClassButton_MouseLeave(object sender, EventArgs e)
        {
            labelClassDescription.Text = "";
            labelClassStats.Text = "";
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var chosenClass = (ClassType)btn.Tag;

            if (currentPlayerSelecting == 1)
            {
                player1Selection = chosenClass;
                labelPlayer1Choice.Text = $"Player 1 ({player1Name}): {classData[chosenClass].Name}";
                currentPlayerSelecting = 2;
                labelTitle.Text = $"Player 2 ({player2Name}) - Choose your class";
            }
            else
            {
                player2Selection = chosenClass;
                labelPlayer2Choice.Text = $"Player 2 ({player2Name}): {classData[chosenClass].Name}";

                buttonNext.Enabled = true;
                labelTitle.Text = "Both players have selected their classes.";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (player1Selection.HasValue && player2Selection.HasValue)
            {
                var charCustomizationForm = new CharacterCustomizationForm(
                    player1Name, player1Selection.Value,
                    player2Name, player2Selection.Value);

                charCustomizationForm.Show();
                this.Hide();
            }
        }
    }

    // Helper class to hold class data
    public class ClassInfo
    {
        public string Name { get; }
        public int MaxHp { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Wits { get; }
        public int MaxStress { get; }
        public int MentalStrength { get; }
        public string PassiveDescription { get; }

        public ClassInfo(string name, int maxHp, int attack, int defense, int wits, int maxStress, int mentalStrength, string passiveDesc)
        {
            Name = name;
            MaxHp = maxHp;
            Attack = attack;
            Defense = defense;
            Wits = wits;
            MaxStress = maxStress;
            MentalStrength = mentalStrength;
            PassiveDescription = passiveDesc;
        }
    }

    // Your existing ClassType enum, for reference
}
