namespace EventController.Views
{
    partial class StartSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.SessionTextBox = new System.Windows.Forms.TextBox();
			this.PlayerButton = new System.Windows.Forms.Button();
			this.TeamButton = new System.Windows.Forms.Button();
			this.StartButton = new System.Windows.Forms.Button();
			this.participantPlayers = new System.Windows.Forms.TextBox();
			this.participantTeams = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SessionTextBox
			// 
			this.SessionTextBox.Location = new System.Drawing.Point(12, 12);
			this.SessionTextBox.Multiline = true;
			this.SessionTextBox.Name = "SessionTextBox";
			this.SessionTextBox.Size = new System.Drawing.Size(718, 67);
			this.SessionTextBox.TabIndex = 0;
			this.SessionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// PlayerButton
			// 
			this.PlayerButton.Location = new System.Drawing.Point(464, 106);
			this.PlayerButton.Name = "PlayerButton";
			this.PlayerButton.Size = new System.Drawing.Size(221, 36);
			this.PlayerButton.TabIndex = 3;
			this.PlayerButton.Text = "Player Confirmation";
			this.PlayerButton.UseVisualStyleBackColor = true;
			this.PlayerButton.Click += new System.EventHandler(this.PlayerButton_Click);
			// 
			// TeamButton
			// 
			this.TeamButton.Location = new System.Drawing.Point(66, 106);
			this.TeamButton.Name = "TeamButton";
			this.TeamButton.Size = new System.Drawing.Size(231, 36);
			this.TeamButton.TabIndex = 4;
			this.TeamButton.Text = "Team Confirmation";
			this.TeamButton.UseVisualStyleBackColor = true;
			this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(24, 670);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(273, 41);
			this.StartButton.TabIndex = 6;
			this.StartButton.Text = "Start Session";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// participantPlayers
			// 
			this.participantPlayers.Location = new System.Drawing.Point(386, 166);
			this.participantPlayers.Multiline = true;
			this.participantPlayers.Name = "participantPlayers";
			this.participantPlayers.ReadOnly = true;
			this.participantPlayers.Size = new System.Drawing.Size(344, 545);
			this.participantPlayers.TabIndex = 40;
			// 
			// participantTeams
			// 
			this.participantTeams.Location = new System.Drawing.Point(19, 166);
			this.participantTeams.Multiline = true;
			this.participantTeams.Name = "participantTeams";
			this.participantTeams.ReadOnly = true;
			this.participantTeams.Size = new System.Drawing.Size(316, 353);
			this.participantTeams.TabIndex = 39;
			// 
			// StartSession
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 799);
			this.Controls.Add(this.participantPlayers);
			this.Controls.Add(this.participantTeams);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.TeamButton);
			this.Controls.Add(this.PlayerButton);
			this.Controls.Add(this.SessionTextBox);
			this.Name = "StartSession";
			this.Text = "StartSession";
			this.Load += new System.EventHandler(this.StartSession_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.TextBox participantPlayers;
		private System.Windows.Forms.TextBox participantTeams;
	}
}