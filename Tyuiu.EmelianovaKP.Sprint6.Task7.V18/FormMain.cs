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

using Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_EKP.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_EKP.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; ++r)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; ++c)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_EKP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_EKP.ShowDialog();
            openFilePath = openFileDialogTask_EKP.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_EKP.ColumnCount = columns;
            dataGridViewInput_EKP.RowCount = rows;
            dataGridViewOutput_EKP.ColumnCount = columns;
            dataGridViewOutput_EKP.RowCount = rows;

            for (int i = 0; i < columns; ++i)
            {
                dataGridViewInput_EKP.Columns[i].Width = 25;
                dataGridViewOutput_EKP.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < columns; ++c)
                {
                    dataGridViewInput_EKP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_EKP.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_EKP.ColumnCount = 50;
            dataGridViewOutput_EKP.ColumnCount = 50;

            dataGridViewInput_EKP.RowCount = 50;
            dataGridViewOutput_EKP.RowCount = 50;

            panelInputMatrix_EKP.Width = this.Width / 2;

            for (int i = 0; i < 50; ++i)
            {
                dataGridViewInput_EKP.Columns[i].Width = 25;
                dataGridViewOutput_EKP.Columns[i].Width = 25;
            }
        }

        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < columns; ++c)
                {
                    dataGridViewOutput_EKP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_EKP.Enabled = true;
        }

        private void buttonSave_EKP_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_EKP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_EKP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_EKP.ShowDialog();

            string path = saveFileDialogMatrix_EKP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if(fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_EKP.RowCount;
            int columns = dataGridViewOutput_EKP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_EKP.Rows[i].Cells[j].Value + ";";
                    } else
                    {
                        str = str + dataGridViewOutput_EKP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_EKP_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_EKP.ToolTipTitle = "Выполнить";
        }

        private void buttonOpenFile_EKP_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_EKP.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_EKP_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_EKP.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_EKP_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_EKP.ToolTipTitle = "Справка";
        }

        private void buttonInfo_EKP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
