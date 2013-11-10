using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class PandyApp : Form
    {
        public PandyApp()
        {
            InitializeComponent();
            PandyVisDesg Pandy = new PandyVisDesg();
            Pandy.Show();
        }
        private void PandyApp_Load(object sender, EventArgs e)
        {
            timerSocial.Enabled = true;
            timerSocial.Start();
            timerSocial.Interval = 1000;
            prgbar_social.Maximum = 100;
            timerSocial.Tick += new EventHandler(timerSocial_Tick);

            timerFood.Enabled = true;
            timerFood.Start();
            timerFood.Interval = 1000;
            prgbar_food.Maximum = 100;
            timerFood.Tick += new EventHandler(timerFood_Tick);

            timerRest.Enabled = true;
            timerRest.Start();
            timerRest.Interval = 1000;
            prgbar_rest.Maximum = 100;
            timerRest.Tick += new EventHandler(timerRest_Tick);
        }

        private void timerSocial_Tick(object sender, EventArgs e)
        {
            if (prgbar_social.Value != 100)
            {
                prgbar_social.Value++;
            }
            else
            {
                timerSocial.Stop();
            }

        }

        private void timerFood_Tick(object sender, EventArgs e)
        {
            if (prgbar_food.Value != 100)
            {
                prgbar_food.Value++;
            }
            else
            {
                timerFood.Stop();
            }

        }

        private void timerRest_Tick(object sender, EventArgs e)
       {
            if (prgbar_rest.Value != 100)
            {
                prgbar_rest.Value++;
            }
            else
            {
                timerRest.Stop();
            }

        }
        
    }
}
