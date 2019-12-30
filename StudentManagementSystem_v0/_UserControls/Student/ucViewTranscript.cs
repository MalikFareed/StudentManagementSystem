using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0._UserControls
{
    public partial class ucViewTranscript : UserControl
    {        
        CalculationPlanner calculationPlanner;
        public ucViewTranscript()
        {
            InitializeComponent();
        }

        private void rbPercentage_CheckedChanged(object sender, EventArgs e)
        {            
            calculationPlanner = new CalculationPlanner();
            calculationPlanner.SetStrategy(new Percentage(int.Parse(txtSID.Text)));
            if (rbPercentage.Checked)
                lblResult.Text = "You have got " + calculationPlanner.GetResult().ToString() + "% marks.";
            lblResult.Visible = true;
        }

        private void rbGPA_CheckedChanged(object sender, EventArgs e)
        {            
            calculationPlanner = new CalculationPlanner();
            calculationPlanner.SetStrategy(new GPA(int.Parse(txtSID.Text)));
            if (rbGPA.Checked)
                lblResult.Text = "Your GPA is " + calculationPlanner.GetResult().ToString() + ".";
            lblResult.Visible = true;

        }

        private void ucViewTranscript_Load(object sender, EventArgs e)
        {
            lblResult.Visible = false;
        }
    }
}
