using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.EmelianovaKP.Sprint6.Task0.V6.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task0.V6
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResultCaclulation_EKP_Click(object sender, EventArgs e)
        {
            textBoxResult_EKP.Text = service.Calculate(3).ToString();
        }

        private void buttonHelp_EKP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб-23-1 Емельянова К. П.", "Сообщение");
        }
    }
}
