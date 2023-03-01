using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osnovu_practica12_zad4
{
    public partial class Form1 : Form
    {
        public bool chek()
        {
            int n = 0;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0) n += 1;
            if (radioButton1.Checked || radioButton2.Checked) n += 1;
            if(n == 2) return true;
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = false;

            if (chek())
            {
                //Присвоение переменных
                Sportsmen human = new Sportsmen();

                human.familia = textBox3.Text;
                human.otchestvo = textBox2.Text;
                human.name = textBox1.Text;

                string day = Convert.ToString(numericUpDown3.Value);
                string month = Convert.ToString(numericUpDown4.Value);
                string year = Convert.ToString(numericUpDown5.Value);
                human.data_roz = Convert.ToDateTime(day + "/" + month + "/" + year);

                human.vid_sporta = textBox4.Text;

                human.rost = Convert.ToDouble(numericUpDown1.Value);
                human.ves = Convert.ToDouble(numericUpDown2.Value);

                if (radioButton1.Checked)
                {
                    human.pol = "М";
                }
                else human.pol = "Ж";

                //Выполнение фунций
                label14.Text = human.get_info();
                label15.Text = Convert.ToString(human.Brok_ves());
                label16.Text = Convert.ToString(human.Kuper_ves());
                label17.Text = human.imt();

            }
            else
            {
                label9.Visible = true;
                label9.Text = "Необходимо заполнить все поля";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
            }

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1 .Checked = false;
            radioButton2 .Checked = false;
        }
    }
}
