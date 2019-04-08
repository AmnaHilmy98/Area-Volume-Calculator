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
    public partial class FormSolidCylinder : Form
    {
        double area;
        double volume;
        double radius;
        double height;
        int intValidation;

        ErrorProvider errorProvider = new ErrorProvider();

        public FormSolidCylinder()
        {
            InitializeComponent();

            area = 0;
            volume = 0;
            radius = 0;
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
                    radius = int.Parse(txtRadius.Text);
                    height = int.Parse(txtHeight.Text);

                    area = (2 * Math.PI * Math.Pow(radius, 2)) + (2 * Math.PI * radius * height);
                    volume = Math.PI * Math.Pow(radius, 2) * height;

                    txtArea.Text = Math.Round(area, 3).ToString();
                    txtVolume.Text = Math.Round(volume, 3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRadius_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtRadius, "");
            if (!int.TryParse(txtRadius.Text, out intValidation))
            {
                errorProvider.SetError(txtRadius, "Please fill the required field");
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
