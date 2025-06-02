namespace TurnBasedRPG
{
    partial class ClassSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private FlowLayoutPanel panelClassButtons;
        private Label labelClassDescription;
        private Label labelClassStats;
        private Label labelPlayer1Choice;
        private Label labelPlayer2Choice;
        private Button buttonNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSelectionForm));
            labelTitle = new Label();
            panelClassButtons = new FlowLayoutPanel();
            labelClassDescription = new Label();
            labelClassStats = new Label();
            labelPlayer1Choice = new Label();
            labelPlayer2Choice = new Label();
            buttonNext = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(760, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Player 1, choose your class";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelClassButtons
            // 
            panelClassButtons.BackColor = Color.Transparent;
            panelClassButtons.Location = new Point(20, 50);
            panelClassButtons.Name = "panelClassButtons";
            panelClassButtons.Size = new Size(500, 300);
            panelClassButtons.TabIndex = 1;
            // 
            // labelClassDescription
            // 
            labelClassDescription.BackColor = Color.Transparent;
            labelClassDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClassDescription.ForeColor = Color.White;
            labelClassDescription.Location = new Point(526, 50);
            labelClassDescription.Name = "labelClassDescription";
            labelClassDescription.Size = new Size(250, 100);
            labelClassDescription.TabIndex = 2;
            labelClassDescription.Text = "Class Description Here";
            // 
            // labelClassStats
            // 
            labelClassStats.BackColor = Color.Transparent;
            labelClassStats.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelClassStats.ForeColor = Color.White;
            labelClassStats.Location = new Point(530, 150);
            labelClassStats.Name = "labelClassStats";
            labelClassStats.Size = new Size(250, 206);
            labelClassStats.TabIndex = 3;
            labelClassStats.Text = "Stats";
            // 
            // labelPlayer1Choice
            // 
            labelPlayer1Choice.BackColor = Color.Transparent;
            labelPlayer1Choice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer1Choice.ForeColor = Color.White;
            labelPlayer1Choice.Location = new Point(20, 360);
            labelPlayer1Choice.Name = "labelPlayer1Choice";
            labelPlayer1Choice.Size = new Size(360, 30);
            labelPlayer1Choice.TabIndex = 4;
            labelPlayer1Choice.Text = "Player 1: Not selected";
            // 
            // labelPlayer2Choice
            // 
            labelPlayer2Choice.BackColor = Color.Transparent;
            labelPlayer2Choice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer2Choice.ForeColor = Color.White;
            labelPlayer2Choice.Location = new Point(400, 360);
            labelPlayer2Choice.Name = "labelPlayer2Choice";
            labelPlayer2Choice.Size = new Size(360, 30);
            labelPlayer2Choice.TabIndex = 5;
            labelPlayer2Choice.Text = "Player 2: Not selected";
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(128, 255, 128);
            buttonNext.Enabled = false;
            buttonNext.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonNext.Location = new Point(530, 393);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(250, 45);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Choose your Outfit!";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // ClassSelectionForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(labelTitle);
            Controls.Add(panelClassButtons);
            Controls.Add(labelClassDescription);
            Controls.Add(labelClassStats);
            Controls.Add(labelPlayer1Choice);
            Controls.Add(labelPlayer2Choice);
            Controls.Add(buttonNext);
            ForeColor = SystemColors.Desktop;
            Name = "ClassSelectionForm";
            Text = "Class Selection";
            ResumeLayout(false);
        }
    }
}
