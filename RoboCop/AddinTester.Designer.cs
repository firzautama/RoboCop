﻿namespace RoboCop
{
    partial class AddinTester
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
            this.btnRestoreAddin = new System.Windows.Forms.Button();
            this.btnApplyTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.ddlAddinTestName = new System.Windows.Forms.ComboBox();
            this.lblSelectAddin = new System.Windows.Forms.Label();
            this.lblDownloadFiles = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblOpenRevit = new System.Windows.Forms.Label();
            this.gbSelectAddin = new System.Windows.Forms.GroupBox();
            this.gbSelectAddin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestoreAddin
            // 
            this.btnRestoreAddin.AccessibleName = "";
            this.btnRestoreAddin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnRestoreAddin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRestoreAddin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnRestoreAddin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreAddin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAddin.Location = new System.Drawing.Point(28, 275);
            this.btnRestoreAddin.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreAddin.Name = "btnRestoreAddin";
            this.btnRestoreAddin.Size = new System.Drawing.Size(191, 49);
            this.btnRestoreAddin.TabIndex = 6;
            this.btnRestoreAddin.Text = "Restore Original Add-in";
            this.btnRestoreAddin.UseVisualStyleBackColor = false;
            this.btnRestoreAddin.Click += new System.EventHandler(this.btnRestoreAddin_Click);
            // 
            // btnApplyTest
            // 
            this.btnApplyTest.AccessibleName = "";
            this.btnApplyTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnApplyTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnApplyTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyTest.ForeColor = System.Drawing.Color.White;
            this.btnApplyTest.Location = new System.Drawing.Point(28, 194);
            this.btnApplyTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyTest.Name = "btnApplyTest";
            this.btnApplyTest.Size = new System.Drawing.Size(191, 46);
            this.btnApplyTest.TabIndex = 5;
            this.btnApplyTest.Text = "Apply Test Add-in";
            this.btnApplyTest.UseVisualStyleBackColor = false;
            this.btnApplyTest.Click += new System.EventHandler(this.btnApplyTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Add-in state is:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(132)))));
            this.lblState.Location = new System.Drawing.Point(27, 39);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(117, 17);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "Original Add-in";
            this.lblState.TextChanged += new System.EventHandler(this.lblState_TextChanged);
            this.lblState.Click += new System.EventHandler(this.lblState_TextChanged);
            // 
            // ddlAddinTestName
            // 
            this.ddlAddinTestName.FormattingEnabled = true;
            this.ddlAddinTestName.Location = new System.Drawing.Point(11, 35);
            this.ddlAddinTestName.Margin = new System.Windows.Forms.Padding(2);
            this.ddlAddinTestName.Name = "ddlAddinTestName";
            this.ddlAddinTestName.Size = new System.Drawing.Size(192, 21);
            this.ddlAddinTestName.TabIndex = 9;
            this.ddlAddinTestName.SelectedIndexChanged += new System.EventHandler(this.ddlAddinName_SelectedIndexChanged);
            // 
            // lblSelectAddin
            // 
            this.lblSelectAddin.AutoSize = true;
            this.lblSelectAddin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAddin.Location = new System.Drawing.Point(8, 17);
            this.lblSelectAddin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectAddin.Name = "lblSelectAddin";
            this.lblSelectAddin.Size = new System.Drawing.Size(114, 15);
            this.lblSelectAddin.TabIndex = 10;
            this.lblSelectAddin.Text = "Select add-in to test";
            // 
            // lblDownloadFiles
            // 
            this.lblDownloadFiles.AutoSize = true;
            this.lblDownloadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(132)))));
            this.lblDownloadFiles.Location = new System.Drawing.Point(8, 57);
            this.lblDownloadFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownloadFiles.Name = "lblDownloadFiles";
            this.lblDownloadFiles.Size = new System.Drawing.Size(151, 15);
            this.lblDownloadFiles.TabIndex = 11;
            this.lblDownloadFiles.Text = "Download related test files";
            this.lblDownloadFiles.Visible = false;
            this.lblDownloadFiles.Click += new System.EventHandler(this.lblDownloadFiles_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(11, 75);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(79, 20);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Visible = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblOpenRevit
            // 
            this.lblOpenRevit.AutoSize = true;
            this.lblOpenRevit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenRevit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(132)))));
            this.lblOpenRevit.Location = new System.Drawing.Point(27, 244);
            this.lblOpenRevit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenRevit.Name = "lblOpenRevit";
            this.lblOpenRevit.Size = new System.Drawing.Size(67, 15);
            this.lblOpenRevit.TabIndex = 14;
            this.lblOpenRevit.Text = "Open Revit";
            this.lblOpenRevit.Visible = false;
            this.lblOpenRevit.Click += new System.EventHandler(this.lblOpenRevit_Click);
            // 
            // gbSelectAddin
            // 
            this.gbSelectAddin.Controls.Add(this.btnOpenFolder);
            this.gbSelectAddin.Controls.Add(this.lblDownloadFiles);
            this.gbSelectAddin.Controls.Add(this.lblSelectAddin);
            this.gbSelectAddin.Controls.Add(this.ddlAddinTestName);
            this.gbSelectAddin.Location = new System.Drawing.Point(17, 74);
            this.gbSelectAddin.Name = "gbSelectAddin";
            this.gbSelectAddin.Size = new System.Drawing.Size(219, 104);
            this.gbSelectAddin.TabIndex = 15;
            this.gbSelectAddin.TabStop = false;
            this.gbSelectAddin.Text = "groupBox1";
            // 
            // AddinTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 358);
            this.Controls.Add(this.gbSelectAddin);
            this.Controls.Add(this.lblOpenRevit);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestoreAddin);
            this.Controls.Add(this.btnApplyTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddinTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevitAddinTester";
            this.Load += new System.EventHandler(this.AddinTester_Load);
            this.gbSelectAddin.ResumeLayout(false);
            this.gbSelectAddin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestoreAddin;
        private System.Windows.Forms.Button btnApplyTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox ddlAddinTestName;
        private System.Windows.Forms.Label lblSelectAddin;
        private System.Windows.Forms.Label lblDownloadFiles;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblOpenRevit;
        private System.Windows.Forms.GroupBox gbSelectAddin;
    }
}