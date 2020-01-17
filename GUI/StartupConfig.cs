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
                sim = new Simulation(
                    Convert.ToInt32(simWidth.Value),
                    Convert.ToInt32(simHeight.Value),
                    Convert.ToInt32(simHouses.Value));
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
