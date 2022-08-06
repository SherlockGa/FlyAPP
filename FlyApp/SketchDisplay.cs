using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyApp
{
    public partial class SketchDisplay : Form
    {
        public ModelCycleDesignForm parentForm;
        public List<(int formula, double h, double beta)> parameter_list_x;
        public List<(int formula, double h, double beta)> parameter_list_y;
        public (double x, double y) Fpoint;
        public Mechanism mechanism;
        public Analysis analysis;
        public struct Point
        {
            public double x;
            public double y;
        }
        public SketchDisplay(ModelCycleDesignForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.Load += new EventHandler(this.SketchDisplay_Load);

        }
        private static double d2r(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        private void SketchDisplay_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = 360;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 20;
            chart2.ChartAreas[0].AxisX.Maximum = 360;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Interval = 20;
            chart3.ChartAreas[0].AxisY.Maximum = 300;
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Maximum = 500;
            chart3.ChartAreas[0].AxisX.Minimum = 200;
            parameter_list_x = parentForm.parameter_list_x;
            parameter_list_y = parentForm.parameter_list_y;
            Fpoint = parentForm.Fpoint;
            mechanism = parentForm.mechanism;
            analysis = new Analysis(parameter_list_x, parameter_list_y, mechanism, d2r(0.5), Fpoint);
            Boolean flag = true;
            try
            {
                analysis.process();
            }
            catch (NoSolutionException er)
            {
                Console.WriteLine(er.Message);
                flag = false;
            }
            catch (MultipleSolutionException er)
            {
                Console.WriteLine(er.Message);
                Console.WriteLine("Bad: This should not happen. Something is wrong with the restrictions.");
                flag = false;
            }
            if(flag == true)
            {
                paintChart1();
            }
            else
            {
                MessageBox.Show("Bad: This should not happen. Something is wrong with the restrictions.", "No solution/ Multi solution Error");
            }
        }
        private void paintChart1()
        {
            int cnt = 0;
            List<Point> x = new List<Point>();
            List<Point> y = new List<Point>();
            List<Point> xy = new List<Point>();
            foreach (State s in analysis.states)
            {
                Point p = new Point();
                Point p1 = new Point();
                Point p2 = new Point();
                p.x = cnt * 0.5;
                p.y = s.f.x;
                p1.x = cnt * 0.5;
                p1.y = s.f.y;
                p2.x = s.f.x;
                p2.y = s.f.y;
                x.Add(p);
                y.Add(p1);
                xy.Add(p2);
                chart1.Series[0].Points.AddXY(p.x,p.y);
                chart2.Series[0].Points.AddXY(p1.x, p1.y);
                chart3.Series[0].Points.AddXY(p2.x,p2.y);
                cnt++;
            }
           
        }
       
    }
}
