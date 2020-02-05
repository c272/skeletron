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
    public partial class RunToTarget : Form
    {
        public RunToTarget()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            //Balances valid?
            if (minBal.Value >= maxBal.Value) { MessageBox.Show("Invalid, minimum value must be smaller than maximum."); return; }

            //Simulate!
            double minVal = Convert.ToDouble(minBal.Value);
            double maxVal = Convert.ToDouble(maxBal.Value);
            while (true)
            {
                //Simulate the day.
                Main.Simulation.ProcessDayEnd();
                
                //Any companies outside bounds?
                foreach (var company in Main.Simulation.Companies)
                {
                    if (company.Balance < minVal || company.Balance > maxVal) {
                        MessageBox.Show("Company '" + company.Name + "' broke the limits with a balance of £" + company.Balance + ".");
                        return;
                    }
                }
            }
        }
    }
}
