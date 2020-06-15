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
using System.IO;

namespace RoboCop
{
    public partial class AddinTester : Form
    {
        string selectedTestFolder;
        string destinationFolder = @"C:\Revit Add-in Test";
        string tempDllFolder = @"C:\Temp Revit DLL";
        string userDllPath = @"C:\ProgramData\Autodesk\Revit\Addins\2019\DLLs\BecaRevitMEPapiDev2019.dll";
        string currentReleaseDllPath = @"P:\01\CAD\Revit\Beca\Custom\Addins\2019\DLLs\BecaRevitMEPapiDev2019.dll";
        public AddinTester()
        {
            InitializeComponent();

            CompareDllState(userDllPath, currentReleaseDllPath);

            string[] testFolder = Directory.GetDirectories("\\\\beca.net\\data\\BIM\\MEP\\For Review");
            foreach (var item in testFolder)
            {
                ddlAddinTestName.Items.Add(Path.GetFileName(item));
            }
        }

        private string CompareDllState(string originalPath, string testPath)
        {
            DateTime originalFileDate = File.GetLastWriteTime(originalPath);//File.GetLastWriteTime(originalPath);
            DateTime testFileDate = File.GetLastWriteTime(testPath);
            int compareDllDate = DateTime.Compare(originalFileDate, testFileDate);
            string compareDateResult;
            if (compareDllDate < 0)
            {
                compareDateResult = "OLDER THAN RELEASE ADDIN";//"is earlier than";
            }
            else if (compareDllDate == 0)
            {
                compareDateResult = "ORIGINAL ADD-IN";//"is the same time as";
            }
            else
            {
                compareDateResult = "TEST FILE ADD-IN";//"is later than";
            }
            lblState.Text = compareDateResult;
            return compareDateResult;
        }

        private void ddlAddinName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDownloadFiles.Visible = true;
        }

        private void btnApplyTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Revit 2019 is open.\nPlease close Revit");
            if (lblState.Text == "ORIGINAL ADD-IN")
            {
                if (!Directory.Exists(tempDllFolder))
                {
                    Directory.CreateDirectory(tempDllFolder);
                }
                string tempDllDestination = Path.Combine(tempDllFolder, "BecaRevitMEPapiDev2019.dll");
                if (File.Exists("C:\\Temp Revit DLL\\BecaRevitMEPapiDev2019.dll"))
                {
                    File.Delete("C:\\Temp Revit DLL\\BecaRevitMEPapiDev2019.dll");
                }
                File.Move(userDllPath, tempDllDestination);
                File.Copy("C:\\Users\\FU1\\Desktop\\BecaRevitMEPapiDev2019.dll", userDllPath);
                CompareDllState(userDllPath, currentReleaseDllPath);
            }
            //lblState.Text = "Test Add-in";
            lblOpenRevit.Visible = true;
        }

        private void btnRestoreAddin_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please close Revit", "Revit instance is open");
            lblState.Text = "Original Add-in";
        }

        private void lblDownloadFiles_Click(object sender, EventArgs e)
        {
            string selectedTestName = ddlAddinTestName.SelectedItem.ToString();
            string testFolderPath = "\\\\beca.net\\data\\BIM\\MEP\\For Review";
            selectedTestFolder = Path.Combine(testFolderPath,selectedTestName);
            string[] sourceFiles = Directory.GetFiles(selectedTestFolder,"*",SearchOption.AllDirectories);
            foreach (var item in Directory.GetDirectories(selectedTestFolder,"*",SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(item.Replace(testFolderPath, destinationFolder));
            }
            foreach (var item in sourceFiles)
            {
                File.Copy(item, item.Replace(testFolderPath, destinationFolder));
            }
            lblDownloadFiles.Text = "Related testing files has been downloaded";
            btnOpenFolder.Visible = true;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string downloadedFolder = Path.Combine(destinationFolder, ddlAddinTestName.SelectedItem.ToString());
            Process.Start(downloadedFolder); //this has error when alredy opened (Form.ActiveForm == null) 
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
                ddlAddinTestName.Visible = false;
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
                ddlAddinTestName.Visible = true;
                btnApplyTest.Visible = true;
                lblOpenRevit.Visible = true;
            }
        }
    }
}
