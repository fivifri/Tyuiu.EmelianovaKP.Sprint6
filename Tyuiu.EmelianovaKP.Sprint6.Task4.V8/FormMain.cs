using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.EmelianovaKP.Sprint6.Task4.V8.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task4.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_EKP.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_EKP.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] arrResult = new double[len];

                arrResult = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_EKP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_EKP.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutputData_EKP.Text = "";
                chartResult_EKP.Series[0].Points.Clear();

                for (int i = 0; i < len; ++i)
                {
                    this.chartResult_EKP.Series[0].Points.AddXY(startValue, arrResult[i]);
                    textBoxOutputData_EKP.AppendText(arrResult[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V8.txt";
                File.WriteAllText(path, textBoxOutputData_EKP.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxTask_EKP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
