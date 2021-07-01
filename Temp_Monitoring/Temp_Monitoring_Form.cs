using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp_Monitoring
{
    public partial class Temp_Monitoring_Form : Form
    {
        public Temp_Monitoring_Form()
        {
            InitializeComponent();
        }

        private void lbTemp_Click(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void tbTimeMin_TextChanged(object sender, EventArgs e)
        {}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void dgvGrafik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {}

        private void tbMin_TextChanged(object sender, EventArgs e)
        {}

        private void GrafikFish()
        {
            int norma;
            DateTime time;
            int maxCount = 0;
            int minCount = 0;
            try
            {
                time = Convert.ToDateTime(mtbDate.Text);
            }
            catch 
            {
                MessageBox.Show("Введите верный формат времени");
            }
            time = Convert.ToDateTime(mtbDate.Text);
            try
            {
                string ss = tbTemp.Text;
                string[] Temp = ss.Split(',' , '.' , ';', ' ');
                int[] numbers = new int[Temp.Length];
                for (int i = 0; i < Temp.Length; i++)
                {
                    numbers[i] = Int32.Parse(Temp[i]);
                }
                for (int i = 0; i < Temp.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        norma = Convert.ToInt32(tbMin.Text);
                    }
                    else
                    {
                        norma = Convert.ToInt32(tbMax.Text);
                    }
                    
                    time = time.AddMinutes(10);
                    dgvGrafik.Rows.Add();
                    dgvGrafik[0, i].Value = time;
                    dgvGrafik[1, i].Value = numbers[i];
                    dgvGrafik[2, i].Value = norma;
                    dgvGrafik[3, i].Value = numbers[i] - norma;
                    /*int count = Convert.ToInt32(dgvGrafik[3, i].Value);
                    if (numbers[i] > 0 && count > 0 && count <= Convert.ToInt32(tbMax))
                    {
                        maxCount += 1;
                    }
                    if (numbers[i] < 0 && count < 0 && count >= Convert.ToInt32(tbMin))
                    {
                        minCount += 1;
                    }*/

                }
            }
            catch
            {
                MessageBox.Show("Подставьте верные значения в строку температура");
                MessageBox.Show("Пример Ввода 0,0,0,0,0");
            }
        }

        private void btGraf_Click(object sender, EventArgs e)
        {
            GrafikFish();
        }
    }
}
