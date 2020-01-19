using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQASkeletronPlus.GUI
{
    public partial class AboutMenu : Form
    {
        public AboutMenu()
        {
            InitializeComponent();

            //Set the labels accordingly.
            var asm = Assembly.GetExecutingAssembly().GetName();
            revisionLbl.Text = "Revision: " + asm.Version.ToString();
            releaseLbl.Text = "Release: " + asm.GetVersionName();
            architectureLbl.Text = "Architecture: " + asm.ProcessorArchitecture.ToString();
        }
    }
}
