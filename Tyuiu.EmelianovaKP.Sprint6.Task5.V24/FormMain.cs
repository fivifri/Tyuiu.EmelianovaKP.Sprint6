using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.EmelianovaKP.Sprint6.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.EmelianovaKP.Sprint6.Task5.V24
{
    public partial class FormMain_EKP : Form
    {
        public FormMain_EKP()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V24.txt";

        private void buttonHelp_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_EKP_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonDo_EKP_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonOpen_EKP_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpen_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDo_EKP_Click(object sender, EventArgs e)
        {
            dataGridViewNums_EKP.ColumnCount = 2;
            dataGridViewNums_EKP.Columns[0].Width = 50;
            dataGridViewNums_EKP.Columns[1].Width = 50;

            this.chartDiag_EKP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_EKP.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; ++i)
            {
                dataGridViewNums_EKP.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiag_EKP.Series[0].Points.AddXY(i, nums[i]);
            }

        }

        private void buttonOpen_EKP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void FormMain_EKP_Load(object sender, EventArgs e)
        {

        }
    }
}
