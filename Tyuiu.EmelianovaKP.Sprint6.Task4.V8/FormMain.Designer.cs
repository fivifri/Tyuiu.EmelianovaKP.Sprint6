
namespace Tyuiu.EmelianovaKP.Sprint6.Task4.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTaskAndButtons_EKP = new System.Windows.Forms.Panel();
            this.buttonInfo_EKP = new System.Windows.Forms.Button();
            this.buttonSave_EKP = new System.Windows.Forms.Button();
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.groupBoxInputData_EKP = new System.Windows.Forms.GroupBox();
            this.labelStopValue_EKP = new System.Windows.Forms.Label();
            this.labelStartValue_EKP = new System.Windows.Forms.Label();
            this.textBoxStopValue_EKP = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.panelOutputData_EKP = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxOutputData_EKP = new System.Windows.Forms.TextBox();
            this.panelGraphsTask_EKP = new System.Windows.Forms.Panel();
            this.chartResult_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterBetwennOutputAndGraphs_EKP = new System.Windows.Forms.Splitter();
            this.pictureBoxTask_EKP = new System.Windows.Forms.PictureBox();
            this.panelTaskAndButtons_EKP.SuspendLayout();
            this.groupBoxInputData_EKP.SuspendLayout();
            this.groupBoxTask_EKP.SuspendLayout();
            this.panelOutputData_EKP.SuspendLayout();
            this.groupBoxOutputData_EKP.SuspendLayout();
            this.panelGraphsTask_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_EKP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskAndButtons_EKP
            // 
            this.panelTaskAndButtons_EKP.BackColor = System.Drawing.Color.LightBlue;
            this.panelTaskAndButtons_EKP.Controls.Add(this.buttonInfo_EKP);
            this.panelTaskAndButtons_EKP.Controls.Add(this.buttonSave_EKP);
            this.panelTaskAndButtons_EKP.Controls.Add(this.buttonDone_EKP);
            this.panelTaskAndButtons_EKP.Controls.Add(this.groupBoxInputData_EKP);
            this.panelTaskAndButtons_EKP.Controls.Add(this.groupBoxTask_EKP);
            this.panelTaskAndButtons_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskAndButtons_EKP.Location = new System.Drawing.Point(0, 0);
            this.panelTaskAndButtons_EKP.Name = "panelTaskAndButtons_EKP";
            this.panelTaskAndButtons_EKP.Size = new System.Drawing.Size(1052, 128);
            this.panelTaskAndButtons_EKP.TabIndex = 0;
            // 
            // buttonInfo_EKP
            // 
            this.buttonInfo_EKP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_EKP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInfo_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_EKP.Location = new System.Drawing.Point(941, 4);
            this.buttonInfo_EKP.Name = "buttonInfo_EKP";
            this.buttonInfo_EKP.Size = new System.Drawing.Size(108, 66);
            this.buttonInfo_EKP.TabIndex = 4;
            this.buttonInfo_EKP.TabStop = false;
            this.buttonInfo_EKP.Text = "Справка";
            this.buttonInfo_EKP.UseVisualStyleBackColor = false;
            this.buttonInfo_EKP.Click += new System.EventHandler(this.buttonInfo_EKP_Click);
            // 
            // buttonSave_EKP
            // 
            this.buttonSave_EKP.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonSave_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_EKP.Location = new System.Drawing.Point(826, 4);
            this.buttonSave_EKP.Name = "buttonSave_EKP";
            this.buttonSave_EKP.Size = new System.Drawing.Size(109, 66);
            this.buttonSave_EKP.TabIndex = 3;
            this.buttonSave_EKP.TabStop = false;
            this.buttonSave_EKP.Text = "Сохранить";
            this.buttonSave_EKP.UseVisualStyleBackColor = false;
            this.buttonSave_EKP.Click += new System.EventHandler(this.buttonSave_EKP_Click);
            // 
            // buttonDone_EKP
            // 
            this.buttonDone_EKP.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonDone_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_EKP.Location = new System.Drawing.Point(713, 4);
            this.buttonDone_EKP.Name = "buttonDone_EKP";
            this.buttonDone_EKP.Size = new System.Drawing.Size(107, 66);
            this.buttonDone_EKP.TabIndex = 2;
            this.buttonDone_EKP.TabStop = false;
            this.buttonDone_EKP.Text = "Выполнить";
            this.buttonDone_EKP.UseVisualStyleBackColor = false;
            this.buttonDone_EKP.Click += new System.EventHandler(this.buttonDone_EKP_Click);
            // 
            // groupBoxInputData_EKP
            // 
            this.groupBoxInputData_EKP.Controls.Add(this.labelStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.labelStartValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStopValue_EKP);
            this.groupBoxInputData_EKP.Controls.Add(this.textBoxStartValue_EKP);
            this.groupBoxInputData_EKP.Location = new System.Drawing.Point(485, 4);
            this.groupBoxInputData_EKP.Name = "groupBoxInputData_EKP";
            this.groupBoxInputData_EKP.Size = new System.Drawing.Size(222, 66);
            this.groupBoxInputData_EKP.TabIndex = 1;
            this.groupBoxInputData_EKP.TabStop = false;
            this.groupBoxInputData_EKP.Text = "Ввод данных:";
            // 
            // labelStopValue_EKP
            // 
            this.labelStopValue_EKP.AutoSize = true;
            this.labelStopValue_EKP.Location = new System.Drawing.Point(114, 21);
            this.labelStopValue_EKP.Name = "labelStopValue_EKP";
            this.labelStopValue_EKP.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_EKP.TabIndex = 3;
            this.labelStopValue_EKP.Text = "Конец шага:";
            // 
            // labelStartValue_EKP
            // 
            this.labelStartValue_EKP.AutoSize = true;
            this.labelStartValue_EKP.Location = new System.Drawing.Point(7, 21);
            this.labelStartValue_EKP.Name = "labelStartValue_EKP";
            this.labelStartValue_EKP.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_EKP.TabIndex = 2;
            this.labelStartValue_EKP.Text = "Старт шага:";
            // 
            // textBoxStopValue_EKP
            // 
            this.textBoxStopValue_EKP.Location = new System.Drawing.Point(114, 40);
            this.textBoxStopValue_EKP.Name = "textBoxStopValue_EKP";
            this.textBoxStopValue_EKP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_EKP.TabIndex = 1;
            this.textBoxStopValue_EKP.TabStop = false;
            this.textBoxStopValue_EKP.Text = "5";
            // 
            // textBoxStartValue_EKP
            // 
            this.textBoxStartValue_EKP.Location = new System.Drawing.Point(7, 40);
            this.textBoxStartValue_EKP.Name = "textBoxStartValue_EKP";
            this.textBoxStartValue_EKP.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_EKP.TabIndex = 0;
            this.textBoxStartValue_EKP.TabStop = false;
            this.textBoxStartValue_EKP.Text = "-5";
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.Controls.Add(this.pictureBoxTask_EKP);
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(475, 120);
            this.groupBoxTask_EKP.TabIndex = 0;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие:";
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTask_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EKP.Location = new System.Drawing.Point(8, 16);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(461, 50);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.TabStop = false;
            this.textBoxTask_EKP.Text = "Произвести табулирование f(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывест" +
    "и в textBox, построить график функции и сохранить в файл OutPutFileTask4V8.txt п" +
    "о нажатию кнопки.";
            this.textBoxTask_EKP.TextChanged += new System.EventHandler(this.textBoxTask_EKP_TextChanged);
            // 
            // panelOutputData_EKP
            // 
            this.panelOutputData_EKP.BackColor = System.Drawing.Color.LightBlue;
            this.panelOutputData_EKP.Controls.Add(this.groupBoxOutputData_EKP);
            this.panelOutputData_EKP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutputData_EKP.Location = new System.Drawing.Point(0, 128);
            this.panelOutputData_EKP.Name = "panelOutputData_EKP";
            this.panelOutputData_EKP.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutputData_EKP.Size = new System.Drawing.Size(200, 466);
            this.panelOutputData_EKP.TabIndex = 1;
            // 
            // groupBoxOutputData_EKP
            // 
            this.groupBoxOutputData_EKP.Controls.Add(this.textBoxOutputData_EKP);
            this.groupBoxOutputData_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_EKP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutputData_EKP.Name = "groupBoxOutputData_EKP";
            this.groupBoxOutputData_EKP.Size = new System.Drawing.Size(190, 456);
            this.groupBoxOutputData_EKP.TabIndex = 0;
            this.groupBoxOutputData_EKP.TabStop = false;
            this.groupBoxOutputData_EKP.Text = "Вывод данных:";
            // 
            // textBoxOutputData_EKP
            // 
            this.textBoxOutputData_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputData_EKP.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutputData_EKP.Multiline = true;
            this.textBoxOutputData_EKP.Name = "textBoxOutputData_EKP";
            this.textBoxOutputData_EKP.ReadOnly = true;
            this.textBoxOutputData_EKP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputData_EKP.Size = new System.Drawing.Size(184, 437);
            this.textBoxOutputData_EKP.TabIndex = 0;
            this.textBoxOutputData_EKP.TabStop = false;
            // 
            // panelGraphsTask_EKP
            // 
            this.panelGraphsTask_EKP.BackColor = System.Drawing.Color.LightBlue;
            this.panelGraphsTask_EKP.Controls.Add(this.chartResult_EKP);
            this.panelGraphsTask_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphsTask_EKP.Location = new System.Drawing.Point(200, 128);
            this.panelGraphsTask_EKP.Name = "panelGraphsTask_EKP";
            this.panelGraphsTask_EKP.Padding = new System.Windows.Forms.Padding(5);
            this.panelGraphsTask_EKP.Size = new System.Drawing.Size(852, 466);
            this.panelGraphsTask_EKP.TabIndex = 1;
            // 
            // chartResult_EKP
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_EKP.ChartAreas.Add(chartArea1);
            this.chartResult_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_EKP.Legends.Add(legend1);
            this.chartResult_EKP.Location = new System.Drawing.Point(5, 5);
            this.chartResult_EKP.Name = "chartResult_EKP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_EKP.Series.Add(series1);
            this.chartResult_EKP.Size = new System.Drawing.Size(842, 456);
            this.chartResult_EKP.TabIndex = 0;
            this.chartResult_EKP.TabStop = false;
            this.chartResult_EKP.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "TitleFunction";
            title1.Text = "График функции";
            this.chartResult_EKP.Titles.Add(title1);
            // 
            // splitterBetwennOutputAndGraphs_EKP
            // 
            this.splitterBetwennOutputAndGraphs_EKP.BackColor = System.Drawing.Color.LightBlue;
            this.splitterBetwennOutputAndGraphs_EKP.Location = new System.Drawing.Point(200, 128);
            this.splitterBetwennOutputAndGraphs_EKP.Name = "splitterBetwennOutputAndGraphs_EKP";
            this.splitterBetwennOutputAndGraphs_EKP.Size = new System.Drawing.Size(3, 466);
            this.splitterBetwennOutputAndGraphs_EKP.TabIndex = 2;
            this.splitterBetwennOutputAndGraphs_EKP.TabStop = false;
            // 
            // pictureBoxTask_EKP
            // 
            this.pictureBoxTask_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task4.V8.Properties.Resources.task4;
            this.pictureBoxTask_EKP.Location = new System.Drawing.Point(8, 76);
            this.pictureBoxTask_EKP.Name = "pictureBoxTask_EKP";
            this.pictureBoxTask_EKP.Size = new System.Drawing.Size(285, 38);
            this.pictureBoxTask_EKP.TabIndex = 1;
            this.pictureBoxTask_EKP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1052, 594);
            this.Controls.Add(this.splitterBetwennOutputAndGraphs_EKP);
            this.Controls.Add(this.panelGraphsTask_EKP);
            this.Controls.Add(this.panelOutputData_EKP);
            this.Controls.Add(this.panelTaskAndButtons_EKP);
            this.MinimumSize = new System.Drawing.Size(807, 595);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 8 | Емельянова К. П.";
            this.panelTaskAndButtons_EKP.ResumeLayout(false);
            this.groupBoxInputData_EKP.ResumeLayout(false);
            this.groupBoxInputData_EKP.PerformLayout();
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            this.panelOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.PerformLayout();
            this.panelGraphsTask_EKP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_EKP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_EKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskAndButtons_EKP;
        private System.Windows.Forms.Panel panelOutputData_EKP;
        private System.Windows.Forms.Panel panelGraphsTask_EKP;
        private System.Windows.Forms.Splitter splitterBetwennOutputAndGraphs_EKP;
        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.PictureBox pictureBoxTask_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputData_EKP;
        private System.Windows.Forms.TextBox textBoxOutputData_EKP;
        private System.Windows.Forms.Button buttonSave_EKP;
        private System.Windows.Forms.Button buttonDone_EKP;
        private System.Windows.Forms.GroupBox groupBoxInputData_EKP;
        private System.Windows.Forms.Label labelStopValue_EKP;
        private System.Windows.Forms.Label labelStartValue_EKP;
        private System.Windows.Forms.TextBox textBoxStopValue_EKP;
        private System.Windows.Forms.TextBox textBoxStartValue_EKP;
        private System.Windows.Forms.Button buttonInfo_EKP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_EKP;
    }
}

