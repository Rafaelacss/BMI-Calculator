using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rafaela Silveira
 * Student number: 300910503
 * Date: August, 15, 2017
 * Description: Splash Form - 3sec
 * Version: 0.1 - created the splash form
 */

namespace BMICalculator
{
    public partial class Splash : Form
    {
        public BMICalculatorForm BMICalculator
        {
            get
            {
                return Program.bmiCalculatorForm;
            }
        }

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BMICalculator.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
