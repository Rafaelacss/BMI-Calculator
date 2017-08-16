using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
