
namespace Tyuiu.EmelianovaKP.Sprint6.Task2.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_EKP = new System.Windows.Forms.GroupBox();
            this.labelStopValue_EKP = new System.Windows.Forms.Label();
            this.labelStartValue_EKP = new System.Windows.Forms.Label();
            this.textBoxStopValue_EKP = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_EKP = new System.Windows.Forms.TextBox();
            this.buttonReference_EKP = new System.Windows.Forms.Button();
            this.buttonExecute_EKP = new System.Windows.Forms.Button();
            this.groupBoxOutputData_EKP = new System.Windows.Forms.GroupBox();
            this.chartFunction_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_EKP = new System.Windows.Forms.DataGridView();
            this.labelResult_EKP = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_EKP.SuspendLayout();
            this.groupBoxInputData_EKP.SuspendLayout();
            this.groupBoxOutputData_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EKP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_EKP.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(18, 18);
            this.groupBoxTask_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(527, 372);
            this.groupBoxTask_EKP.TabIndex = 1;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие";
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxTask_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EKP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTask_EKP.Location = new System.Drawing.Point(15, 31);
            this.textBoxTask_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(502, 331);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.TabStop = false;
            this.textBoxTask_EKP.Text = "Протабулировать функцию\r\n\r\n2x - 4 + (2x - 1) / (sin(x) + 1" +
    ")\r\n\r\nна заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            this.textBoxTask_EKP.TextChanged += new System.EventHandler(this.textBoxTask_EKP_TextChanged);
            // 
            // groupBoxInputData_EKP
            // 
            this.groupBoxInputData_EKP.Controls.Add(this.labelStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.labelStartValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStartValue_EKP);
            this.groupBoxInputData_EKP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_EKP.ForeColor = System.Drawing.Color.Black;
            this.groupBoxInputData_EKP.Location = new System.Drawing.Point(18, 400);
            this.groupBoxInputData_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInputData_EKP.Name = "groupBoxInputData_EKP";
            this.groupBoxInputData_EKP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInputData_EKP.Size = new System.Drawing.Size(390, 126);
            this.groupBoxInputData_EKP.TabIndex = 2;
            this.groupBoxInputData_EKP.TabStop = false;
            this.groupBoxInputData_EKP.Text = "Ввод данных";
            // 
            // labelStopValue_EKP
            // 
            this.labelStopValue_EKP.AutoSize = true;
            this.labelStopValue_EKP.Location = new System.Drawing.Point(205, 34);
            this.labelStopValue_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopValue_EKP.Name = "labelStopValue_EKP";
            this.labelStopValue_EKP.Size = new System.Drawing.Size(96, 23);
            this.labelStopValue_EKP.TabIndex = 3;
            this.labelStopValue_EKP.Text = "Конец шага:";
            this.labelStopValue_EKP.Click += new System.EventHandler(this.labelStopValue_EKP_Click);
            // 
            // labelStartValue_EKP
            // 
            this.labelStartValue_EKP.AutoSize = true;
            this.labelStartValue_EKP.Location = new System.Drawing.Point(8, 34);
            this.labelStartValue_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartValue_EKP.Name = "labelStartValue_EKP";
            this.labelStartValue_EKP.Size = new System.Drawing.Size(104, 23);
            this.labelStartValue_EKP.TabIndex = 2;
            this.labelStartValue_EKP.Text = "Старт шага:";
            this.labelStartValue_EKP.Click += new System.EventHandler(this.labelStartValue_EKP_Click);
            // 
            // textBoxStopValue_EKP
            // 
            this.textBoxStopValue_EKP.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxStopValue_EKP.Location = new System.Drawing.Point(209, 80);
            this.textBoxStopValue_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStopValue_EKP.Name = "textBoxStopValue_EKP";
            this.textBoxStopValue_EKP.Size = new System.Drawing.Size(158, 30);
            this.textBoxStopValue_EKP.TabIndex = 1;
            this.textBoxStopValue_EKP.TabStop = false;
            this.textBoxStopValue_EKP.Text = "5";
            this.textBoxStopValue_EKP.TextChanged += new System.EventHandler(this.textBoxStopValue_EKP_TextChanged);
            // 
            // textBoxStartValue_EKP
            // 
            this.textBoxStartValue_EKP.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxStartValue_EKP.Location = new System.Drawing.Point(8, 80);
            this.textBoxStartValue_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStartValue_EKP.Name = "textBoxStartValue_EKP";
            this.textBoxStartValue_EKP.Size = new System.Drawing.Size(158, 30);
            this.textBoxStartValue_EKP.TabIndex = 0;
            this.textBoxStartValue_EKP.TabStop = false;
            this.textBoxStartValue_EKP.Text = "-5";
            // 
            // buttonReference_EKP
            // 
            this.buttonReference_EKP.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReference_EKP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference_EKP.ForeColor = System.Drawing.Color.Black;
            this.buttonReference_EKP.Location = new System.Drawing.Point(420, 431);
            this.buttonReference_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReference_EKP.Name = "buttonReference_EKP";
            this.buttonReference_EKP.Size = new System.Drawing.Size(112, 95);
            this.buttonReference_EKP.TabIndex = 4;
            this.buttonReference_EKP.TabStop = false;
            this.buttonReference_EKP.Text = "Справка";
            this.buttonReference_EKP.UseVisualStyleBackColor = false;
            this.buttonReference_EKP.Click += new System.EventHandler(this.buttonReference_EKP_Click);
            // 
            // buttonExecute_EKP
            // 
            this.buttonExecute_EKP.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonExecute_EKP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecute_EKP.ForeColor = System.Drawing.Color.Black;
            this.buttonExecute_EKP.Location = new System.Drawing.Point(540, 431);
            this.buttonExecute_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExecute_EKP.Name = "buttonExecute_EKP";
            this.buttonExecute_EKP.Size = new System.Drawing.Size(162, 95);
            this.buttonExecute_EKP.TabIndex = 5;
            this.buttonExecute_EKP.TabStop = false;
            this.buttonExecute_EKP.Text = "Выполнить";
            this.buttonExecute_EKP.UseVisualStyleBackColor = false;
            this.buttonExecute_EKP.Click += new System.EventHandler(this.buttonExecute_EKP_Click);
            this.buttonExecute_EKP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExecute_EKP_MouseDown);
            this.buttonExecute_EKP.MouseEnter += new System.EventHandler(this.buttonExecute_EKP_MouseEnter);
            this.buttonExecute_EKP.MouseLeave += new System.EventHandler(this.buttonExecute_EKP_MouseLeave);
            // 
            // groupBoxOutputData_EKP
            // 
            this.groupBoxOutputData_EKP.Controls.Add(this.chartFunction_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.dataGridViewFunction_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.labelResult_EKP);
            this.groupBoxOutputData_EKP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_EKP.ForeColor = System.Drawing.Color.Black;
            this.groupBoxOutputData_EKP.Location = new System.Drawing.Point(710, 18);
            this.groupBoxOutputData_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOutputData_EKP.Name = "groupBoxOutputData_EKP";
            this.groupBoxOutputData_EKP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOutputData_EKP.Size = new System.Drawing.Size(861, 508);
            this.groupBoxOutputData_EKP.TabIndex = 6;
            this.groupBoxOutputData_EKP.TabStop = false;
            this.groupBoxOutputData_EKP.Text = "Вывод данных";
            // 
            // chartFunction_EKP
            // 
            this.chartFunction_EKP.BackColor = System.Drawing.Color.Orchid;
            chartArea3.Name = "ChartArea1";
            this.chartFunction_EKP.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_EKP.Legends.Add(legend3);
            this.chartFunction_EKP.Location = new System.Drawing.Point(251, 97);
            this.chartFunction_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartFunction_EKP.Name = "chartFunction_EKP";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_EKP.Series.Add(series3);
            this.chartFunction_EKP.Size = new System.Drawing.Size(602, 401);
            this.chartFunction_EKP.TabIndex = 3;
            this.chartFunction_EKP.Text = "chart1";
            // 
            // dataGridViewFunction_EKP
            // 
            this.dataGridViewFunction_EKP.BackgroundColor = System.Drawing.Color.Orchid;
            this.dataGridViewFunction_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_EKP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_EKP.Location = new System.Drawing.Point(8, 97);
            this.dataGridViewFunction_EKP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewFunction_EKP.Name = "dataGridViewFunction_EKP";
            this.dataGridViewFunction_EKP.RowHeadersVisible = false;
            this.dataGridViewFunction_EKP.Size = new System.Drawing.Size(235, 401);
            this.dataGridViewFunction_EKP.TabIndex = 2;
            this.dataGridViewFunction_EKP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_EKP_CellContentClick);
            // 
            // labelResult_EKP
            // 
            this.labelResult_EKP.AutoSize = true;
            this.labelResult_EKP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_EKP.Location = new System.Drawing.Point(10, 31);
            this.labelResult_EKP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult_EKP.Name = "labelResult_EKP";
            this.labelResult_EKP.Size = new System.Drawing.Size(93, 23);
            this.labelResult_EKP.TabIndex = 1;
            this.labelResult_EKP.Text = "Результат:";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 70;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1584, 540);
            this.Controls.Add(this.groupBoxOutputData_EKP);
            this.Controls.Add(this.buttonExecute_EKP);
            this.Controls.Add(this.buttonReference_EKP);
            this.Controls.Add(this.groupBoxInputData_EKP);
            this.Controls.Add(this.groupBoxTask_EKP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Емельянова К. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            this.groupBoxInputData_EKP.ResumeLayout(false);
            this.groupBoxInputData_EKP.PerformLayout();
            this.groupBoxOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EKP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
        private System.Windows.Forms.GroupBox groupBoxInputData_EKP;
        private System.Windows.Forms.Label labelStopValue_EKP;
        private System.Windows.Forms.Label labelStartValue_EKP;
        private System.Windows.Forms.TextBox textBoxStopValue_EKP;
        private System.Windows.Forms.TextBox textBoxStartValue_EKP;
        private System.Windows.Forms.Button buttonReference_EKP;
        private System.Windows.Forms.Button buttonExecute_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputData_EKP;
        private System.Windows.Forms.Label labelResult_EKP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_EKP;
        private System.Windows.Forms.DataGridView dataGridViewFunction_EKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

