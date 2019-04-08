using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaVolumeCalculator
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void solidCone_Click(object sender, EventArgs e)
        {
            FormSolidCone solidCone = new FormSolidCone();
            solidCone.ShowDialog();
        }

        private void solidCylinder_Click(object sender, EventArgs e)
        {
            FormSolidCylinder solidCylinder = new FormSolidCylinder();
            solidCylinder.ShowDialog();
        }

        private void solidSphere_Click(object sender, EventArgs e)
        {
            FormSolidSphere solidSphere = new FormSolidSphere();
            solidSphere.ShowDialog();
        }

        private void solidSquareBasedPyramid_Click(object sender, EventArgs e)
        {
            FormSolidSquareBasedPyramid solidSquareBasedPyramid = new FormSolidSquareBasedPyramid();
            solidSquareBasedPyramid.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
