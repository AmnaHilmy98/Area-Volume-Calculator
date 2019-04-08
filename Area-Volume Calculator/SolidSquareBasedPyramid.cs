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
    public partial class FormSolidSquareBasedPyramid : Form
    {
        double area;
        double volume;
        double baseLength;
        double height;
        int intValidation;

        ErrorProvider errorProvider = new ErrorProvider();

        public FormSolidSquareBasedPyramid()
        {
            InitializeComponent();

            area = 0;
            volume = 0;
            baseLength = 0;
            height = 0;

            txtArea.ReadOnly = true;
            txtVolume.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    baseLength = int.Parse(txtBaseLength.Text);
                    height = int.Parse(txtHeight.Text);

                    area = Math.Pow(baseLength, 2) + (2 * baseLength) * (Math.Sqrt((Math.Pow(baseLength, 2)/4) + Math.Pow(height, 2)));
                    volume = Math.Pow(baseLength, 2) * height/3;

                    txtArea.Text = Math.Round(area, 3).ToString();
                    txtVolume.Text = Math.Round(volume, 3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBaseLength_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtBaseLength, "");
            if (!int.TryParse(txtBaseLength.Text, out intValidation))
            {
                errorProvider.SetError(txtBaseLength, "Please fill the required field");
            }
        }

        private void txtHeight_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtHeight, "");
            if (!int.TryParse(txtHeight.Text, out intValidation))
            {
                errorProvider.SetError(txtHeight, "Please fill the required field");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
