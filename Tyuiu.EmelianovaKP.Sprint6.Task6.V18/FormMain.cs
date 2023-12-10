using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.EmelianovaKP.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            textBoxOut_EKP.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_EKP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_EKP.ShowDialog();
                openFilePath = openFileDialogTask_EKP.FileName;
                textBoxIn_EKP.Text = File.ReadAllText(openFilePath);
                groupBoxInput_EKP.Text = groupBoxInput_EKP.Text + " " + openFileDialogTask_EKP.FileName;
                buttonDone_EKP.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIn_EKP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
