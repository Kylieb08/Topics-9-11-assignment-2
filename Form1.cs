using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topics_9_11_assignment_2
{
    public partial class FormTempGauge : Form
    {
        public FormTempGauge()
        {
            InitializeComponent();
        }

        private void btnCelsius_MouseLeave(object sender, EventArgs e)
        {
            imgTemp.Visible = false;
            lblIcebergHouse.Visible = false;
        }

        private void btnCelsius_MouseEnter(object sender, EventArgs e)
        {
            imgTemp.Visible = true;
            int temperature = (int)numTemp.Value;
            if (temperature < 0)
            {
                imgTemp.Image = Properties.Resources.Iceberg;
                lblIcebergHouse.Visible = true;
            }
            else if (temperature >= 0 && temperature <= 25)
            {
                imgTemp.Image = Properties.Resources.Frozen_thermometer;
            }
            else if (temperature > 25 && temperature <= 40)
            {
                imgTemp.Image = Properties.Resources.High_temp_thermometer;
            }
            else if (temperature >= 40 && temperature <= 100)
            {
                imgTemp.Image = Properties.Resources.sun_with_glasses;
            }
            else
            {
                imgTemp.Image = Properties.Resources.Fire;
            }
        }

        private void btnFarenheight_MouseLeave(object sender, EventArgs e)
        {
            imgTemp.Visible = false;
            lblIcebergHouse.Visible = false;
        }

        private void btnFarenheight_MouseEnter(object sender, EventArgs e)
        {
            imgTemp.Visible = true;
            int temperature = (int)numTemp.Value;
            if (temperature < 32)
            {
                imgTemp.Image = Properties.Resources.Iceberg;
                lblIcebergHouse.Visible = true;
            }

            else if (temperature >= 32 && temperature <= 77)
            {
                imgTemp.Image = Properties.Resources.Frozen_thermometer;
            }
            else if (temperature > 77 && temperature <= 104)
            {
                imgTemp.Image = Properties.Resources.High_temp_thermometer;
            }
            else if (temperature >= 104 && temperature <= 212)
            {
                imgTemp.Image = Properties.Resources.sun_with_glasses;
            }
            else
            {
                imgTemp.Image = Properties.Resources.Fire;
            }
        }
    }
}
