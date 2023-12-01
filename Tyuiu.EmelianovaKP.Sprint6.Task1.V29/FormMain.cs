using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.EmelianovaKP.Sprint6.Task1.V29.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonExecute_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_EKP.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_EKP.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_EKP.Text = "";
                textBoxResult_EKP.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_EKP.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_EKP.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_EKP.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_EKP.AppendText("+----------+----------+" + Environment.NewLine);
            } catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxTask_EKP_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_EKP_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
