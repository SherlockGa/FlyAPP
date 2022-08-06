using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            analysis = new Analysis(inputForm.parameter_list_x, inputForm.parameter_list_y, inputForm.mechanism, d2r(0.5), inputForm.Fpoint);

            validResultFlag = true;
            try
            {
                analysis.process();
            }
            catch (NoSolutionException er)
            {
                //Console.WriteLine(er.Message);
                validResultFlag=false;
            }
            catch (MultipleSolutionException er)
            {
                //Console.WriteLine(er.Message);
                //Console.WriteLine("Bad: This should not happen. Something is wrong with the restrictions.");
                validResultFlag = false;
            }

            
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
                    dataGridView1.Rows[index].Cells[0].Value = index*0.5;
                    dataGridView1.Rows[index].Cells[1].Value = s.alpha1;
                    dataGridView1.Rows[index].Cells[2].Value = s.alpha2;
                    dataGridView1.Rows[index].Cells[3].Value = s.abc;
                    dataGridView1.Rows[index].Cells[4].Value = s.cdg;
                    dataGridView1.Rows[index].Cells[5].Value = s.agd;
                    dataGridView1.Rows[index].Cells[6].Value = s.ahm;
                }
            }
            else
            {
                MessageBox.Show("Bad: This should not happen. Something is wrong with the restrictions.", "No solution/ Multi solution Error");
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Execl files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString();
            }
            using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string line = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null) break;
                        line += cell.Value.ToString();
                        line += ",";
                    }
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            
        }
    }
}
