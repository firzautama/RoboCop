﻿namespace RoboCop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbRename = new System.Windows.Forms.TextBox();
            this.cbRename = new System.Windows.Forms.CheckBox();
            this.btnShowPath = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnAddToCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.tbSuffix = new System.Windows.Forms.TextBox();
            this.cbSuffix = new System.Windows.Forms.CheckBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.cbPrefix = new System.Windows.Forms.CheckBox();
            this.tbWildcard = new System.Windows.Forms.TextBox();
            this.rbWildcard = new System.Windows.Forms.RadioButton();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.btnShowPathSourceFolder = new System.Windows.Forms.Button();
            this.lblFilesInFolder = new System.Windows.Forms.Label();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.btnSaveBatFile = new System.Windows.Forms.Button();
            this.tbBatchFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbUpdateListView = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnOpenFolderCopy = new System.Windows.Forms.Button();
            this.btnDateList = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.cbDatePrefix = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.AccessibleName = "";
            this.btnSelectDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnSelectDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnSelectDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDestination.ForeColor = System.Drawing.Color.White;
            this.btnSelectDestination.Location = new System.Drawing.Point(12, 190);
            this.btnSelectDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(222, 52);
            this.btnSelectDestination.TabIndex = 3;
            this.btnSelectDestination.Text = "Select Destination Folder";
            this.btnSelectDestination.UseVisualStyleBackColor = false;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleName = "";
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(566, 518);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(227, 46);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "MAKE THE COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbRename
            // 
            this.tbRename.Location = new System.Drawing.Point(12, 272);
            this.tbRename.Margin = new System.Windows.Forms.Padding(2);
            this.tbRename.Name = "tbRename";
            this.tbRename.Size = new System.Drawing.Size(224, 20);
            this.tbRename.TabIndex = 6;
            this.tbRename.Visible = false;
            this.tbRename.TextChanged += new System.EventHandler(this.tbRename_TextChanged);
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Location = new System.Drawing.Point(12, 250);
            this.cbRename.Margin = new System.Windows.Forms.Padding(2);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(66, 17);
            this.cbRename.TabIndex = 7;
            this.cbRename.Text = "Rename";
            this.cbRename.UseVisualStyleBackColor = true;
            this.cbRename.Visible = false;
            this.cbRename.CheckedChanged += new System.EventHandler(this.cbRename_CheckedChanged);
            // 
            // btnShowPath
            // 
            this.btnShowPath.Location = new System.Drawing.Point(158, 246);
            this.btnShowPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPath.Name = "btnShowPath";
            this.btnShowPath.Size = new System.Drawing.Size(76, 22);
            this.btnShowPath.TabIndex = 8;
            this.btnShowPath.Text = "Show Path";
            this.btnShowPath.UseVisualStyleBackColor = true;
            this.btnShowPath.Visible = false;
            this.btnShowPath.Click += new System.EventHandler(this.btnShowPath_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(144, 569);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(105, 22);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Visible = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // btnAddToCopy
            // 
            this.btnAddToCopy.AccessibleName = "";
            this.btnAddToCopy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddToCopy.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddToCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCopy.Location = new System.Drawing.Point(11, 376);
            this.btnAddToCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCopy.Name = "btnAddToCopy";
            this.btnAddToCopy.Size = new System.Drawing.Size(224, 52);
            this.btnAddToCopy.TabIndex = 11;
            this.btnAddToCopy.Text = "ADD TO COPY LIST";
            this.btnAddToCopy.UseVisualStyleBackColor = false;
            this.btnAddToCopy.Click += new System.EventHandler(this.btnAddToCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDatePrefix);
            this.groupBox1.Controls.Add(this.cbDate);
            this.groupBox1.Controls.Add(this.tbSuffix);
            this.groupBox1.Controls.Add(this.cbSuffix);
            this.groupBox1.Controls.Add(this.tbPrefix);
            this.groupBox1.Controls.Add(this.cbPrefix);
            this.groupBox1.Controls.Add(this.tbWildcard);
            this.groupBox1.Controls.Add(this.rbWildcard);
            this.groupBox1.Controls.Add(this.rbFiles);
            this.groupBox1.Controls.Add(this.rbFolder);
            this.groupBox1.Controls.Add(this.btnShowPathSourceFolder);
            this.groupBox1.Controls.Add(this.lblFilesInFolder);
            this.groupBox1.Controls.Add(this.btnSelectSourceFolder);
            this.groupBox1.Controls.Add(this.btnAddToCopy);
            this.groupBox1.Controls.Add(this.btnShowPath);
            this.groupBox1.Controls.Add(this.cbRename);
            this.groupBox1.Controls.Add(this.tbRename);
            this.groupBox1.Controls.Add(this.btnSelectDestination);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 452);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT SOURCE FROM";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cbDate
            // 
            this.cbDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(94, 342);
            this.cbDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(78, 17);
            this.cbDate.TabIndex = 23;
            this.cbDate.Text = "Date Suffix";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.Visible = false;
            // 
            // tbSuffix
            // 
            this.tbSuffix.Location = new System.Drawing.Point(67, 318);
            this.tbSuffix.Margin = new System.Windows.Forms.Padding(2);
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(169, 20);
            this.tbSuffix.TabIndex = 22;
            this.tbSuffix.Visible = false;
            // 
            // cbSuffix
            // 
            this.cbSuffix.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.cbSuffix.AutoSize = true;
            this.cbSuffix.Location = new System.Drawing.Point(13, 319);
            this.cbSuffix.Margin = new System.Windows.Forms.Padding(2);
            this.cbSuffix.Name = "cbSuffix";
            this.cbSuffix.Size = new System.Drawing.Size(52, 17);
            this.cbSuffix.TabIndex = 21;
            this.cbSuffix.Text = "Suffix";
            this.cbSuffix.UseVisualStyleBackColor = true;
            this.cbSuffix.Visible = false;
            this.cbSuffix.CheckedChanged += new System.EventHandler(this.cbSuffix_CheckedChanged);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(67, 295);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(169, 20);
            this.tbPrefix.TabIndex = 20;
            this.tbPrefix.Visible = false;
            // 
            // cbPrefix
            // 
            this.cbPrefix.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.cbPrefix.AutoSize = true;
            this.cbPrefix.Location = new System.Drawing.Point(13, 296);
            this.cbPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrefix.Name = "cbPrefix";
            this.cbPrefix.Size = new System.Drawing.Size(52, 17);
            this.cbPrefix.TabIndex = 19;
            this.cbPrefix.Text = "Prefix";
            this.cbPrefix.UseVisualStyleBackColor = true;
            this.cbPrefix.Visible = false;
            this.cbPrefix.CheckedChanged += new System.EventHandler(this.cbPrefix_CheckedChanged);
            // 
            // tbWildcard
            // 
            this.tbWildcard.Location = new System.Drawing.Point(12, 130);
            this.tbWildcard.Margin = new System.Windows.Forms.Padding(2);
            this.tbWildcard.Name = "tbWildcard";
            this.tbWildcard.Size = new System.Drawing.Size(222, 20);
            this.tbWildcard.TabIndex = 18;
            this.tbWildcard.Visible = false;
            this.tbWildcard.TextChanged += new System.EventHandler(this.tbWildcard_TextChanged);
            // 
            // rbWildcard
            // 
            this.rbWildcard.AutoSize = true;
            this.rbWildcard.Location = new System.Drawing.Point(72, 24);
            this.rbWildcard.Name = "rbWildcard";
            this.rbWildcard.Size = new System.Drawing.Size(67, 17);
            this.rbWildcard.TabIndex = 17;
            this.rbWildcard.Text = "Wildcard";
            this.rbWildcard.UseVisualStyleBackColor = true;
            this.rbWildcard.CheckedChanged += new System.EventHandler(this.RbWildcard_CheckedChanged);
            // 
            // rbFiles
            // 
            this.rbFiles.AutoSize = true;
            this.rbFiles.Location = new System.Drawing.Point(145, 24);
            this.rbFiles.Name = "rbFiles";
            this.rbFiles.Size = new System.Drawing.Size(46, 17);
            this.rbFiles.TabIndex = 16;
            this.rbFiles.Text = "Files";
            this.rbFiles.UseVisualStyleBackColor = true;
            this.rbFiles.CheckedChanged += new System.EventHandler(this.RbFiles_CheckedChanged);
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Location = new System.Drawing.Point(12, 24);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(54, 17);
            this.rbFolder.TabIndex = 15;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Folder";
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.RbFolder_CheckedChanged);
            // 
            // btnShowPathSourceFolder
            // 
            this.btnShowPathSourceFolder.Location = new System.Drawing.Point(159, 104);
            this.btnShowPathSourceFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPathSourceFolder.Name = "btnShowPathSourceFolder";
            this.btnShowPathSourceFolder.Size = new System.Drawing.Size(76, 22);
            this.btnShowPathSourceFolder.TabIndex = 14;
            this.btnShowPathSourceFolder.Text = "File Name(s)";
            this.btnShowPathSourceFolder.UseVisualStyleBackColor = true;
            this.btnShowPathSourceFolder.Visible = false;
            this.btnShowPathSourceFolder.Click += new System.EventHandler(this.BtnShowPathSourceFolder_Click);
            // 
            // lblFilesInFolder
            // 
            this.lblFilesInFolder.AutoSize = true;
            this.lblFilesInFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesInFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(132)))));
            this.lblFilesInFolder.Location = new System.Drawing.Point(10, 107);
            this.lblFilesInFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilesInFolder.Name = "lblFilesInFolder";
            this.lblFilesInFolder.Size = new System.Drawing.Size(114, 15);
            this.lblFilesInFolder.TabIndex = 13;
            this.lblFilesInFolder.Text = "xx files in the folder.";
            this.lblFilesInFolder.Visible = false;
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.AccessibleName = "";
            this.btnSelectSourceFolder.BackColor = System.Drawing.Color.Black;
            this.btnSelectSourceFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSourceFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(12, 48);
            this.btnSelectSourceFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(222, 52);
            this.btnSelectSourceFolder.TabIndex = 12;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = false;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.BtnSelectSourceFolder_Click);
            // 
            // btnSaveBatFile
            // 
            this.btnSaveBatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnSaveBatFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnSaveBatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBatFile.Location = new System.Drawing.Point(25, 518);
            this.btnSaveBatFile.Name = "btnSaveBatFile";
            this.btnSaveBatFile.Size = new System.Drawing.Size(224, 46);
            this.btnSaveBatFile.TabIndex = 17;
            this.btnSaveBatFile.Text = "SAVE A BATCH FILE";
            this.btnSaveBatFile.UseVisualStyleBackColor = false;
            this.btnSaveBatFile.Click += new System.EventHandler(this.BtnSaveBatFile_Click);
            // 
            // tbBatchFileName
            // 
            this.tbBatchFileName.Location = new System.Drawing.Point(25, 494);
            this.tbBatchFileName.Name = "tbBatchFileName";
            this.tbBatchFileName.Size = new System.Drawing.Size(225, 20);
            this.tbBatchFileName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Batch file name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "The Checked files will be copied.";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(290, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 386);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Source";
            this.columnHeader1.Width = 223;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destination";
            this.columnHeader2.Width = 206;
            // 
            // tbUpdateListView
            // 
            this.tbUpdateListView.Location = new System.Drawing.Point(290, 494);
            this.tbUpdateListView.Name = "tbUpdateListView";
            this.tbUpdateListView.Size = new System.Drawing.Size(195, 20);
            this.tbUpdateListView.TabIndex = 27;
            this.tbUpdateListView.Visible = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(489, 490);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 25);
            this.BtnUpdate.TabIndex = 28;
            this.BtnUpdate.Text = "Rename";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select an item above and rename:";
            this.label2.Visible = false;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(489, 432);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(72, 20);
            this.btnCheckAll.TabIndex = 30;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Visible = false;
            this.btnCheckAll.Click += new System.EventHandler(this.BtnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(566, 432);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(72, 20);
            this.btnUncheckAll.TabIndex = 31;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Visible = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.BtnUncheckAll_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(721, 432);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(72, 20);
            this.btnClearList.TabIndex = 32;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Visible = false;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // btnOpenFolderCopy
            // 
            this.btnOpenFolderCopy.Location = new System.Drawing.Point(688, 569);
            this.btnOpenFolderCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFolderCopy.Name = "btnOpenFolderCopy";
            this.btnOpenFolderCopy.Size = new System.Drawing.Size(105, 22);
            this.btnOpenFolderCopy.TabIndex = 33;
            this.btnOpenFolderCopy.Text = "Open Folder";
            this.btnOpenFolderCopy.UseVisualStyleBackColor = true;
            this.btnOpenFolderCopy.Visible = false;
            this.btnOpenFolderCopy.Click += new System.EventHandler(this.btnOpenFolderCopy_Click);
            // 
            // btnDateList
            // 
            this.btnDateList.Location = new System.Drawing.Point(290, 518);
            this.btnDateList.Name = "btnDateList";
            this.btnDateList.Size = new System.Drawing.Size(96, 20);
            this.btnDateList.TabIndex = 34;
            this.btnDateList.Text = "Add Date Suffix";
            this.btnDateList.UseVisualStyleBackColor = true;
            this.btnDateList.Visible = false;
            this.btnDateList.Click += new System.EventHandler(this.btnDateList_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(643, 432);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(72, 20);
            this.btnRemoveSelected.TabIndex = 35;
            this.btnRemoveSelected.Text = "Remove Sel";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Visible = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // cbDatePrefix
            // 
            this.cbDatePrefix.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.cbDatePrefix.AutoSize = true;
            this.cbDatePrefix.Location = new System.Drawing.Point(12, 342);
            this.cbDatePrefix.Margin = new System.Windows.Forms.Padding(2);
            this.cbDatePrefix.Name = "cbDatePrefix";
            this.cbDatePrefix.Size = new System.Drawing.Size(78, 17);
            this.cbDatePrefix.TabIndex = 24;
            this.cbDatePrefix.Text = "Date Prefix";
            this.cbDatePrefix.UseVisualStyleBackColor = true;
            this.cbDatePrefix.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 625);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnDateList);
            this.Controls.Add(this.btnOpenFolderCopy);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.tbUpdateListView);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBatchFileName);
            this.Controls.Add(this.btnSaveBatFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnCopy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1498, 664);
            this.MinimumSize = new System.Drawing.Size(839, 664);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoboCop(ier)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbRename;
        private System.Windows.Forms.CheckBox cbRename;
        private System.Windows.Forms.Button btnShowPath;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnAddToCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveBatFile;
        private System.Windows.Forms.TextBox tbBatchFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Button btnShowPathSourceFolder;
        private System.Windows.Forms.Label lblFilesInFolder;
        private System.Windows.Forms.RadioButton rbFiles;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbWildcard;
        private System.Windows.Forms.TextBox tbWildcard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbUpdateListView;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.CheckBox cbPrefix;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.TextBox tbSuffix;
        private System.Windows.Forms.CheckBox cbSuffix;
        private System.Windows.Forms.Button btnOpenFolderCopy;
        private System.Windows.Forms.Button btnDateList;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.CheckBox cbDatePrefix;
    }
}