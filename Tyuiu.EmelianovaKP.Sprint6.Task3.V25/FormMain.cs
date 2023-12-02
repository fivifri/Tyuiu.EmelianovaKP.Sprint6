using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.EmelianovaKP.Sprint6.Task3.V25.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = {
                {  14,   5,  -9,  18,  21 },
                {  -5, -12, -12,   4,  28 },
                {  27,  -2, -14,  23,  27 },
                { -19, -15,  17,  15,   1 },
                {  33,   2,   6,  24,  24 }
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewTaskMatrix_EKP.ColumnCount = columns;
            dataGridViewTaskMatrix_EKP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskMatrix_EKP.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewTaskMatrix_EKP.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTaskMatrix_EKP.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewMatrixResult_EKP.ColumnCount = columns;
            dataGridViewMatrixResult_EKP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_EKP.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrixResult_EKP.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_EKP.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

            pictureBox4_EKP.Visible = false;
        }

        private void buttonReference_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-1 Емельянова Ксения Павловна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
