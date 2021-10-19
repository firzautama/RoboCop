
namespace RoboCop
{
    partial class BecaBetaInstaller
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
            this.cb_FilesInDirectory = new System.Windows.Forms.ComboBox();
            this.cb_RevitVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_FilesInDirectory
            // 
            this.cb_FilesInDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_FilesInDirectory.FormattingEnabled = true;
            this.cb_FilesInDirectory.Location = new System.Drawing.Point(12, 70);
            this.cb_FilesInDirectory.Name = "cb_FilesInDirectory";
            this.cb_FilesInDirectory.Size = new System.Drawing.Size(220, 21);
            this.cb_FilesInDirectory.TabIndex = 0;
            // 
            // cb_RevitVersion
            // 
            this.cb_RevitVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_RevitVersion.FormattingEnabled = true;
            this.cb_RevitVersion.Location = new System.Drawing.Point(12, 26);
            this.cb_RevitVersion.Name = "cb_RevitVersion";
            this.cb_RevitVersion.Size = new System.Drawing.Size(220, 21);
            this.cb_RevitVersion.TabIndex = 1;
            this.cb_RevitVersion.SelectedValueChanged += new System.EventHandler(this.cb_RevitVersion_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Revit Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Beta Tab";
            // 
            // btn_Install
            // 
            this.btn_Install.BackColor = System.Drawing.Color.Black;
            this.btn_Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Install.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Install.ForeColor = System.Drawing.Color.White;
            this.btn_Install.Location = new System.Drawing.Point(129, 111);
            this.btn_Install.Name = "btn_Install";
            this.btn_Install.Size = new System.Drawing.Size(103, 30);
            this.btn_Install.TabIndex = 4;
            this.btn_Install.Text = "Install";
            this.btn_Install.UseVisualStyleBackColor = false;
            this.btn_Install.Click += new System.EventHandler(this.btn_Install_Click);
            // 
            // BecaBetaInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(244, 153);
            this.Controls.Add(this.btn_Install);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_RevitVersion);
            this.Controls.Add(this.cb_FilesInDirectory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BecaBetaInstaller";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BecaBetaInstaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_FilesInDirectory;
        private System.Windows.Forms.ComboBox cb_RevitVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Install;
    }
}