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
        public SketchDisplay(ModelCycleDesignForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.Load += new EventHandler(this.SketchDisplay_Load);

        }

        private void SketchDisplay_Load(object sender, EventArgs e)
        {
            parameter_list_x = parentForm.parameter_list_x;
            parameter_list_y = parentForm.parameter_list_y;
            Fpoint = parentForm.Fpoint;
        }

        private void SketchDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, 10, 10, 100, 100);
        }
    }
}
