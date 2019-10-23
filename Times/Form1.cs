using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Time> MassivTime = new List<Time>();

        List<string> TEMP = new List<string>();

        private void CreateTimeButton_Click(object sender, EventArgs e)
        {
            Time time = new Time((int)HoursUp.Value, (int)MinutesUp.Value);
            string name = time.GetTime();
            MassivTime.Add(time);
            TEMP.Add(name);
            listBox1.Items.Add(name);

            CountTime.Text = "You have " + time.GetIdTime() +  " time";
        }

        private void AddTimButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>-1)
            {
                Time time = MassivTime[listBox1.SelectedIndex];
                time += (int)MinutesAdd.Value;
                string name = time.GetTime();
                MassivTime[listBox1.SelectedIndex] = time;
                TEMP[listBox1.SelectedIndex] = name;
                listBox1.Items.Clear();
                for (int i = 0; i < TEMP.Count; i++)
                    listBox1.Items.Add(TEMP[i]);
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteTimeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Time time = MassivTime[listBox1.SelectedIndex];
                time -= (int)MinutesAdd.Value;
                string name = time.GetTime();
                MassivTime[listBox1.SelectedIndex] = time;
                TEMP[listBox1.SelectedIndex] = name;
                listBox1.Items.Clear();
                for (int i = 0; i < TEMP.Count; i++)
                    listBox1.Items.Add(TEMP[i]);
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
        }
    }
}
