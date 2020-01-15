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
    /// Allows the user to edit and view companies directly in the simulation.
    /// </summary>
    public partial class DisplayCompanies : Form
    {
        Main parent = null;

        public DisplayCompanies(Main m)
        {
            parent = m;
            InitializeComponent();
            Show();

            //Grab all companies from the simulation, populate listview.
            PopulateListView();
        }

        /// <summary>
        /// Populates the list view with current company data from the simulation.
        /// </summary>
        private void PopulateListView()
        {
            foreach (var company in Main.Simulation.Companies)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    company.Name,
                    company.Balance.ToString(),
                    company.Reputation.ToString(),
                    company.Type.ToString(),
                    company.FuelCost.ToString(),
                    company.BaseDeliveryCost.ToString(),
                    string.Join(", ", company.outlets.Select(x => x.Position)) //Outlet positions comma delimited.
                });

                companies.Items.Add(item);
            }
        }
    }
}
