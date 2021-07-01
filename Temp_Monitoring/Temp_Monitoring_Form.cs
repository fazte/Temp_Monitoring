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
using System.IO;

namespace Temp_Monitoring
{
    public partial class Temp_Monitoring_Form : Form
    {
        int maxCount = 0;
        int minCount = 0;


        public Temp_Monitoring_Form()
        {
            InitializeComponent();
        }
        private void lbTemp_Click(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void tbTimeMin_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void dgvGrafik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        { }

        private void tbMin_TextChanged(object sender, EventArgs e)
        { }

        private void GrafikFish()
        {
            int norma;
            DateTime time;

            try
            {
                time = Convert.ToDateTime(mtbDate.Text);
            }
            catch
            {
                MessageBox.Show("Введите верный формат времени");
            }

            try
            {
                string ss = tbTemp.Text;
                string[] Temp = ss.Split(',', '.', ';', ' ');
                int[] numbers = new int[Temp.Length];
                for (int i = 0; i < Temp.Length; i++)
                {
                    numbers[i] = Int32.Parse(Temp[i]);
                }
                time = Convert.ToDateTime(mtbDate.Text);
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
                    int count = Convert.ToInt32(dgvGrafik[3, i].Value);
                    if (numbers[i] > 0 && count > 0)
                    {
                        maxCount += 1;
                    }
                    else
                    {
                        continue;
                    }
                    if (numbers[i] < 0 && count < 0)
                    {
                        minCount += 1;
                    }
                    else
                    {
                        continue;
                    }

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
            Otchet();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgvGrafik.Rows.Clear();
            tbTemp.Clear();
            mtbDate.Clear();
            maxCount = 0;
            minCount = 0;
        }

        private void tbOtchet_TextChanged(object sender, EventArgs e)
        { }

        private void Otchet()
        {
            if ((maxCount * 10) >= 20)
            {
                tbOtchet.Text = "Порог максимально допустимой температуры превышен на" + $"{(maxCount * 10 -20) / 60} час {(maxCount * 10 - 20) % 60} минут";
                MessageBox.Show("Рыба была разморожена");
            }

            if ((minCount * 10) >= 60)
            {
                tbOtchet.Text = "Порог минимально допустимой температуры превышен на" + $"{(minCount * 10 ) / 60} час {(minCount * 10) % 60} минут";
                MessageBox.Show("Рыба была переморожена");
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTableAsCSV = new SaveFileDialog();
            saveTableAsCSV.Filter = "Документ TXT (*.txt) |*.txt";
            saveTableAsCSV.Title = "Сохранить результат расчетов";
            if (saveTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTableAsCSV.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write("отчет" + ":" + tbOtchet.Text);
                    sw.WriteLine();
                    sw.Write("Температура" + ":" + tbTemp.Text);
                    sw.WriteLine();
                    sw.Write("Дата" + ":" + mtbDate.Text);
                    sw.WriteLine();
                    sw.Close();


                }
                catch
                { }
            }
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openTableAsCSV = new OpenFileDialog();
            openTableAsCSV.Filter = "Документ TXT (*.txt) |*.txt";
            if (openTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                tbTemp.Text = File.ReadAllText(openTableAsCSV.FileName, Encoding.Default);
            }

        }
    }
}
