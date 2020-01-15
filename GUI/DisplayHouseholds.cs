using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQASkeletronPlus
{
    /// <summary>
    /// Displays a basic list of households to the user.
    /// </summary>
    public partial class DisplayHouseholds : Form
    {
        Main parent = null;

        public DisplayHouseholds(Main m)
        {
            parent = m;
            InitializeComponent();
            Show();

            //Populate the list.
            PopulateListView();
        }

        /// <summary>
        /// Populates the list view with updated houses.
        /// </summary>
        private void PopulateListView()
        {
            houses.Items.Clear();

            //Get the house positions from Main using LINQ.
            List<Vector2> housePositions = Main.Simulation.GetBuildingCoordinates()
                                                               .Where(x => x.Type == BuildingType.Household)
                                                               .Select(x => x.Position)
                                                               .ToList();
            //Populate the ListView with the given houses.
            for (int i = 0; i < housePositions.Count; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { i.ToString(), housePositions[i].ToString() });
                item.Tag = i;
                houses.Items.Add(item);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        /// <summary>
        /// Adds a household to the simulation.
        /// </summary>
        private void addHouseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Main.Simulation.Settlement.AddHousehold();
            }
            catch
            {
                MessageBox.Show("Reached housing limit, cannot add any more.");
                return;
            }
            PopulateListView();
        }

        /// <summary>
        /// Removes a household from the simulation.
        /// </summary>
        private void removeHouseBtn_Click(object sender, EventArgs e)
        {
            //Anything to remove?
            if (Main.Simulation.Settlement.NumHouseholds == 0) { return; }

            //Okay, can remove one. Is there one selected to remove?
            List<int> indexesToRemove = new List<int>();
            if (houses.SelectedIndices.Count != 0)
            {
                //Remove all!
                foreach (int index in houses.SelectedIndices)
                {
                    indexesToRemove.Add(index);
                }
            }
            else
            {
                //No, just remove 0.
                indexesToRemove.Add(0);
            }

            //Remove, making sure to shift indices accordingly.
            for (int i=0; i<indexesToRemove.Count; i++)
            {
                try
                {
                    Main.Simulation.Settlement.RemoveHouseholdAt(indexesToRemove[i] - i);
                }
                catch
                {
                    MessageBox.Show("Invalid household selected to remove/can't remove any more.");
                }
            }

            //Update list.
            PopulateListView();
        }
    }
}
