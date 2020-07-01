using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poisson
{
    public partial class Form1 : Form
    {
        Poisson poisson;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            double tV = (double)timeValue.Value;
            int nV = (int)numberValue.Value;
            double l1 = (double)lambda1Value.Value;
            double l2 = (double)lambda2Value.Value;
            poisson = new Poisson(tV, nV, l1, l2);
            poisson.Start();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < poisson.possbilities.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, poisson.possbilities[i]);
                chart1.Series[1].Points.AddXY(i, poisson.teorPossibs[i]);
            }
            averageLabel.Text = "Соотн. с теор. идеал. Average =  " + poisson.AverageError;
            varianceLabel.Text = "Соотн. с теор. идеал. Variance = " + poisson.VarianceError;
            chiSquareLabel.Text = "Соотн. с теор. идеал. ChiSquared = " + poisson.Chi + " " + poisson.ChiTest;
        }
    }
}
