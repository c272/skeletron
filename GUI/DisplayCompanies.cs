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
    /// Allows the user to edit and view companies directly in the simulation.
    /// </summary>
    public partial class DisplayCompanies : Form
    {
        Main parent = null;

        public DisplayCompanies(Main m)
        {
            parent = m;
            InitializeComponent();
            Show();

            //Grab all companies from the simulation, populate listview.
            PopulateListView();
        }

        /// <summary>
        /// Populates the list view with current company data from the simulation.
        /// </summary>
        private void PopulateListView()
        {
            companies.Items.Clear();
            foreach (var company in Main.Simulation.Companies)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    company.Name,
                    company.Balance.ToString(),
                    company.Reputation.ToString(),
                    company.Type.ToString(),
                    company.FuelCost.ToString(),
                    company.BaseDeliveryCost.ToString(),
                    string.Join(", ", company.outlets.Select(x => x.Position)) //Outlet positions comma delimited.
                });
                item.Tag = company.Name;

                companies.Items.Add(item);
            }
        }

        /// <summary>
        /// Create a new company (opens a new GUI).
        /// </summary>
        private void createCompanyBtn_Click(object sender, EventArgs e)
        {
            CreateCompany createCompany = new CreateCompany();
            createCompany.Show();
            createCompany.VisibleChanged += entryFinished;
        }

        /// <summary>
        /// Triggered when the create company entry has finished.
        /// </summary>
        private void entryFinished(object sender, EventArgs e)
        {
            //Get sender.
            CreateCompany companyInfo = (CreateCompany)sender;

            //Create on the simulation.
            try
            {
                Main.Simulation.AddCompanyFromDefault(new CompanyDefault()
                {
                    Name = companyInfo.CompanyName,
                    StartingBalance = companyInfo.StartingBalance,
                    StartingOutlets = companyInfo.StartingOutlets,
                    Type = companyInfo.Type
                });
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed during creation: '" + err.Message + "'.");
                PopulateListView();
                return;
            }

            MessageBox.Show("Successfully created company '" + companyInfo.CompanyName + "'.");
            PopulateListView();
        }

        /// <summary>
        /// Deletes the selected company.
        /// </summary>
        private void deleteCompanyBtn_Click(object sender, EventArgs e)
        {
            //Is there a company selected?
            if (companies.SelectedItems.Count == 0) { return; }

            //Delete all the selected indices.
            foreach (ListViewItem company in companies.SelectedItems)
            {
                Main.Simulation.DeleteCompany((string)company.Tag);
            }
        }

        /// <summary>
        /// "OK" button. Closes the window.
        /// </summary>
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Triggers the opening of a modification window, if a company is selected.
        /// </summary>
        private void modifyCompanyBtn_Click(object sender, EventArgs e)
        {
            //Is there a company selected?
            if (companies.SelectedItems.Count == 0) { return; }

            //There is, modify.
            ModifyCompany m = new ModifyCompany((string)(companies.SelectedItems[0].Tag));
            m.Show();
        }
    }
}
