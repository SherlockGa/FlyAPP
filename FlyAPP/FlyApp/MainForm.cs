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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelCycleDesignForm modelCycleDesignForm = new ModelCycleDesignForm();
            modelCycleDesignForm.Show();
        }

       

       

        private void button4_Click(object sender, EventArgs e)
        {
            PlannerCamDesignForm plannerCamDesignForm = new PlannerCamDesignForm();
            plannerCamDesignForm.Show();
        }

       
    }
}
