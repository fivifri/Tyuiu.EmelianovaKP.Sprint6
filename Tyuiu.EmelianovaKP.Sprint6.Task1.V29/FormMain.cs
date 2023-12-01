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

        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep_EKP.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_EKP.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_EKP.Text = "";
                textBoxResult_EKP.AppendText("+-------------------------+" + Environment.NewLine);
                textBoxResult_EKP.AppendText("|    X     |     f(x)     |" + Environment.NewLine);
                textBoxResult_EKP.AppendText("+-------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
		    str = String.Format("|{0,5:d}      |  {1,6:f2}  |", startstep, valueArray[i]);
		    if (valueArray[i] > -10 && valueArray[i] < 10) {
		        str = String.Format("|{0,5:d}      |  {1,7:f2}  |", startstep, valueArray[i]);
		    }              
                    textBoxResult_EKP.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_EKP.AppendText("+-------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
