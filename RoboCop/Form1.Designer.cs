namespace RoboCop
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
            this.btnSelectSourceFiles = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbRename = new System.Windows.Forms.TextBox();
            this.cbRename = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSelectSourceFiles
            // 
            this.btnSelectSourceFiles.AccessibleName = "";
            this.btnSelectSourceFiles.Location = new System.Drawing.Point(25, 45);
            this.btnSelectSourceFiles.Name = "btnSelectSourceFiles";
            this.btnSelectSourceFiles.Size = new System.Drawing.Size(219, 71);
            this.btnSelectSourceFiles.TabIndex = 0;
            this.btnSelectSourceFiles.Text = "Select Source Files";
            this.btnSelectSourceFiles.UseVisualStyleBackColor = true;
            this.btnSelectSourceFiles.Click += new System.EventHandler(this.btnSelectSourceFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(21, 135);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(119, 20);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "xx files selected";
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(146, 131);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(98, 29);
            this.btnShowSelected.TabIndex = 2;
            this.btnShowSelected.Text = "Show Files";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.AccessibleName = "";
            this.btnSelectDestination.Location = new System.Drawing.Point(25, 226);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(219, 71);
            this.btnSelectDestination.TabIndex = 3;
            this.btnSelectDestination.Text = "Select Destination Folder";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleName = "";
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCopy.Location = new System.Drawing.Point(25, 408);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(219, 75);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Robo Cop";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbRename
            // 
            this.tbRename.Location = new System.Drawing.Point(25, 333);
            this.tbRename.Name = "tbRename";
            this.tbRename.Size = new System.Drawing.Size(219, 26);
            this.tbRename.TabIndex = 6;
            this.tbRename.Text = "New file name";
            this.tbRename.Visible = false;
            this.tbRename.TextChanged += new System.EventHandler(this.tbRename_TextChanged);
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Location = new System.Drawing.Point(25, 303);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(96, 24);
            this.cbRename.TabIndex = 7;
            this.cbRename.Text = "Rename";
            this.cbRename.UseVisualStyleBackColor = true;
            this.cbRename.CheckedChanged += new System.EventHandler(this.cbRename_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 495);
            this.Controls.Add(this.cbRename);
            this.Controls.Add(this.tbRename);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnSelectSourceFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoboCop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourceFiles;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbRename;
        private System.Windows.Forms.CheckBox cbRename;
    }
}

