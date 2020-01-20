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
    /// Allows the user to open, expand and close outlets for a company.
    /// </summary>
    public partial class ModifyCompany : Form
    {
        /// <summary>
        /// The company being edited.
        /// </summary>
        public Company company
        {
            get
            {
                return Main.Simulation.Companies.Find(x => x.Name == companyName);
            }
        }

        /// <summary>
        /// Name of the company being edited.
        /// </summary>
        public string companyName;

        public ModifyCompany(string companyName_)
        {
            companyName = companyName_;
            InitializeComponent();

            //Trim company name, if required.
            string nameTxt = companyName;
            if (nameTxt.Length > 20) { nameTxt = nameTxt.Substring(0, 17) + "..."; }
            nameLbl.Text = nameTxt;
        }

        /// <summary>
        /// "OK" button. Closes the form.
        /// </summary>
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens a new outlet for this company.
        /// </summary>
        private void openOutletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Try to open an outlet.
                company.OpenOutlet();
                MessageBox.Show("Successfully opened a new outlet for '" + companyName + "'.");
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not open outlet, '" + err.Message + "'.");
            }
        }

        /// <summary>
        /// Closes a random outlet from the company.
        /// </summary>
        private void closeOutletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Try to open an outlet.
                if (company.outlets.Count == 0) { throw new Exception("No outlets to close."); }
                company.CloseOutlet(company.outlets[Simulation.Random.Next(0, company.outlets.Count-1)]);
                MessageBox.Show("Successfully closed an outlet for '" + companyName + "' (" + company.outlets.Count + " remaining).");
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not close outlet, '" + err.Message + "'.");
            }
        }

        /// <summary>
        /// Expands a random outlet from the company.
        /// </summary>
        private void expandOutletBtn_Click(object sender, EventArgs e)
        {
            if (company.outlets.Count == 0) { throw new Exception("No outlets to expand."); }

            //Generate a random amount to expand by.
            int expandBy = Simulation.Random.Next(0, Settings.Get.MaxNewSeats);
            company.ExpandOutlet(company.outlets[Simulation.Random.Next(0, company.outlets.Count - 1)], expandBy);

            MessageBox.Show("Successfully expanded outlet for company '" + companyName + "' by " + expandBy + " seats.");
        }
    }
}
