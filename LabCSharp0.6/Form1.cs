using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Moves the label to the upper left corner of the
        // form when the "Up" button is clicked
        private void up_Click(object sender, EventArgs e)
        {
            welcomeText.Location = new Point(0, 0);
        }

        // Moves the label to the lower left corner of the
        // form when the "Down" button is clicked.
        private void down_Click(object sender, EventArgs e)
        {
            welcomeText.Location = new Point(0, this.ClientSize.Height - welcomeText.Height);
        }
    }
}
