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
            MapPanel test = new MapPanel()
            {
                Width = 500,
                Height = 500
            };
            test.SetSize(15, 15);
            test.AddHousehold(0, 0);
            test.AddOutlet(0, 1);
            Controls.Add(test);
        }
    }
}
