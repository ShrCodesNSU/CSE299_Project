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
    public partial class TeamSelection : Form
	{
		private readonly string sessionID;
		public TeamSelection(string sessionid)
		{
			this.sessionID = sessionid;
			InitializeComponent();
			DataTable dt = db.Get.getSessionData(sessionID);

			SessionTextBox.Text = "";
			SessionTextBox.AppendText(
										"ID:                            " + dt.Rows[0]["SessionID"].ToString() +
										"\r\nStatus:                      " + dt.Rows[0]["Status"].ToString() +
										"\r\nDate:                         " + ((DateTime)dt.Rows[0]["Date"]).ToString("dd/MM/yyyy")
					 );

			try
			{
				TeamListViewBox.Items.Clear();

				DataTable pDetails = db.Get.getTeamDetails();

				ListViewItem varItem = new ListViewItem(new string[0]);
				foreach (DataRow row in pDetails.Rows)
				{
					varItem = new ListViewItem(new string[]
						{
										row["TeamID"].ToString(),
										row["TeamName"].ToString(),
										row["OwnerName"].ToString(),
										row["ManagerName"].ToString()
						});
					varItem.Checked = true;
					TeamListViewBox.Items.Add(varItem);



				}


			}

			catch (Exception ex)
			{
			}
		}

		private bool validate()
		{
			foreach (ListViewItem item in TeamListViewBox.Items)
			{
				if (item.Checked)
					return true;

			}
			return false;

		}

		private void cls(bool notCID = false)
		{

			foreach (ListViewItem item in TeamListViewBox.Items)
			{
				item.Checked = false;
			}

			//SystemID_Box.SelectedIndex = -1;

		}
		private void TeamSelection_Load(object sender, EventArgs e)
        {

        }

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			if (validate())
			{
				foreach (ListViewItem item in TeamListViewBox.Items)
				{
					if (item.Checked)
						db.Post.PostSessionDetailsData(sessionID, item.SubItems[0].Text, "1"); // 1 => TYPE TEAMS 
				}
				cls();
				this.Close();
			}
			else
				MessageBox.Show("Select participant");
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			cls();
		}
	}
}
