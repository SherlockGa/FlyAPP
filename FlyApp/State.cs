using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp
{
    public class State
    {
        public (double x, double y) a, b, c, d, e, f, g, h, m, n, k;
        public double alpha1, alpha2, abc, cdg, agd, ahm;
        public Mechanism mech;

        public State(Mechanism mechanism, double x, double y)
        {
            this.mech = mechanism;
            this.f = (x, y);
        }

        public void analyze()
        {
            // Points
            var m = this.mech;
            this.a = (0, 0);
            this.e = (this.f.x - m.lef * Math.Cos(m.beta3), this.f.y - m.lef * Math.Sin(m.beta3));
            this.d = (this.e.x - m.lde, this.e.y);
            this.c = (this.d.x - m.lcd, this.d.y);
            this.alpha1 = this.calculate_alpha1(m);
            this.alpha2 = this.calculate_alpha2(m);
            this.b = (m.lab * Math.Cos(this.alpha1), m.lab * Math.Sin(this.alpha1));
            this.g = (m.lag * Math.Cos(this.alpha2), m.lag * Math.Sin(this.alpha2));
            this.h = (m.lah * Math.Cos(this.alpha2 - m.beta1), m.lah * Math.Sin(this.alpha2 - m.beta1));
            this.m = (this.h.x + m.lan, this.h.y);
            this.n = (this.a.x + m.lan, this.a.y);
            this.k = (this.g.x + m.lan, this.g.y);
            // Pressure Angles
            this.abc = calculate_angle(this.a, this.b, this.c);
            this.cdg = calculate_angle(this.c, this.c, this.g);
            this.agd = calculate_angle(this.a, this.g, this.d);
            this.ahm = calculate_angle(this.a, this.h, this.m);
        }

        private double calculate_alpha1(Mechanism m)
        {
            // Equation here based on lbc
            var rhs_bc = (Math.Pow(m.lab, 2) - Math.Pow(m.lbc, 2) + Math.Pow(this.c.x, 2) + Math.Pow(this.c.y, 2)) / (2 * m.lab);
            double[] alpha1_cand;
            try
            {
                alpha1_cand = solve_alpha(this.c.x, this.c.y, rhs_bc);
            }
            catch (NoSolutionException)
            {
                throw;
            }
            int count = 0;
            double valid = 0;
            foreach (var value in alpha1_cand)
            {
                var bx = m.lab * Math.Cos(value);
                if (bx < this.c.x)
                {
                    valid = value;
                    count += 1;
                }
            }
            if (count == 0) throw (new NoSolutionException("No Valid Solution for alpha1"));
            if (count > 1) throw (new MultipleSolutionException("Multiple Valid Solution for alpha1"));
            return valid;
        }

        private double calculate_alpha2(Mechanism m)
        {
            // Equation here based on ldg
            double rhs_dg = (Math.Pow(m.lag, 2) - Math.Pow(m.ldg, 2) + Math.Pow(this.d.x, 2) + Math.Pow(this.d.y, 2)) / (2 * m.lag);
            double[] alpha2_cand;
            try
            {
                alpha2_cand = solve_alpha(this.d.x, this.d.y, rhs_dg);
            }
            catch (NoSolutionException)
            {
                throw;
            }
            int count = 0;
            double valid = 0;
            foreach (var value in alpha2_cand)
            {
                if (value >= -0.5 * Math.PI && value <= 0.5 * Math.PI)
                {
                    valid = value;
                    count += 1;
                }
            }
            if (count == 0) throw (new NoSolutionException("No Valid Solution for alpha2"));
            if (count > 1) throw (new MultipleSolutionException("Multiple Valid Solution for alpha2"));
            return valid;
        }

        private double[] solve_alpha(double a, double b, double c)
        {
            var den = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            var theta = solve_theta(b / den, a / den);
            double angle = Math.Asin(c / den);
            if (angle == double.NaN) throw (new NoSolutionException("Math error"));
            double[] alpha = new double[2];
            alpha[0] = normalize(angle - theta);
            alpha[1] = normalize(Math.PI - angle - theta);
            return alpha;
        }

        private double solve_theta(double cos_t, double sin_t)
        {
            double theta = Math.Acos(Math.Abs(cos_t));
            if (theta == double.NaN) throw (new NoSolutionException("Math error"));
            if (cos_t >= 0 && sin_t >= 0) return theta;
            if (cos_t < 0 && sin_t > 0) return Math.PI - theta;
            if (cos_t < 0 && sin_t < 0) return Math.PI + theta;
            if (cos_t > 0 && sin_t < 0) return 2 * Math.PI - theta;
            return default(double);
        }

        private double normalize(double angle)
        {
            while (angle < -Math.PI)
            {
                angle += 2 * Math.PI;
            }
            while (angle > Math.PI)
            {
                angle -= 2 * Math.PI;
            }
            return angle;
        }

        // Calculate the angle given three points
        private double calculate_angle((double x, double y) a, (double x, double y) b, (double x, double y) c)
        {
            var ang = Math.Atan2(c.y - b.y, c.x - b.x) - Math.Atan2(a.y - b.y, a.x - b.x);
            return Math.Abs(ang);
        }
    }

    public class NoSolutionException : Exception
    {
        public NoSolutionException(string message) : base(message)
        {
        }
    }

    public class MultipleSolutionException : Exception
    {
        public MultipleSolutionException(string message) : base(message)
        {
        }
    }

}
