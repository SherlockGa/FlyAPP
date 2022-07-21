using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp
{
    public class Analysis
    {
        public List<(int formula, double h, double beta)> params_x;
        public List<(int formula, double h, double beta)> params_y;
        public Mechanism mechanism;
        public double step;
        public (double x, double y) pbase;
        public List<State> states;

        public Analysis(List<(int formula, double h, double beta)> plx, List<(int formula, double h, double beta)> ply, Mechanism mechanism, double accuracy, (double x, double y) initial_point)
        {
            this.params_x = plx;
            this.params_y = ply;
            this.mechanism = mechanism;
            this.step = accuracy;
            this.pbase = initial_point;
            this.states = new List<State>();
        }

        public void process()
        {
            double[] xs = get_coordinatesss(this.params_x);
            double[] ys = get_coordinatesss(this.params_y);
            int length = xs.Length;
            for (int i = 0; i < length; i++)
            {
                State state = new State(this.mechanism, xs[i] + this.pbase.x, ys[i] + this.pbase.y);
                state.analyze();
                this.states.Add(state);
            }
        }

        private List<double> get_coordinates(List<(int formula, double h, double beta)> parameters)
        {
            List<double> points = new List<double>();
            double h_sum = 0;
            double beta_sum = 0;
            foreach ((int formula, double h, double beta) param_set in parameters)
            {
                double theta = 0;
                while (theta < param_set.beta)
                {
                    double s = 0;
                    double p = theta / param_set.beta;
                    if (param_set.formula == 1)
                    {
                        s = h_sum + param_set.h * (10 * (Math.Pow(p, 3)) - 15 * (Math.Pow(p, 4)) + 6 * (Math.Pow(p, 5)));
                    }
                    else if (param_set.formula == 2)
                    {
                        s = h_sum + param_set.h * (35 * (Math.Pow(p, 4)) - 84 * (Math.Pow(p, 5)) + 70 * (Math.Pow(p, 6)) - 20 * (Math.Pow(p, 7)));
                    }
                    points.Add(s);
                    theta += this.step;
                }
                h_sum += param_set.h;
                beta_sum += param_set.beta;
            }
            return points;
        }

        private double[] get_coordinatesss(List<(int formula, double h, double beta)> parameters)
        {
            int len = (int)Math.Floor(2 * Math.PI / this.step);
            double[] points = new double[len];
            double h_sum = 0;
            double beta_sum = 0;
            int section = 0;
            for (int i = 0; i < len; i++)
            {
                double theta_total = this.step * i;
                if (theta_total > beta_sum + parameters[section].beta)
                {
                    h_sum += parameters[section].h;
                    beta_sum += parameters[section].beta;
                    section++;
                }
                double theta_local = theta_total - beta_sum;
                double p = theta_local / parameters[section].beta;
                if (parameters[section].formula == 1)
                {
                    points[i] = h_sum + parameters[section].h * (10 * (Math.Pow(p, 3)) - 15 * (Math.Pow(p, 4)) + 6 * (Math.Pow(p, 5)));
                }
                else if (parameters[section].formula == 2)
                {
                    points[i] = h_sum + parameters[section].h * (35 * (Math.Pow(p, 4)) - 84 * (Math.Pow(p, 5)) + 70 * (Math.Pow(p, 6)) - 20 * (Math.Pow(p, 7)));
                }
            }
            return points;
        }
    }

}
