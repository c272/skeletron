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
    /// Represents input fields for creating a company.
    /// </summary>
    public partial class CreateCompany : Form
    {
        //Properties to export when closing.
        public new string CompanyName { get; set; }
        public double StartingBalance { get; set; }
        public CompanyType Type { get; set; }
        public int StartingOutlets { get; set; }

        public CreateCompany()
        {
            InitializeComponent();

            //Populate the combo box.
            companyType.Items.Add("Fast Food");
            companyType.Items.Add("Family");
            companyType.Items.Add("Named Chef");
        }

        /// <summary>
        /// When the "OK" button is clicked.
        /// </summary>
        private void okBtn_Click(object sender, EventArgs e)
        {
            //Grab all the properties and go!
            CompanyName = nameText.Text;
            if (CompanyName == "") 
            { 
                MessageBox.Show("Name must be >=1 characters.");
                return;
            }

            //Does a company exist with the same name already?
            if (Main.Simulation.Companies.FindIndex(x => x.Name == CompanyName) != -1)
            {
                MessageBox.Show("Name cannot be a duplicate of other companies.");
                return;
            }

            StartingBalance = double.Parse(startingBalance.Value.ToString());
            switch (companyType.SelectedItem.ToString())
            {
                case "Fast Food":
                    Type = CompanyType.FastFood; break;
                case "Family":
                    Type = CompanyType.Family; break;
                case "Named Chef":
                    Type = CompanyType.NamedChef; break;
            }
            StartingOutlets = Convert.ToInt32(startingOutlets.Value);

            //Hide.
            this.Hide();
        }
    }
}
