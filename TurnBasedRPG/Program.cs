using System;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show the NameInputForm first to get player names
            using (var nameInputForm = new NameInputForm())
            {
                if (nameInputForm.ShowDialog() == DialogResult.OK)
                {
                    string player1Name = nameInputForm.Player1Name;
                    string player2Name = nameInputForm.Player2Name;

                    // Show the ClassSelectionForm with the entered names
                    using (var classSelectionForm = new ClassSelectionForm(player1Name, player2Name))
                    {
                        Application.Run(classSelectionForm);
                    }
                }
            }
        }
    }
}
