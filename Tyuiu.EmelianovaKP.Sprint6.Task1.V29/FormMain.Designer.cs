
namespace Tyuiu.EmelianovaKP.Sprint6.Task1.V29
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_EKP = new System.Windows.Forms.GroupBox();
            this.labelStopValue_EKP = new System.Windows.Forms.Label();
            this.labelStartValue_EKP = new System.Windows.Forms.Label();
            this.textBoxStopValue_EKP = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_EKP = new System.Windows.Forms.TextBox();
            this.buttonExecute_EKP = new System.Windows.Forms.Button();
            this.buttonReference_EKP = new System.Windows.Forms.Button();
            this.groupBoxOutputData_EKP = new System.Windows.Forms.GroupBox();
            this.labelResult_EKP = new System.Windows.Forms.Label();
            this.textBoxResult_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxTask_EKP.SuspendLayout();
            this.groupBoxInputData_EKP.SuspendLayout();
            this.groupBoxOutputData_EKP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(22, 28);
            this.groupBoxTask_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(425, 254);
            this.groupBoxTask_EKP.TabIndex = 0;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие";
            this.groupBoxTask_EKP.Enter += new System.EventHandler(this.groupBoxTask_EKP_Enter);
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EKP.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EKP.Location = new System.Drawing.Point(9, 43);
            this.textBoxTask_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(389, 187);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.TabStop = false;
            this.textBoxTask_EKP.Text = "Протабулировать функцию\r\n\r\ncos(x) / (x + 1) - cos(x) * 1.3 + 3x\r\n\r\nна заданном ди" +
    "апазоне.\r\nРезультат вывести в таблицу.";
            this.textBoxTask_EKP.TextChanged += new System.EventHandler(this.textBoxTask_EKP_TextChanged);
            // 
            // groupBoxInputData_EKP
            // 
            this.groupBoxInputData_EKP.Controls.Add(this.labelStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.labelStartValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStartValue_EKP);
            this.groupBoxInputData_EKP.Location = new System.Drawing.Point(22, 318);
            this.groupBoxInputData_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxInputData_EKP.Name = "groupBoxInputData_EKP";
            this.groupBoxInputData_EKP.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxInputData_EKP.Size = new System.Drawing.Size(361, 126);
            this.groupBoxInputData_EKP.TabIndex = 1;
            this.groupBoxInputData_EKP.TabStop = false;
            this.groupBoxInputData_EKP.Text = "Ввод данных";
            // 
            // labelStopValue_EKP
            // 
            this.labelStopValue_EKP.AutoSize = true;
            this.labelStopValue_EKP.Location = new System.Drawing.Point(223, 43);
            this.labelStopValue_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopValue_EKP.Name = "labelStopValue_EKP";
            this.labelStopValue_EKP.Size = new System.Drawing.Size(78, 19);
            this.labelStopValue_EKP.TabIndex = 3;
            this.labelStopValue_EKP.Text = "Конец шага:";
            // 
            // labelStartValue_EKP
            // 
            this.labelStartValue_EKP.AutoSize = true;
            this.labelStartValue_EKP.Location = new System.Drawing.Point(11, 43);
            this.labelStartValue_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartValue_EKP.Name = "labelStartValue_EKP";
            this.labelStartValue_EKP.Size = new System.Drawing.Size(86, 19);
            this.labelStartValue_EKP.TabIndex = 2;
            this.labelStartValue_EKP.Text = "Старт шага:";
            // 
            // textBoxStopValue_EKP
            // 
            this.textBoxStopValue_EKP.Location = new System.Drawing.Point(222, 73);
            this.textBoxStopValue_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBoxStopValue_EKP.Name = "textBoxStopValue_EKP";
            this.textBoxStopValue_EKP.Size = new System.Drawing.Size(115, 26);
            this.textBoxStopValue_EKP.TabIndex = 1;
            this.textBoxStopValue_EKP.TabStop = false;
            this.textBoxStopValue_EKP.Text = "5";
            // 
            // textBoxStartValue_EKP
            // 
            this.textBoxStartValue_EKP.Location = new System.Drawing.Point(11, 73);
            this.textBoxStartValue_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBoxStartValue_EKP.Name = "textBoxStartValue_EKP";
            this.textBoxStartValue_EKP.Size = new System.Drawing.Size(126, 26);
            this.textBoxStartValue_EKP.TabIndex = 0;
            this.textBoxStartValue_EKP.TabStop = false;
            this.textBoxStartValue_EKP.Text = "-5";
            // 
            // buttonExecute_EKP
            // 
            this.buttonExecute_EKP.BackColor = System.Drawing.Color.Violet;
            this.buttonExecute_EKP.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute_EKP.Location = new System.Drawing.Point(529, 331);
            this.buttonExecute_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.buttonExecute_EKP.Name = "buttonExecute_EKP";
            this.buttonExecute_EKP.Size = new System.Drawing.Size(152, 113);
            this.buttonExecute_EKP.TabIndex = 2;
            this.buttonExecute_EKP.TabStop = false;
            this.buttonExecute_EKP.Text = "Выполнить";
            this.buttonExecute_EKP.UseVisualStyleBackColor = false;
            this.buttonExecute_EKP.Click += new System.EventHandler(this.buttonExecute_EKP_Click);
            // 
            // buttonReference_EKP
            // 
            this.buttonReference_EKP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReference_EKP.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference_EKP.Location = new System.Drawing.Point(409, 331);
            this.buttonReference_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.buttonReference_EKP.Name = "buttonReference_EKP";
            this.buttonReference_EKP.Size = new System.Drawing.Size(112, 113);
            this.buttonReference_EKP.TabIndex = 3;
            this.buttonReference_EKP.TabStop = false;
            this.buttonReference_EKP.Text = "Справка";
            this.buttonReference_EKP.UseVisualStyleBackColor = false;
            this.buttonReference_EKP.Click += new System.EventHandler(this.buttonReference_EKP_Click);
            // 
            // groupBoxOutputData_EKP
            // 
            this.groupBoxOutputData_EKP.Controls.Add(this.labelResult_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.textBoxResult_EKP);
            this.groupBoxOutputData_EKP.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_EKP.Location = new System.Drawing.Point(700, 28);
            this.groupBoxOutputData_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxOutputData_EKP.Name = "groupBoxOutputData_EKP";
            this.groupBoxOutputData_EKP.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBoxOutputData_EKP.Size = new System.Drawing.Size(281, 416);
            this.groupBoxOutputData_EKP.TabIndex = 4;
            this.groupBoxOutputData_EKP.TabStop = false;
            this.groupBoxOutputData_EKP.Text = "Вывод данных";
            // 
            // labelResult_EKP
            // 
            this.labelResult_EKP.AutoSize = true;
            this.labelResult_EKP.Location = new System.Drawing.Point(11, 43);
            this.labelResult_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult_EKP.Name = "labelResult_EKP";
            this.labelResult_EKP.Size = new System.Drawing.Size(79, 19);
            this.labelResult_EKP.TabIndex = 1;
            this.labelResult_EKP.Text = "Результат:";
            // 
            // textBoxResult_EKP
            // 
            this.textBoxResult_EKP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_EKP.Location = new System.Drawing.Point(12, 90);
            this.textBoxResult_EKP.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBoxResult_EKP.Multiline = true;
            this.textBoxResult_EKP.Name = "textBoxResult_EKP";
            this.textBoxResult_EKP.ReadOnly = true;
            this.textBoxResult_EKP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResult_EKP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_EKP.Size = new System.Drawing.Size(247, 315);
            this.textBoxResult_EKP.TabIndex = 0;
            this.textBoxResult_EKP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 461);
            this.Controls.Add(this.groupBoxOutputData_EKP);
            this.Controls.Add(this.buttonReference_EKP);
            this.Controls.Add(this.buttonExecute_EKP);
            this.Controls.Add(this.groupBoxInputData_EKP);
            this.Controls.Add(this.groupBoxTask_EKP);
            this.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Емельянова К. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            this.groupBoxInputData_EKP.ResumeLayout(false);
            this.groupBoxInputData_EKP.PerformLayout();
            this.groupBoxOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.GroupBox groupBoxInputData_EKP;
        private System.Windows.Forms.Button buttonExecute_EKP;
        private System.Windows.Forms.Button buttonReference_EKP;
        private System.Windows.Forms.Label labelStopValue_EKP;
        private System.Windows.Forms.Label labelStartValue_EKP;
        private System.Windows.Forms.TextBox textBoxStopValue_EKP;
        private System.Windows.Forms.TextBox textBoxStartValue_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputData_EKP;
        private System.Windows.Forms.Label labelResult_EKP;
        private System.Windows.Forms.TextBox textBoxResult_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
    }
}

