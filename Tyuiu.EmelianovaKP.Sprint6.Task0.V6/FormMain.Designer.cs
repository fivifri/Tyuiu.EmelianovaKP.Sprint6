
namespace Tyuiu.EmelianovaKP.Sprint6.Task0.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCondition_EKP = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_EKP = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_EKP = new System.Windows.Forms.GroupBox();
            this.buttonResultCaclulation_EKP = new System.Windows.Forms.Button();
            this.textBoxResult_EKP = new System.Windows.Forms.TextBox();
            this.buttonHelp_EKP = new System.Windows.Forms.Button();
            this.labelResult_EKP = new System.Windows.Forms.Label();
            this.groupBoxCondition_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_EKP)).BeginInit();
            this.groupBoxOutputData_EKP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_EKP
            // 
            this.groupBoxCondition_EKP.Controls.Add(this.pictureBoxCondition_EKP);
            this.groupBoxCondition_EKP.Controls.Add(this.textBoxCondition_EKP);
            this.groupBoxCondition_EKP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_EKP.Name = "groupBoxCondition_EKP";
            this.groupBoxCondition_EKP.Size = new System.Drawing.Size(303, 167);
            this.groupBoxCondition_EKP.TabIndex = 1;
            this.groupBoxCondition_EKP.TabStop = false;
            this.groupBoxCondition_EKP.Text = "Условие";
            // 
            // pictureBoxCondition_EKP
            // 
            this.pictureBoxCondition_EKP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCondition_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task0.V6.Properties.Resources.Calculation;
            this.pictureBoxCondition_EKP.Location = new System.Drawing.Point(180, 19);
            this.pictureBoxCondition_EKP.Name = "pictureBoxCondition_EKP";
            this.pictureBoxCondition_EKP.Size = new System.Drawing.Size(117, 54);
            this.pictureBoxCondition_EKP.TabIndex = 0;
            this.pictureBoxCondition_EKP.TabStop = false;
            // 
            // textBoxCondition_EKP
            // 
            this.textBoxCondition_EKP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_EKP.Location = new System.Drawing.Point(17, 19);
            this.textBoxCondition_EKP.Multiline = true;
            this.textBoxCondition_EKP.Name = "textBoxCondition_EKP";
            this.textBoxCondition_EKP.Size = new System.Drawing.Size(157, 137);
            this.textBoxCondition_EKP.TabIndex = 2;
            this.textBoxCondition_EKP.ReadOnly = true;
            this.textBoxCondition_EKP.TabStop = false;
            this.textBoxCondition_EKP.Text = "Посчитать значение выражения при x = 3";
            // 
            // groupBoxOutputData_EKP
            // 
            this.groupBoxOutputData_EKP.Controls.Add(this.labelResult_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.buttonResultCaclulation_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.textBoxResult_EKP);
            this.groupBoxOutputData_EKP.Location = new System.Drawing.Point(321, 12);
            this.groupBoxOutputData_EKP.Name = "groupBoxOutputData_EKP";
            this.groupBoxOutputData_EKP.Size = new System.Drawing.Size(98, 91);
            this.groupBoxOutputData_EKP.TabIndex = 2;
            this.groupBoxOutputData_EKP.TabStop = false;
            this.groupBoxOutputData_EKP.Text = "Вывод данных";
            // 
            // buttonResultCaclulation_EKP
            // 
            this.buttonResultCaclulation_EKP.Location = new System.Drawing.Point(6, 62);
            this.buttonResultCaclulation_EKP.Name = "buttonResultCaclulation_EKP";
            this.buttonResultCaclulation_EKP.Size = new System.Drawing.Size(85, 23);
            this.buttonResultCaclulation_EKP.TabIndex = 2;
            this.buttonResultCaclulation_EKP.Text = "Выполнить";
            this.buttonResultCaclulation_EKP.UseVisualStyleBackColor = true;
            this.buttonResultCaclulation_EKP.Click += new System.EventHandler(this.buttonResultCaclulation_EKP_Click);
            this.buttonResultCaclulation_EKP.TabStop = false;
            // 
            // textBoxResult_EKP
            // 
            this.textBoxResult_EKP.Location = new System.Drawing.Point(6, 39);
            this.textBoxResult_EKP.Name = "textBoxResult_EKP";
            this.textBoxResult_EKP.ReadOnly = true;
            this.textBoxResult_EKP.Size = new System.Drawing.Size(85, 20);
            this.textBoxResult_EKP.TabIndex = 0;
            this.textBoxResult_EKP.TabStop = false;

            // 
            // buttonHelp_EKP
            // 
            this.buttonHelp_EKP.Location = new System.Drawing.Point(350, 123);
            this.buttonHelp_EKP.Name = "buttonHelp_EKP";
            this.buttonHelp_EKP.Size = new System.Drawing.Size(42, 36);
            this.buttonHelp_EKP.TabIndex = 3;
            this.buttonHelp_EKP.Text = "?";
            this.buttonHelp_EKP.UseVisualStyleBackColor = true;
            this.buttonHelp_EKP.Click += new System.EventHandler(this.buttonHelp_EKP_Click);
            this.buttonHelp_EKP.TabStop = false;
            // 
            // labelResult_EKP
            // 
            this.labelResult_EKP.AutoSize = true;
            this.labelResult_EKP.Location = new System.Drawing.Point(9, 29);
            this.labelResult_EKP.Name = "labelResult_EKP";
            this.labelResult_EKP.Size = new System.Drawing.Size(59, 13);
            this.labelResult_EKP.TabIndex = 3;
            this.labelResult_EKP.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.Controls.Add(this.buttonHelp_EKP);
            this.Controls.Add(this.groupBoxOutputData_EKP);
            this.Controls.Add(this.groupBoxCondition_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 6 | Емельянова К. П.";
            this.groupBoxCondition_EKP.ResumeLayout(false);
            this.groupBoxCondition_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_EKP)).EndInit();
            this.groupBoxOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_EKP;
        private System.Windows.Forms.PictureBox pictureBoxCondition_EKP;
        private System.Windows.Forms.TextBox textBoxCondition_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputData_EKP;
        private System.Windows.Forms.Button buttonResultCaclulation_EKP;
        private System.Windows.Forms.TextBox textBoxResult_EKP;
        private System.Windows.Forms.Button buttonHelp_EKP;
        private System.Windows.Forms.Label labelResult_EKP;
    }
}

