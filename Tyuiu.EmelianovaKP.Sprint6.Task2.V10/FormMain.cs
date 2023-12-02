using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.EmelianovaKP.Sprint6.Task2.V10.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.chartFunction_EKP.Titles.Add("График функции");

            this.chartFunction_EKP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_EKP.ChartAreas[0].AxisY.Title = "Ось Y";
        }

        DataService ds = new DataService();
        private void buttonReference_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonExecute_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartFunction_EKP.Series[0].Points.Clear();
                this.dataGridViewFunction_EKP.Rows.Clear();

                int startValue = Convert.ToInt32(textBoxStartValue_EKP.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_EKP.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                for(int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction_EKP.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_EKP.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            } catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonExecute_EKP_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute_EKP.BackColor = Color.SlateBlue;
        }

        private void buttonExecute_EKP_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute_EKP.BackColor = Color.MediumPurple;
        }

        private void buttonExecute_EKP_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExecute_EKP.BackColor = Color.DarkSlateBlue;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTask_EKP_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStartValue_EKP_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStopValue_EKP_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStopValue_EKP_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_EKP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
