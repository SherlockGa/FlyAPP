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
    public partial class BasicParamInput : Form
    {
        public ModelCycleDesignForm parent;
        public BasicParamInput(ModelCycleDesignForm modelCycleDesignForm)
        {
            InitializeComponent();
            parent = modelCycleDesignForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lab = double.Parse(textBox1.Text);
            double lbc = double.Parse(textBox2.Text);
            double lcd = double.Parse(textBox3.Text);
            double lde = double.Parse(textBox4.Text);
            double lhm = double.Parse(textBox5.Text);
            double lan = double.Parse(textBox6.Text);
            double lef = double.Parse(textBox7.Text);
            double ldg = double.Parse(textBox8.Text);
            double lek = double.Parse(textBox9.Text);
            double lag = double.Parse(textBox10.Text);
            double lnk = double.Parse(textBox11.Text);
            double lah = double.Parse(textBox12.Text);
            double lnm = double.Parse(textBox13.Text);
            parent.mechanism = new Mechanism();
            parent.Fpoint = (double.Parse(textBox14.Text), double.Parse(textBox15.Text));

            this.Close();
        }
    }
}
