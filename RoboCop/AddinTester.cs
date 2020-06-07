using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RoboCop
{
    public partial class AddinTester : Form
    {
        public AddinTester()
        {
            InitializeComponent();
        }

        private void ddlAddinName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDownloadFiles.Visible = true;
        }

        private void btnApplyTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Revit 2019 is open.\nPlease close Revit");
            lblState.Text = "Test Add-in";
            lblOpenRevit.Visible = true;
        }

        private void btnRestoreAddin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please close Revit", "Revit instance is open");
            lblState.Text = "Original Add-in";
        }

        private void lblDownloadFiles_Click(object sender, EventArgs e)
        {
            lblDownloadFiles.Text = "Related testing files has been downloaded";
            btnOpenFolder.Visible = true;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Firza"); //this has error when alredy opened (Form.ActiveForm == null) 
            Form.ActiveForm.TopMost = true;
        }

        private void lblOpenRevit_Click(object sender, EventArgs e)
        {
            //When Revit open, close the form
            Form.ActiveForm.Close();
        }

        private void AddinTester_Load(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {
            if (lblState.Text == "Original Add-in")
            {
                lblState.Text = "Test Add-in";
                lblSelectAddin.Visible = false;
                ddlAddinName.Visible = false;
                btnApplyTest.Visible = false;
                lblOpenRevit.Visible = false;
            }
        }

        private void lblState_TextChanged(object sender, EventArgs e)
        {
            //When state Test Add-in == true > hide all this in startup
            //if (lblState.Text == "Test Add-in")
            //{
            //    lblSelectAddin.Visible = false;
            //    ddlAddinName.Visible = false;
            //    btnApplyTest.Visible = false;
            //    lblOpenRevit.Visible = false;
            //}
            if (lblState.Text == "Original Add-in")
            {
                lblSelectAddin.Visible = true;
                ddlAddinName.Visible = true;
                btnApplyTest.Visible = true;
                lblOpenRevit.Visible = true;
            }
        }
    }
}
