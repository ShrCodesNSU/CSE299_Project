namespace EventController.Views
{
    partial class TeamSelection
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
			this.ClearButton = new System.Windows.Forms.Button();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.TeamListViewBox = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// SessionTextBox
			// 
			this.SessionTextBox.Location = new System.Drawing.Point(12, 12);
			this.SessionTextBox.Multiline = true;
			this.SessionTextBox.Name = "SessionTextBox";
			this.SessionTextBox.Size = new System.Drawing.Size(741, 80);
			this.SessionTextBox.TabIndex = 1;
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(526, 605);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(115, 49);
			this.ClearButton.TabIndex = 2;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(647, 605);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(106, 49);
			this.SubmitButton.TabIndex = 3;
			this.SubmitButton.Text = "Submit";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// TeamListViewBox
			// 
			this.TeamListViewBox.CheckBoxes = true;
			this.TeamListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.TeamListViewBox.HideSelection = false;
			this.TeamListViewBox.Location = new System.Drawing.Point(12, 132);
			this.TeamListViewBox.Name = "TeamListViewBox";
			this.TeamListViewBox.Size = new System.Drawing.Size(741, 467);
			this.TeamListViewBox.TabIndex = 9;
			this.TeamListViewBox.UseCompatibleStateImageBehavior = false;
			this.TeamListViewBox.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Team ID";
			this.columnHeader1.Width = 159;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Team Name";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Owner Name";
			this.columnHeader3.Width = 183;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Manager Name";
			this.columnHeader4.Width = 200;
			// 
			// TeamSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 666);
			this.Controls.Add(this.TeamListViewBox);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.SessionTextBox);
			this.Name = "TeamSelection";
			this.Text = "TeamSelection";
			this.Load += new System.EventHandler(this.TeamSelection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.ListView TeamListViewBox;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}