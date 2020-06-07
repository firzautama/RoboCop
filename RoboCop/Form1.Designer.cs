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
            this.btnShowPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectSourceFiles
            // 
            this.btnSelectSourceFiles.AccessibleName = "";
            this.btnSelectSourceFiles.BackColor = System.Drawing.Color.Black;
            this.btnSelectSourceFiles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectSourceFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSourceFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSourceFiles.ForeColor = System.Drawing.Color.White;
            this.btnSelectSourceFiles.Location = new System.Drawing.Point(25, 45);
            this.btnSelectSourceFiles.Name = "btnSelectSourceFiles";
            this.btnSelectSourceFiles.Size = new System.Drawing.Size(255, 71);
            this.btnSelectSourceFiles.TabIndex = 0;
            this.btnSelectSourceFiles.Text = "Select Source Files";
            this.btnSelectSourceFiles.UseVisualStyleBackColor = false;
            this.btnSelectSourceFiles.Click += new System.EventHandler(this.btnSelectSourceFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(132)))));
            this.lblFileName.Location = new System.Drawing.Point(23, 125);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(137, 22);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "xx files selected";
            this.lblFileName.Visible = false;
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(166, 123);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(114, 34);
            this.btnShowSelected.TabIndex = 2;
            this.btnShowSelected.Text = "Show Files";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Visible = false;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.AccessibleName = "";
            this.btnSelectDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnSelectDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.btnSelectDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDestination.ForeColor = System.Drawing.Color.White;
            this.btnSelectDestination.Location = new System.Drawing.Point(25, 230);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(255, 71);
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
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(25, 410);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(255, 75);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Robo Cop";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbRename
            // 
            this.tbRename.Location = new System.Drawing.Point(25, 346);
            this.tbRename.Name = "tbRename";
            this.tbRename.Size = new System.Drawing.Size(255, 26);
            this.tbRename.TabIndex = 6;
            this.tbRename.Text = "New file name";
            this.tbRename.Visible = false;
            this.tbRename.TextChanged += new System.EventHandler(this.tbRename_TextChanged);
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Location = new System.Drawing.Point(25, 312);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(96, 24);
            this.cbRename.TabIndex = 7;
            this.cbRename.Text = "Rename";
            this.cbRename.UseVisualStyleBackColor = true;
            this.cbRename.Visible = false;
            this.cbRename.CheckedChanged += new System.EventHandler(this.cbRename_CheckedChanged);
            // 
            // btnShowPath
            // 
            this.btnShowPath.Location = new System.Drawing.Point(166, 308);
            this.btnShowPath.Name = "btnShowPath";
            this.btnShowPath.Size = new System.Drawing.Size(114, 34);
            this.btnShowPath.TabIndex = 8;
            this.btnShowPath.Text = "Show Path";
            this.btnShowPath.UseVisualStyleBackColor = true;
            this.btnShowPath.Visible = false;
            this.btnShowPath.Click += new System.EventHandler(this.btnShowPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 532);
            this.Controls.Add(this.btnShowPath);
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
        private System.Windows.Forms.Button btnShowPath;
    }
}

