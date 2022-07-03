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
        public ModelCycleDesignForm()
        {
            InitializeComponent();
        }

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
                    return Check_Int_Float2(textBox29);
                case "button3":
                    return Check_Int_Float2(textBox30);
                case "button5":
                    return Check_Int_Float2(textBox31);
                case "button7":
                    return Check_Int_Float2(textBox32);
                case "button9":
                    return Check_Int_Float2(textBox33);
                case "button11":
                    return Check_Int_Float2(textBox34);
                case "button13":
                    return Check_Int_Float2(textBox35);
                case "button15":
                    return Check_Int_Float2(textBox36);
                case "button17":
                    return Check_Int_Float2(textBox37);
                case "button19":
                    return Check_Int_Float2(textBox38);
                case "button21":
                    return Check_Int_Float2(textBox39);
                case "button23":
                    return Check_Int_Float2(textBox40);
                case "button25":
                    return Check_Int_Float2(textBox41);
                case "button27":
                    return Check_Int_Float2(textBox42);
                default:
                    return false;
            }
        }

        private void Check_360()
        {
            TextBox[] listofText = { textBox29, textBox30, textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40, textBox41, textBox42};
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
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 2;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 3;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 4;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 5;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 6;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 7;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 8;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 9;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);
            
            unique_num = 10;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 11;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 12;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 13;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool checker = Check_Int_Float(button);

            unique_num = 14;
            if (unique_num == number_of_angles && checker == true) Check_360();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            number_of_angles = (int)numericUpDown1.Value;
        }
    }
}
