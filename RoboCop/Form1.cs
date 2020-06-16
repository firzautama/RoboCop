using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboCop
{
    public partial class Form1 : Form
    {
        List<string> selectedFileNames = new List<string>();
        List<string> sourceFilePathAndFileName = new List<string>();
        string destinationPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destinationPath = fbd.SelectedPath;

                    cbRename.Visible = true;
                    btnShowPath.Visible = true;
                    prefixSuffixDateVisible();
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    string sourceChecked = item.SubItems[0].Text;
                    string destinationChecked = item.SubItems[1].Text;

                    File.Copy(sourceChecked, destinationChecked);
                }
                MessageBox.Show(listView1.CheckedItems.Count.ToString() + " files has been copied.");
                btnOpenFolderCopy.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void tbRename_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRename_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRename.Checked)
            {
                tbRename.Visible = true;
            }
            else
            {
                tbRename.Visible = false;
            }
        }

        private void btnShowPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(destinationPath, "Destination Path");
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Temp\");
        }

        private string AddToRename(string datePrefix, string prefix, string rename, string suffix, string numbering, string date)
        {
            string addToRename = datePrefix + prefix + rename + suffix + numbering + date;
            return addToRename;
        }

        private void btnAddToCopy_Click(object sender, EventArgs e)
        {
            if (sourceFilePathAndFileName.Count == 0)
            {
                MessageBox.Show("Please select Source.", "No source path found.");
            }
            if (btnShowPath.Visible == false)
            {
                MessageBox.Show("Please select Destination.", "No destination path found.");
            }
            if (cbRename.Checked && tbRename.Text == "")
            {
                MessageBox.Show("Incremental numbering will be used as file name.", "Rename field is empty");
            }
            int num = 1;
            foreach (var item in sourceFilePathAndFileName)
            {
                if (!item.Contains("."))
                {
                    MessageBox.Show("File(s) with invalid name will not be added to the list.", "Invalid file name found");
                }
                else
                {
                    string prefix = tbPrefix.Text;
                    string suffix = tbSuffix.Text;
                    string numbering = num++.ToString();
                    string date = "";
                    string datePrefix = "";
                    string extension = Path.GetExtension(item);
                    if (cbDate.Checked)
                    {
                        date = "_" + DateTime.Now.ToString("yyyy-MM-dd");
                    }
                    if (cbDatePrefix.Checked)
                    {
                        datePrefix = DateTime.Now.ToString("yyyy-MM-dd") + "_";
                    }
                    if (cbRename.Checked)
                    {
                        string rename = tbRename.Text;
                        string fileName = Path.GetFileNameWithoutExtension(item);
                        string newFileName = AddToRename(datePrefix,prefix, rename, suffix, numbering, date) + extension;
                        string destinationRename = Path.Combine(destinationPath, newFileName);
                        
                        ListViewItem addedRenamedItem = new ListViewItem(item);
                        addedRenamedItem.SubItems.Add(destinationRename);
                        listView1.Items.Add(addedRenamedItem);
                    }
                    else
                    {
                        string fileName = Path.GetFileNameWithoutExtension(item);
                        string destinationFileName = AddToRename(datePrefix,prefix, fileName, suffix, numbering, date) + extension;
                        string destinationPathAndFileName = Path.Combine(destinationPath, destinationFileName);

                        ListViewItem addedItem = new ListViewItem(item);
                        addedItem.SubItems.Add(destinationPathAndFileName);
                        listView1.Items.Add(addedItem);
                    }

                }
            }
            sourceFilePathAndFileName.Clear();
            selectedFileNames.Clear();
            lblFilesInFolder.Visible = false;
            tbRename.Text = "";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = true;
            }
            btnShowPathSourceFolder.Visible = false;
            btnCheckAll.Visible = true;
            btnUncheckAll.Visible = true;
            btnRemoveSelected.Visible = true;
            btnClearList.Visible = true;
            label2.Visible = true;
            tbUpdateListView.Visible = true;
            tbUpdateListView.Text = "";
            BtnUpdate.Visible = true;
            btnDateList.Visible = true;
        }

        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = true;
            }

        }

        private void BtnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = false;
            }
        }

        private void BtnSaveBatFile_Click(object sender, EventArgs e)
        {
            string batchFileName = tbBatchFileName.Text;
            if (tbBatchFileName.Text == "")
            {
                MessageBox.Show("Please insert a batch file name","No batch file name");
            }
            else
            {
                StreamWriter sw = new StreamWriter(@"C:\Temp\" + batchFileName + ".bat");
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    string sourceChecked = item.SubItems[0].Text;
                    string destinationChecked = item.SubItems[1].Text;

                    sw.WriteLine("copy " + "/y " + "\"" + sourceChecked + "\"" + " " + "\"" + destinationChecked + "\"");
                }
                sw.WriteLine("PAUSE");
                sw.Close();
                MessageBox.Show("BAT file has been created.");
                btnOpenFolder.Visible = true;
            }

        }

        private void RbFiles_CheckedChanged(object sender, EventArgs e)
        {
            btnShowPathSourceFolder.Visible = false;
            btnSelectSourceFolder.Visible = true;
            lblFilesInFolder.Visible = false;
            btnSelectSourceFolder.Text = "Select Source Files";
            tbWildcard.Visible = false;
        }

        private void RbFolder_CheckedChanged(object sender, EventArgs e)
        {
            btnShowPathSourceFolder.Visible = false;
            btnSelectSourceFolder.Visible = true;
            lblFilesInFolder.Visible = false;
            tbWildcard.Visible = false;
            btnSelectSourceFolder.Text = "Select Source Folder";
        }

        private void BtnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            if (rbFolder.Checked)
            {
                sourceFilePathAndFileName.Clear();
                using (var folderBrowser = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowser.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                        foreach (var item in files)
                        {
                            sourceFilePathAndFileName.Add(item);
                        }
                        btnShowPathSourceFolder.Visible = true;
                        lblFilesInFolder.Text = files.Length.ToString() + " files found in the folder.";
                        lblFilesInFolder.Visible = true;
                    }
                }
            }
            if (rbFiles.Checked)
            {
                sourceFilePathAndFileName.Clear();
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Multiselect = true;
                openFile.ShowDialog();
                string[] selectedFilePathArray = openFile.FileNames;
                foreach (var item in selectedFilePathArray)
                {
                    sourceFilePathAndFileName.Add(item);
                }
                btnShowPathSourceFolder.Visible = true;
                lblFilesInFolder.Text = selectedFilePathArray.Length.ToString() + " files found.";
                lblFilesInFolder.Visible = true;
            }
            if (rbWildcard.Checked)
            {
                string wildcardText = tbWildcard.Text;
                if (tbWildcard.Text == "" || !tbWildcard.Text.Contains("*"))
                {
                    MessageBox.Show("Please enter a wildcard.","Invalid wildcard name.");
                }
                else
                {
                    sourceFilePathAndFileName.Clear();
                    using (var folderBrowser = new FolderBrowserDialog())
                    {
                        DialogResult result = folderBrowser.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                        {
                            string[] files = Directory.GetFiles(folderBrowser.SelectedPath, wildcardText);
                            foreach (var item in files)
                            {
                                sourceFilePathAndFileName.Add(item);
                            }
                            btnShowPathSourceFolder.Visible = true;
                            lblFilesInFolder.Text = files.Length.ToString() + " files found in the folder.";
                            lblFilesInFolder.Visible = true;
                        }
                    }
                }
            }
        }

        private void prefixSuffixDateVisible()
        {
            cbPrefix.Visible = true;
            cbSuffix.Visible = true;
            cbDate.Visible = true;
            cbDatePrefix.Visible = true;
        }

        private void BtnShowPathSourceFolder_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in sourceFilePathAndFileName)
            {
                string fileName = Path.GetFileName(item);
                sb.AppendLine(fileName);
            }
            string sourceFolderPath = Path.GetDirectoryName(sourceFilePathAndFileName[0]);
            MessageBox.Show(sb.ToString(),sourceFolderPath);
        }

        private void RbWildcard_CheckedChanged(object sender, EventArgs e)
        {
            btnShowPathSourceFolder.Visible = false;
            tbWildcard.Text = "";
            btnSelectSourceFolder.Visible = false;
            btnSelectSourceFolder.Text = "Select Source using Wildcard in a Folder";
            lblFilesInFolder.Text = "Insert wildcard below.";
            lblFilesInFolder.Visible = true;
            tbWildcard.Visible = true;
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            string fullPathToUpdate = listView1.SelectedItems[0].SubItems[1].Text;
            string fileNameToUpdate = Path.GetFileNameWithoutExtension(fullPathToUpdate);
            tbUpdateListView.Text = fileNameToUpdate;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            string fullPathToUpdate = listView1.SelectedItems[0].SubItems[1].Text;
            string folderPath = Path.GetDirectoryName(fullPathToUpdate);
            string updatedFileName = tbUpdateListView.Text;
            string extension = Path.GetExtension(fullPathToUpdate);
            string updatedFullPath = Path.Combine(folderPath, updatedFileName + extension);
            listView1.SelectedItems[0].SubItems[1].Text = updatedFullPath;
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            HideButtonRelatedToList();
        }

        private void HideButtonRelatedToList()
        {
            btnShowPathSourceFolder.Visible = false;
            btnCheckAll.Visible = false;
            btnUncheckAll.Visible = false;
            btnRemoveSelected.Visible = false;
            btnClearList.Visible = false;
            label2.Visible = false;
            tbUpdateListView.Visible = false;
            BtnUpdate.Visible = false;
            btnDateList.Visible = false;
        }

        private void cbPrefix_CheckedChanged(object sender, EventArgs e)
        {
            tbPrefix.Text = "";
            if (cbPrefix.Checked)
            {
                tbPrefix.Visible = true;
            }
            else
            {
                tbPrefix.Visible = false;
            }
        }

        private void cbSuffix_CheckedChanged(object sender, EventArgs e)
        {
            tbSuffix.Text = "";
            if (cbSuffix.Checked)
            {
                tbSuffix.Visible = true;
            }
            else
            {
                tbSuffix.Visible = false;
            }
        }

        private void tbWildcard_TextChanged(object sender, EventArgs e)
        {
            btnSelectSourceFolder.Visible = true;
            btnShowPathSourceFolder.Visible = false;
            lblFilesInFolder.Visible = false;
        }

        private void btnOpenFolderCopy_Click(object sender, EventArgs e)
        {
            Process.Start(destinationPath);
        }

        private void btnDateList_Click(object sender, EventArgs e)
        {
            tbUpdateListView.Text = tbUpdateListView.Text + "_" + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress");
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
