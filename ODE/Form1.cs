using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ODE {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int num_of_series = 0;

        private void button1_Click(object sender, EventArgs e) {
            double begin = this.begin.Text == "" ? 0 : Convert.ToDouble(this.begin.Text);
            this.begin.Text = begin.ToString();
            double end = this.end.Text == "" ? 10 : Convert.ToDouble(this.end.Text);
            if (end - begin < 15) {
                end += 15;
            }
            this.end.Text = end.ToString();
            double h = this.H.Text == "" ? 0.01 : Convert.ToDouble(this.H.Text);
            this.H.Text = h.ToString();
            double lambda = this.lambda.Text == "" ? 3 : Convert.ToDouble(this.lambda.Text);
            this.lambda.Text = lambda.ToString();
            double x0dash = this._xdash0.Text == "" ? 1 : Convert.ToDouble(this._xdash0.Text);
            this._xdash0.Text = x0dash.ToString();
            double N = this.N.Text == "" ? 3 : Convert.ToDouble(this.N.Text);
            this.N.Text = N.ToString();
            
            this.chart1.Series.Add(Convert.ToString(++num_of_series));
            this.chart1.Series[num_of_series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[num_of_series].Color = Color.Black;
            
            List<double> res = new List<double>();
            List<double> res_v = new List<double>();
            int count = 0;
            RungeKutta.RungKUtt(begin, end, h, lambda, x0dash, N, res, res_v);
            for (double i = begin; i < end; i += h) {
                this.chart1.Series[num_of_series].Points.AddXY(i, res[count]);
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            for (int i = 0; i < num_of_series + 1; ++i) {
                this.chart1.Series[i].Points.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            this.end.Text = Convert.ToString(Convert.ToDouble(this.end.Text) + 10);
            button1_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e) {
            for (int i = -5; i < 6; ++i) {
                _xdash0.Text = i.ToString();
                button1_Click(sender, e);
            }

        }
    }
}
