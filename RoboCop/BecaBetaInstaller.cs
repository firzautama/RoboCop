using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCop
{
    public partial class BecaBetaInstaller : Form
    {
        string _sourcePath = @"P:\100\1003259\Automation\_Beta Testing";
        string _templateFilePath = @"P:\100\1003259\Automation\_Beta Testing\MEP Tools";

        string _destinationAddinsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Autodesk\Revit\Addins");
        string _destinationTemplatePath = @"C:\ProgramData\Autodesk\Revit\Addins\MEP Tools";

        string _selectedVersionDirectory;
        List<string> _dllsToCopy = new List<string>();
        List<string> _addinsToCopy = new List<string>();
        List<string> _templateFilesToCopy = new List<string>();
        Dictionary<string, string> addinDic = new Dictionary<string, string>();

        public BecaBetaInstaller()
        {
            InitializeComponent();

            cb_RevitVersion.Items.Add("2018");
            cb_RevitVersion.Items.Add("2019");
            cb_RevitVersion.Items.Add("2020");
            cb_RevitVersion.Items.Add("2021");
            cb_RevitVersion.Items.Add("2022");

            cb_RevitVersion.SelectedIndex = 0;
            cb_FilesInDirectory.SelectedIndex = 0;

            addinDic.Add("BETA1", "BecaRevitAddin_Beta1Tab.addin");
            addinDic.Add("BETA_02", "BecaRevitAddin_Beca02Tab.addin");
            addinDic.Add("BETA_03", "BecaRevitAddin_Beca03Tab.addin");
        }

        private void cb_RevitVersion_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_FilesInDirectory.Items.Clear();
            _selectedVersionDirectory = Path.Combine(_sourcePath, cb_RevitVersion.SelectedItem.ToString());
            var becaDirectory = Directory.GetDirectories(_selectedVersionDirectory);
            foreach (var item in becaDirectory)
            {
                var betaFolders = Directory.GetDirectories(item);
                foreach (var folder in betaFolders)
                {
                    var result = folder.Substring(folder.LastIndexOf('\\') + 1);
                    cb_FilesInDirectory.Items.Add(result);
                }
                
            }
            if (cb_FilesInDirectory.Items.Count > 0)
                cb_FilesInDirectory.SelectedIndex = 0;

        }

        private void btn_Install_Click(object sender, EventArgs e)
        {
            var selectedVersionPath = Path.Combine(_selectedVersionDirectory, "Beca", cb_FilesInDirectory.SelectedItem.ToString());
            var dllsDetinationPath = Path.Combine(_destinationAddinsPath, cb_RevitVersion.SelectedItem.ToString(), "Beca", cb_FilesInDirectory.SelectedItem.ToString());
            var addinFilesDestinationPath = Path.Combine(_destinationAddinsPath, cb_RevitVersion.SelectedItem.ToString());

            // Delete all in directory
            if (Directory.Exists(addinFilesDestinationPath))
                Directory.Delete(addinFilesDestinationPath, true);
            if (Directory.Exists(_destinationTemplatePath))
                Directory.Delete(_destinationTemplatePath, true);

            // Dlls to copy from selected version and Beta tab
            if (Directory.Exists(selectedVersionPath))
                ProcessDirectory(_dllsToCopy, selectedVersionPath);

            // Addin file to copy from selected version
            foreach (var item in Directory.GetFiles(_selectedVersionDirectory))
            {
                if (addinDic.ContainsKey(cb_FilesInDirectory.SelectedItem.ToString()))
                    if (Path.GetFileName(item) == addinDic[cb_FilesInDirectory.SelectedItem.ToString()])
                        _addinsToCopy.Add(item);
            }

            // Template files to copy
            ProcessDirectory(_templateFilesToCopy, _templateFilePath);

            // if .addin is missing
            if (_addinsToCopy.Find(x => x.Contains(".addin")) == null)
            {
                MessageBox.Show("Missing .addin file in main directory");
                _addinsToCopy.Clear();
            }

            int nCount = _dllsToCopy.Count() + _addinsToCopy.Count() + _templateFilesToCopy.Count();
            string progressMessage = "{0} of " + nCount.ToString() + " files copied...";
            string caption = "Installing " + cb_FilesInDirectory.SelectedItem.ToString() + " into Revit" + cb_RevitVersion.SelectedItem.ToString();
            using (var pf = new ProgressForm(caption, progressMessage, nCount))
            {
                try
                {
                    // Copy dll files
                    if (!Directory.Exists(dllsDetinationPath))
                    {
                        Directory.CreateDirectory(dllsDetinationPath);
                        foreach (var dll in _dllsToCopy)
                        {
                            File.Copy(dll, Path.Combine(dllsDetinationPath, Path.GetFileName(dll)), true);
                            
                        }
                            
                    }
                    else
                    {
                        foreach (var dll in _dllsToCopy)
                        {
                            File.Copy(dll, Path.Combine(dllsDetinationPath, Path.GetFileName(dll)), true);
                            pf.Increment();
                        }
                            
                    }
                    // Copy addin files
                    if (!Directory.Exists(addinFilesDestinationPath))
                    {
                        Directory.CreateDirectory(addinFilesDestinationPath);
                        foreach (var addin in _addinsToCopy)
                        {
                            File.Copy(addin, Path.Combine(addinFilesDestinationPath, Path.GetFileName(addin)), true);
                            pf.Increment();
                        }
                            
                    }
                    else
                    {
                        foreach (var addin in _addinsToCopy)
                        {
                            File.Copy(addin, Path.Combine(addinFilesDestinationPath, Path.GetFileName(addin)), true);
                            pf.Increment();
                        }
                            
                    }
                    // copy template files
                    if (!Directory.Exists(_destinationTemplatePath))
                    {
                        Directory.CreateDirectory(_destinationTemplatePath);
                        foreach (var template in _templateFilesToCopy)
                        {
                            var destinationFile = Path.Combine(_destinationTemplatePath, Path.GetFileName(Path.GetDirectoryName(template)));
                            if (!Directory.Exists(destinationFile))
                            {
                                Directory.CreateDirectory(destinationFile);
                                File.Copy(template, Path.Combine(_destinationTemplatePath, destinationFile, Path.GetFileName(template)), true);
                                pf.Increment();
                            }
                            else
                            {
                                File.Copy(template, Path.Combine(_destinationTemplatePath, destinationFile, Path.GetFileName(template)), true);
                                pf.Increment();
                            }
                        }
                    }
                    else
                    {
                        foreach (var template in _templateFilesToCopy)
                        {
                            var destinationFile = Path.Combine(_destinationTemplatePath, Path.GetFileName(Path.GetDirectoryName(template)));
                            if (!Directory.Exists(destinationFile))
                            {
                                Directory.CreateDirectory(destinationFile);
                                File.Copy(template, Path.Combine(_destinationTemplatePath, destinationFile, Path.GetFileName(template)), true);
                                pf.Increment();
                            }
                            else
                            {
                                var ss = Path.Combine(_destinationTemplatePath, destinationFile, Path.GetFileName(template));
                                File.Copy(template, Path.Combine(_destinationTemplatePath, destinationFile, Path.GetFileName(template)), true);
                                pf.Increment();
                            }
                            
                        }  
                    }
                    pf.Close();
                    MessageBox.Show(cb_FilesInDirectory.SelectedItem.ToString() + " tab has been installed in Revit " 
                        + cb_RevitVersion.SelectedItem.ToString(),"Install success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }

        // Process all files in the directory passed in, recurse on any directories
        // that are found, and process the files they contain.
        private void ProcessDirectory(List<string> listToCopy, string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                listToCopy.Add(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(listToCopy, subdirectory);
        }


        
    }
}
