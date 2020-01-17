using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQASkeletronPlus.GUI
{
    /// <summary>
    /// Simulation menu. Allows the user to manipulate the simulation directly.
    /// </summary>
    public partial class SimulationMenu : Form
    {
        Main parent = null;

        public SimulationMenu(Main m)
        {
            parent = m;
            InitializeComponent();
        }

        /// <summary>
        /// When the user wishes to display all active households.
        /// </summary>
        private void displayHouseholdsBtn_Click(object sender, EventArgs e)
        {
            //Select all houses from the building list, and display them.
            var display = new DisplayHouseholds(parent);
        }

        /// <summary>
        /// When the user wishes to display all companies.
        /// </summary>
        private void displayCompaniesBtn_Click(object sender, EventArgs e)
        {
            DisplayCompanies d = new DisplayCompanies(parent);
        }

        /// <summary>
        /// Runs the simulation until it reaches the given balance target.
        /// </summary>
        private void runToBalanceTargetBtn_Click(object sender, EventArgs e)
        {
            RunToTarget r = new RunToTarget();
            r.Show();
        }
    }
}
