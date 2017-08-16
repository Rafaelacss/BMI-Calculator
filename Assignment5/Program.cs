using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rafaela Silveira
 * Student number: 300910503
 * Date: August, 15, 2017
 * Description: BMI Calculator Project - Assignment 5
 * Version: 0.2 - updated summary
 */

namespace BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The BMI Calculator will calculate the standard body mass of a person
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
