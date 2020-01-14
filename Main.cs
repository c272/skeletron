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
    public partial class Main : Form
    {
        //The simulation running on the form.
        private Simulation Simulation;

        //Minimum size of the map panel in pixels.
        private int MIN_MAP_X;
        private int MIN_MAP_Y;
        private int mapX = 1000, mapY = 1000, startingHouses = 700;

        public Main()
        {
            InitializeComponent();

            //Create the simulation.
            Simulation = new Simulation(mapX, mapY, startingHouses);

            //Calculate the minimum X and Y based on the simulation setting (at least 2x2 pixels per square).
            MIN_MAP_X = (mapX * 2);
            MIN_MAP_Y = (mapY * 2);

            //Initialize the map.
            map.ResizePanel(MIN_MAP_X, MIN_MAP_Y);
            map.SetSize(mapX, mapY);

            //Add the map to the simulation.
            Simulation.SetMap(map);
        }

        /// <summary>
        /// Executed when the "Advance Day" button is clicked.
        /// </summary>
        private void advanceDaysBtn_Click(object sender, EventArgs e)
        {
            for (int i=0; i<amtDaysAdvance.Value; i++)
            {
                Simulation.ProcessDayEnd();
            }
        }

        /// <summary>
        /// Triggered when the user changes the state of "Show Visits".
        /// </summary>
        private void showVisitsChanged(object sender, EventArgs e)
        {
            map.DrawTracers = showVisitsCB.Checked;
        }

        /// <summary>
        /// Triggered when the user changes the state of "Show Names".
        /// </summary>
        private void showNamesChanged(object sender, EventArgs e)
        {
            map.DrawNames = showCompanyNamesCB.Checked;
        }

        /// <summary>
        /// Triggered when the zoom value is altered.
        /// </summary>
        private void zoomChanged(object sender, EventArgs e)
        {
            //Resize the map panel to a scaled size.
            map.ResizePanel(MIN_MAP_X * zoomTrackBar.Value, MIN_MAP_Y * zoomTrackBar.Value);
        }
    }
}
