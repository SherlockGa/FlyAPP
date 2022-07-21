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
    public partial class PlannerCamDesignForm : Form
    {
        public Analysis analysis;
        public ModelCycleDesignForm inputForm;
        private Boolean validResultFlag;

        private static double d2r(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        public PlannerCamDesignForm(ModelCycleDesignForm form1)
        {
            InitializeComponent();
            inputForm = form1;
            this.Load += new EventHandler(this.PlannerCamDesignForm_Load);
        }
        private void PlannerCamDesignForm_Load(object sender, EventArgs e)
        {
            //inputForm = (ModelCycleDesignForm) this.Owner;
            analysis = new Analysis(inputForm.parameter_list_x, inputForm.parameter_list_y, inputForm.mechanism, d2r(0.5), (392, 160));

            validResultFlag = true;
            try
            {
                analysis.process();
            }
            catch (NoSolutionException er)
            {
                Console.WriteLine(er.Message);
                validResultFlag=false;
            }
            catch (MultipleSolutionException er)
            {
                Console.WriteLine(er.Message);
                Console.WriteLine("Bad: This should not happen. Something is wrong with the restrictions.");
                validResultFlag = false;
            }

            Console.WriteLine("States Count {0}", analysis.states.Count);
            int x = 20;
            Console.WriteLine("State " + x + " Alpha1: " + analysis.states[x].alpha1 * 180 / Math.PI);
            Console.WriteLine("State " + x + " Alpha2: " + analysis.states[x].alpha2 * 180 / Math.PI);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DataButton1_Click(object sender, EventArgs e)
        {
            if(validResultFlag == true)
            {
                foreach (State s in analysis.states)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = s.alpha1;
                    dataGridView1.Rows[index].Cells[1].Value = s.alpha2;
                }
            }
            else
            {
                MessageBox.Show("Bad: This should not happen. Something is wrong with the restrictions.", "No solution/ Multi solution Error");
            }
        }
    }
}
