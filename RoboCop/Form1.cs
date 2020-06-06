using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboCop
{
    public partial class Form1 : Form
    {
        StringBuilder sb = new StringBuilder();
        List<string> selectedFileNames = new List<string>();
        string sourcePath;
        string destinationpath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sb.ToString(), "Selected Items");
        }

        private void btnSelectSourceFile_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void OpenFiles()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.ShowDialog();
            string[] selectedFilesArray = openFile.SafeFileNames;;
            foreach (var item in selectedFilesArray)
            {
                selectedFileNames.Add(item);
                sb.AppendLine(item);
            }
            lblFileName.Text = selectedFileNames.Count().ToString() + " files selected";
            sourcePath = Path.GetDirectoryName(openFile.FileName);
            //lblFileName.Text = sourcePath;
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString() + "\nin "+ fbd.SelectedPath, "Message");
                    destinationpath = fbd.SelectedPath;
                    lblDestinationPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in selectedFileNames)
                {
                    string source = Path.Combine(sourcePath, item);
                    string destination = Path.Combine(destinationpath, item);
                    File.Copy(source, destination);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
            
        }
    }
}
