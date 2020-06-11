﻿using System;
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
        string sourcePath;
        string destinationPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectSourceFile_Click(object sender, EventArgs e)
        {
            //OpenFiles();
        }

        private void OpenFiles()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.ShowDialog();
            string[] selectedFilesArray = openFile.SafeFileNames;
            string[] selectedFilePathArray = openFile.FileNames;
            foreach (var item in selectedFilesArray)
            {
                selectedFileNames.Add(item);
            }
            //lblFileName.Text = selectedFileNames.Count().ToString() + " files selected";
            //lblFileName.Visible = true;
            sourcePath = Path.GetDirectoryName(openFile.FileName);
            foreach (var item in selectedFilePathArray)
            {
                sourceFilePathAndFileName.Add(item);
            }
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
                MessageBox.Show("Enter a new file name or uncheck Rename");
            }
            int num = 1;
            foreach (var item in sourceFilePathAndFileName)
            {
                if (!item.Contains("."))
                {
                    MessageBox.Show("Invalid file name found. \nWill not be included.", "File name error");
                }
                else
                {
                    if (cbRename.Checked)
                    {
                        string extension = Path.GetExtension(item);
                        string fileName = Path.GetFileNameWithoutExtension(item);
                        string newName = tbRename.Text + num++.ToString();
                        string newFileName = newName + extension;
                        string destinationRename = Path.Combine(destinationPath, newFileName);

                        ListViewItem addedRenamedItem = new ListViewItem(item);
                        addedRenamedItem.SubItems.Add(destinationRename);
                        listView1.Items.Add(addedRenamedItem);
                    }
                    else
                    {
                        string destinationFileName = Path.GetFileName(item);
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
            btnClearList.Visible = true;
            label2.Visible = true;
            tbUpdateListView.Visible = true;
            BtnUpdate.Visible = true;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Please insert a batch file name");
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
            lblFilesInFolder.Visible = false;
            btnSelectSourceFolder.Text = "Select Source Files";
            tbWildcard.Visible = false;
        }

        private void RbFolder_CheckedChanged(object sender, EventArgs e)
        {
            lblFilesInFolder.Visible = false;
            tbWildcard.Visible = false;
            btnSelectSourceFolder.Text = "Select Source Folder";
            //lblFilesInFolder.Visible = true;
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
                        //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString() + "\nin "+ folderBrowser.SelectedPath, "Message");
                        //destinationPath = folderBrowser.SelectedPath;
                        //cbRename.Visible = true;
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
                //string[] selectedFilesArray = openFile.SafeFileNames;
                string[] selectedFilePathArray = openFile.FileNames;
                //foreach (var item in selectedFilesArray)
                //{
                //    selectedFileNames.Add(item);
                //}
                //lblFileName.Text = selectedFileNames.Count().ToString() + " files selected";
                //lblFileName.Visible = true;
                //sourcePath = Path.GetDirectoryName(openFile.FileName);
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
                    MessageBox.Show("Please enter a wildcard.");
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

        private void BtnShowPathSourceFolder_Click(object sender, EventArgs e)
        {
            string sourceFolderPath = Path.GetDirectoryName(sourceFilePathAndFileName[0]);
            MessageBox.Show(sourceFolderPath);
        }

        private void RbWildcard_CheckedChanged(object sender, EventArgs e)
        {
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

        private void TbUpdateListView_TextChanged(object sender, EventArgs e)
        {

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
            btnClearList.Visible = false;
            label2.Visible = false;
            tbUpdateListView.Visible = false;
            BtnUpdate.Visible = false;
        }
    }
}
