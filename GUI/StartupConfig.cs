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
    /// Allows the user to configure their simulation before starting it.
    /// </summary>
    public partial class StartupConfig : Form
    {
        /// <summary>
        /// Set the default values upon start.
        /// </summary>
        public StartupConfig()
        {
            InitializeComponent();
            simWidth.Value = Settings.Get.DefaultSimulationWidth;
            simHeight.Value = Settings.Get.DefaultSimulationHeight;
            simHouses.Value = Settings.Get.DefaultSimulationHouses;
        }

        /// <summary>
        /// Triggered when the "Go" button is clicked.
        /// </summary>
        private void goBtn_Click(object sender, EventArgs e)
        {
            //Attempt to create a simulation.
            Simulation sim = null;
            try
            {
                //Which simulation type is it?
                if (balancedModeCb.Checked)
                {
                    //Edit the defaults to balance.
                    Settings.DefaultCompanies = new List<CompanyDefault>()
                    {
                        //AQA Burgers
                        new CompanyDefault()
                        {
                            Name = "AQA Burgers+",
                            StartingBalance = 100000,
                            Type = CompanyType.FastFood,
                            StartingOutlets = 4
                        },

                        //Ben Thor Cuisine
                        new CompanyDefault()
                        {
                            Name = "Ben Thor Cuisine",
                            StartingBalance = 100400,
                            Type = CompanyType.NamedChef,
                            StartingOutlets = 2
                        },

                        //Paltry Poultry
                        new CompanyDefault()
                        {
                            Name = "Family Poultry",
                            StartingBalance = 25000,
                            Type = CompanyType.Family,
                            StartingOutlets = 4
                        }
                    };

                    //Start sim.
                    sim = new BalancedSimulation(
                        Convert.ToInt32(simWidth.Value),
                        Convert.ToInt32(simHeight.Value),
                        Convert.ToInt32(simHouses.Value));
                }
                else
                {
                    sim = new Simulation(
                        Convert.ToInt32(simWidth.Value),
                        Convert.ToInt32(simHeight.Value),
                        Convert.ToInt32(simHouses.Value));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error starting simulation, '" + err.Message + "'.");
            }

            //Create the main window.
            Main m = new Main(sim);
            m.Show();
            this.Hide();
            m.FormClosing += closeWrapper;
        }

        /// <summary>
        /// Wrapper for terminating the program.
        /// </summary>
        private void closeWrapper(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
