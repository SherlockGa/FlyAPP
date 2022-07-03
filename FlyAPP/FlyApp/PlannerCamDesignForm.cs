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
        public PlannerCamDesignForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.PlannerCamDesignForm_Load);
        }
        private void PlannerCamDesignForm_Load(object sender, EventArgs e)
        {
            SetColumnWidth();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetColumnWidth()
        {
            int listwidth = listView1.Width;
            int columnNum = listView1.Columns.Count;
            foreach (ColumnHeader i in listView1.Columns)
            {
                i.Width = listwidth / columnNum;
            }
        }

        
    }
}
