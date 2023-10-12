using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventController.Views
{
    public partial class StartSession : Form
	{
		private string sessionID;
		private bool playerAdded = false, teamAdded = false;
		public StartSession()
        {
            InitializeComponent();
			createSession();
			update(sessionID);
		}



		private void update(string sessionID)
		{

			if (playerAdded && teamAdded)
				StartButton.Enabled = true;
			else
				StartButton.Enabled = false;
			DataTable participants = db.Get.getSessionDetails(sessionID);
			participantTeams.Text = "";
			participantPlayers.Text = "";

			DataTable participantInfo;
			int pCount = 0, tCount = 0;

			foreach (DataRow row in participants.Rows)
			{
				if (row["Type"].Equals("0"))
				{
					participantInfo = db.Get.getPlayerDetails(row["Participant"].ToString());
					participantPlayers.Text += participantInfo.Rows[0]["Player_Name"].ToString() + "\r\n";
					pCount++;
				}
				else
				{
					participantInfo = db.Get.getTeamDetails(row["Participant"].ToString());
					participantTeams.Text += participantInfo.Rows[0]["TeamName"].ToString() + "\r\n";
					tCount++;
				}

			}
		}




		private void createSession()
		{
			this.sessionID = Global.GenarateHash();
			string status = "1", dtime = DateTime.Now.ToString(""), addby = "Afsana";
			db.Post.PostSessionData(sessionID, status, dtime);

			SessionTextBox.Text = "";
			SessionTextBox.AppendText(
					"ID:                            " + sessionID +
					"\r\nStatus:                      " + status +
					"\r\nAdded By:                 " + addby +
					"\r\nDate:                         " + dtime

				);
			//update(sessionID);
			PlayerButton.Enabled = true;
			TeamButton.Enabled = true;
			StartButton.Enabled = true;

		}


		private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void TeamButton_Click(object sender, EventArgs e)
		{
			TeamSelection participatingTeamsForm = new TeamSelection(sessionID);

			participatingTeamsForm.FormClosed += delegate {
				update(sessionID);
			};
			participatingTeamsForm.Show();
			teamAdded = true;
		}

		private void PlayerButton_Click(object sender, EventArgs e)
		{
			PlayerSelection participatingPlayerForm = new PlayerSelection(sessionID);
			participatingPlayerForm.FormClosed += delegate {
				update(sessionID);
			};
			participatingPlayerForm.Show();
			playerAdded = true;
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			db.Set.UpdateSessionData(sessionID, "2");
			Global.sessionID = sessionID;

			new DashBoard().Show();

			//this.Close(); // add this when adding to dashboard 
		}

		private void Clear_Click(object sender, EventArgs e)
		{

		}

		private void StartSession_Load(object sender, EventArgs e)
        {
			//
        }
    }
}
