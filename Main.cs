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
        public Main()
        {
            InitializeComponent();

            //Create the simulation.
            Simulation sim = new Simulation(500, 500);

            //Initialize the map.
            MapPanel map = new MapPanel()
            {
                Width = 1000,
                Height = 1000
            };
            map.SetSize(500, 500);
            Controls.Add(map);

            //Add the map to the simulation.
            sim.SetMap(map);

            sim.ProcessDayEnd();
        }
    }
}
