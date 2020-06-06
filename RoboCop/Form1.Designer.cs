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
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectSourceFiles
            // 
            this.btnSelectSourceFiles.AccessibleName = "";
            this.btnSelectSourceFiles.Location = new System.Drawing.Point(25, 81);
            this.btnSelectSourceFiles.Name = "btnSelectSourceFiles";
            this.btnSelectSourceFiles.Size = new System.Drawing.Size(219, 35);
            this.btnSelectSourceFiles.TabIndex = 0;
            this.btnSelectSourceFiles.Text = "Select Source Files";
            this.btnSelectSourceFiles.UseVisualStyleBackColor = true;
            this.btnSelectSourceFiles.Click += new System.EventHandler(this.btnSelectSourceFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(21, 126);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(119, 20);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "xx files selected";
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(146, 144);
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
            this.btnSelectDestination.Location = new System.Drawing.Point(25, 191);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(219, 35);
            this.btnSelectDestination.TabIndex = 3;
            this.btnSelectDestination.Text = "Select Destination Folder";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleName = "";
            this.btnCopy.Location = new System.Drawing.Point(25, 262);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(219, 35);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Robo Cop";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(250, 198);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(127, 20);
            this.lblDestinationPath.TabIndex = 5;
            this.lblDestinationPath.Text = "Destination Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDestinationPath);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnSelectSourceFiles);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblDestinationPath;
    }
}

