using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController.Views
{
    public partial class PlayerSelection : Form
	{
		private readonly string sessionID;
		public PlayerSelection(string sessionID)
        {
            InitializeComponent();
			this.sessionID = sessionID;
			DataTable dt = db.Get.getSessionData(sessionID);

			PlayerSessionDetailsBox.Text = "";
			PlayerSessionDetailsBox.AppendText(
										"ID:                            " + dt.Rows[0]["SessionID"].ToString() +
										"\r\nStatus:                      " + dt.Rows[0]["Status"].ToString() +
										"\r\nDate:                         " + ((DateTime)dt.Rows[0]["Date"]).ToString("dd/MM/yyyy")


					 );

			updatePlayer();
		}

		private void updatePlayer()
		{

			try
			{
				PlayerListViewBox.Items.Clear();

				DataTable pDetails = db.Get.getPlayerDetails();

				ListViewItem varItem = new ListViewItem(new string[0]);
				foreach (DataRow row in pDetails.Rows)
				{
					varItem = new ListViewItem(new string[]
						{
										row["Player_Id"].ToString(),
										row["Player_Name"].ToString(),
										((DateTime)row["DOB"]).ToString("dd/MM/yyyy"),
										row["Batting_hand"].ToString(),
										row["Bowling_skill"].ToString(),
										row["Country_Name"].ToString(),
						});
					varItem.Checked = true;
					PlayerListViewBox.Items.Add(varItem);
				}
			}
			catch (Exception ex)
			{
			}
		}

		private bool validate()
		{
			foreach (ListViewItem item in PlayerListViewBox.Items)
			{
				if (item.Checked)
					return true;

			}
			return false;

		}

		private void cls(bool notCID = false)
		{

			foreach (ListViewItem item in PlayerListViewBox.Items)
			{
				item.Checked = false;
			}

		}


		private void button1_Click(object sender, EventArgs e)
		{
			cls();
		}

        private void SubmitButton_Click(object sender, EventArgs e)
        {
			if (validate())
			{

				foreach (ListViewItem item in PlayerListViewBox.Items)
				{
					if (item.Checked)
					{
						DataTable playerInfo = db.Get.getPlayerDetails(item.SubItems[0].Text);
						db.Post.PostSessionDetailsData(sessionID, item.SubItems[0].Text,"0"); // 0 => TYPE PLAYER 
					}
				}

				cls();
				this.Close();
			}
			else
			{
				MessageBox.Show("Select participant");
			}
		}

		private void PlayerSelection_Load(object sender, EventArgs e)
		{

		}
	}
}
