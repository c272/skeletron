using AQASkeletronPlus.Events;
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
    public partial class Main : Form
    {
        //The simulation running on the form.
        public static Simulation Simulation { get; private set; }

        //Minimum size of the map panel in pixels.
        private int MIN_MAP_X;
        private int MIN_MAP_Y;
        private int mapX = 300, mapY = 300, startingHouses = 150;

        //Current amount of days ago being viewed on the event viewer.
        private int currentDaysAgo = 0;
        private List<IEvent> events = new List<IEvent>();

        public Main(Simulation existing = null)
        {
            InitializeComponent();

            //Create the simulation.
            if (existing == null)
            {
                Simulation = new Simulation(mapX, mapY, startingHouses);
            }
            else
            {
                Simulation = existing;
                mapX = existing.Settlement.Width;
                mapY = existing.Settlement.Height;
            }

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
            //Process the days.
            for (int i=0; i<amtDaysAdvance.Value; i++)
            {
                Simulation.ProcessDayEnd();
            }

            //Set the event viewer to yesterday, update the viewer.
            currentDaysAgo += Convert.ToInt32(amtDaysAdvance.Value);
            UpdateEventList();
        }

        /// <summary>
        /// Triggered when the user changes the state of "Show Visits".
        /// </summary>
        private void showVisitsChanged(object sender, EventArgs e)
        {
            map.DrawTracers = showVisitsCB.Checked;
        }

        /// <summary>
        /// Triggered when the "Advance Days" value box is altered.
        /// </summary>
        private void advanceDayAmtValueChanged(object sender, EventArgs e)
        {
            advanceDaysBtn.Text = "Advance " + amtDaysAdvance.Value + " days.";
        }

        /// <summary>
        /// Scrolls the events viewer back a day.
        /// </summary>
        private void scrollEventsBack_Click(object sender, EventArgs e)
        {
            currentDaysAgo++;
            if (currentDaysAgo > 50) { currentDaysAgo = 50; }

            //Update the events list.
            UpdateEventList();
        }

        /// <summary>
        /// Scrolls the events viewer forward a day.
        /// </summary>
        private void scrollEventsForward_Click(object sender, EventArgs e)
        {
            currentDaysAgo--;
            if (currentDaysAgo < 0) { currentDaysAgo = 0; }

            //Update the events list.
            UpdateEventList();
        }

        /// <summary>
        /// Goes to the latest events page (not today's, yesterday's).
        /// </summary>
        private void goToLatestEvents_Click(object sender, EventArgs e)
        {
            currentDaysAgo = 1;
            UpdateEventList();
        }

        /// <summary>
        /// Updates the event list from the events chain, from the "currentDaysAgo" property.
        /// </summary>
        private void UpdateEventList()
        {
            events = EventChain.GetChain(currentDaysAgo);
            eventsList.Clear();
            eventDayLabel.Text = "Viewing events from " + currentDaysAgo + " days ago.";

            //Did any events return?
            if (events == null) { 
                if (currentDaysAgo == 0) { return; }
                currentDaysAgo--; UpdateEventList();
                return;
            }

            foreach (var e in events)
            {
                eventsList.Items.Add(e.Stringify());
            }
        }

        /// <summary>
        /// Opens the simulation settings menu.
        /// </summary>
        private void simulationSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsMenu settings = new SettingsMenu();
        }

        /// <summary>
        /// Opens the simulation menu, which allows you to manipulate the current simulation, or view details.
        /// </summary>
        private void simMenuBtn_Click(object sender, EventArgs e)
        {
            //todo
            SimulationMenu s = new SimulationMenu(this);
            s.Show();
            s.FormClosed += updateMapWrapper;
        }

        /// <summary>
        /// Updates the map, as an event wrapper for forms closing.
        /// </summary>
        private void updateMapWrapper(object sender, FormClosedEventArgs e)
        {
            Simulation.UpdateMap();
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
