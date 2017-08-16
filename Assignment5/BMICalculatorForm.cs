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
 * Description: BMI Calculator Project
 * Version: 0.2 - implemented bmi calculation
 */

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        //Private variables
        private double _height;
        private double _weight;
        private double _result;

        public double UserHeight
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        public double UserWeight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            _calculatebmi();
        }

        private void _calculatebmi()
        {
            UserHeight = Convert.ToDouble(HeightTextBox.Text);
            UserWeight = Convert.ToDouble(WeightTextBox.Text);

            if (MetricButton.Checked)
            {
                Result = UserWeight / (UserHeight * UserHeight);
            }
            else
                if(ImperialButton.Checked)
            {
                Result = (UserWeight * 703) / (UserHeight * UserHeight);
            }
            

            BMITextBoxControl.Text = Convert.ToString(Result);


        }
    }
}
