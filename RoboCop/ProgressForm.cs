using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCop
{
    public partial class ProgressForm : Form
    {
        string _format;

        /// <summary>
        /// Set up progress bar form and immediately display it modelessly.
        /// </summary>
        /// <param name="caption">Form caption</param>
        /// <param name="format">Progress message string</param>
        /// <param name="max">Number of elements to process</param>
        public ProgressForm(string caption, string format, int max)
        {
            _format = format;
            InitializeComponent();
            Text = caption;
            progressBar1.ForeColor = Color.FromArgb(141, 14, 132);
            progressBar1.BackColor = Color.FromArgb(141, 14, 132);
            label1.Text = (null == format) ? caption : string.Format(format, 0);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = max;
            progressBar1.Value = 0;
            Show();
            Application.DoEvents();
        }

        public void Increment()
        {
            ++progressBar1.Value;
            if (null != _format)
            {
                label1.Text = string.Format(_format, progressBar1.Value);
            }
            Application.DoEvents();
        }

        public void IncrementWithName(string stepName)
        {
            Text = stepName;
            ++progressBar1.Value;
            if (null != _format)
            {
                label1.Text = string.Format(_format, progressBar1.Value);
            }
            Application.DoEvents();
        }
    }
}
