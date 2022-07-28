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

    public partial class ModelCycleDesignForm : Form
    {
        /* ------------------------------------------------------------------------------------*/
        /* -------------------------------------- Variables -----------------------------------*/
        /* ------------------------------------------------------------------------------------*/
        public Mechanism mechanism;
        public List<(int formula, double h, double beta)> parameter_list_x;
        public List<(int formula, double h, double beta)> parameter_list_y;
        public (double x, double y) Fpoint;
        private static double d2r(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        /* ------------------------------------------------------------------------------------*/
        /* -------------------------------------- Load Form -----------------------------------*/
        /* ------------------------------------------------------------------------------------*/
        public ModelCycleDesignForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.ModelCycleDesignForm_Load);
        }
        private void ModelCycleDesignForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox2.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox3.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox4.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox5.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox6.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox7.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox8.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox9.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox10.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox11.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox12.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox13.DataSource = new List<string> { "3-4-5", "4-5-6-7" };
            comboBox14.DataSource = new List<string> { "3-4-5", "4-5-6-7" };

            //mechanism = new Mechanism();
            parameter_list_x = new List<(int formula, double h, double beta)>();
            parameter_list_y = new List<(int formula, double h, double beta)>();
        }

        /* ------------------------------------------------------------------------------------*/
        /* -------------------------------------- Error Message -----------------------------------*/
        /* ------------------------------------------------------------------------------------*/
        public static int number_of_angles = 1;
        public static int unique_num = 0;
      
        private bool Check_Int_Float2(TextBox textbox_name)
        {
            int i;
            float f;
            if (!int.TryParse(textbox_name.Text, out i) && !float.TryParse(textbox_name.Text, out f) && !(textbox_name.Text.Length == 0))
            {
                MessageBox.Show("请输入整数或小数", "错误");
                textbox_name.Text = "";
                return false;
            }
            else return true;
        }

        private bool Check_Int_Float(Button button_name)
        {
            switch (button_name.Name)
            {
                case "button1":
                    return Check_Int_Float2(textBox1);
                case "button3":
                    return Check_Int_Float2(textBox3);
                case "button5":
                    return Check_Int_Float2(textBox5);
                case "button7":
                    return Check_Int_Float2(textBox7);
                case "button9":
                    return Check_Int_Float2(textBox9);
                case "button11":
                    return Check_Int_Float2(textBox11);
                case "button13":
                    return Check_Int_Float2(textBox13);
                case "button15":
                    return Check_Int_Float2(textBox15);
                case "button17":
                    return Check_Int_Float2(textBox17);
                case "button19":
                    return Check_Int_Float2(textBox19);
                case "button21":
                    return Check_Int_Float2(textBox21);
                case "button23":
                    return Check_Int_Float2(textBox23);
                case "button25":
                    return Check_Int_Float2(textBox25);
                case "button27":
                    return Check_Int_Float2(textBox27);
                default:
                    return false;
            }
        }

        private void Check_360()
        {
            TextBox[] listofText = { textBox1, textBox3, textBox5, textBox7, textBox9, textBox11, textBox13, textBox15, textBox17, textBox19, textBox21, textBox23, textBox25, textBox27};
            int angle_sum = 0;
            for (int i = 0; i < number_of_angles; i++)
            {
                //TextBox tester = listofText[i];
                angle_sum = angle_sum + int.Parse(listofText[i].Text);
            }
            if (angle_sum != 360)
            {
                MessageBox.Show("所有段的角度和须为360度, " + angle_sum.ToString(), "错误");
                listofText[number_of_angles-1].Clear();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 1;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox1.Text);
            double h = double.Parse(textBox2.Text);
            int f = comboBox1.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 2;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox3.Text);
            double h = double.Parse(textBox4.Text);
            int f = comboBox2.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 3;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox5.Text);
            double h = double.Parse(textBox6.Text);
            int f = comboBox3.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 4;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox7.Text);
            double h = double.Parse(textBox8.Text);
            int f = comboBox4.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 5;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox9.Text);
            double h = double.Parse(textBox10.Text);
            int f = comboBox5.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 6;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox11.Text);
            double h = double.Parse(textBox12.Text);
            int f = comboBox6.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 7;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox13.Text);
            double h = double.Parse(textBox14.Text);
            int f = comboBox7.SelectedIndex + 1;
            parameter_list_x.Add((f, h, d2r(beta)));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 8;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox15.Text);
            double h = double.Parse(textBox16.Text);
            int f = comboBox8.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 9;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox17.Text);
            double h = double.Parse(textBox18.Text);
            int f = comboBox9.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);
            
            unique_num = 10;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox19.Text);
            double h = double.Parse(textBox20.Text);
            int f = comboBox10.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 11;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox21.Text);
            double h = double.Parse(textBox22.Text);
            int f = comboBox11.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 12;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox23.Text);
            double h = double.Parse(textBox24.Text);
            int f = comboBox12.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 13;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox25.Text);
            double h = double.Parse(textBox26.Text);
            int f = comboBox13.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 14;
            //if (unique_num == number_of_angles && checker == true) Check_360();
            double beta = double.Parse(textBox27.Text);
            double h = double.Parse(textBox28.Text);
            int f = comboBox14.SelectedIndex + 1;
            parameter_list_y.Add((f, h, d2r(beta)));
        }

        
        /* ------------------------------------------------------------------------------------*/
        /* -------------------------------------- Input -----------------------------------*/
        /* ------------------------------------------------------------------------------------*/
        private void button29_Click(object sender, EventArgs e)
        {
           
            // show result form
            PlannerCamDesignForm resultForm = new PlannerCamDesignForm(this);
            resultForm.Visible = true;
            resultForm.Show();
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
            BasicParamInput basicParamInput = new BasicParamInput(this);
            basicParamInput.Show();
        }

    }
}
