
namespace Tyuiu.EmelianovaKP.Sprint6.Task5.V24
{
    partial class FormMain_EKP
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
            this.panelHat_EKP = new System.Windows.Forms.Panel();
            this.buttonHelp_EKP = new System.Windows.Forms.Button();
            this.buttonOpen_EKP = new System.Windows.Forms.Button();
            this.buttonDo_EKP = new System.Windows.Forms.Button();
            this.groupBoxCondition_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_EKP = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_EKP = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCenter_EKP = new System.Windows.Forms.Panel();
            this.chartDiag_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHat_EKP.SuspendLayout();
            this.groupBoxCondition_EKP.SuspendLayout();
            this.groupBoxOutput_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_EKP)).BeginInit();
            this.panelCenter_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHat_EKP
            // 
            this.panelHat_EKP.BackColor = System.Drawing.Color.Azure;
            this.panelHat_EKP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHat_EKP.Controls.Add(this.buttonHelp_EKP);
            this.panelHat_EKP.Controls.Add(this.buttonOpen_EKP);
            this.panelHat_EKP.Controls.Add(this.buttonDo_EKP);
            this.panelHat_EKP.Controls.Add(this.groupBoxCondition_EKP);
            this.panelHat_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHat_EKP.Location = new System.Drawing.Point(0, 0);
            this.panelHat_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHat_EKP.Name = "panelHat_EKP";
            this.panelHat_EKP.Size = new System.Drawing.Size(900, 100);
            this.panelHat_EKP.TabIndex = 1;
            // 
            // buttonHelp_EKP
            // 
            this.buttonHelp_EKP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EKP.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonHelp_EKP.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_EKP.Location = new System.Drawing.Point(769, 10);
            this.buttonHelp_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_EKP.Name = "buttonHelp_EKP";
            this.buttonHelp_EKP.Size = new System.Drawing.Size(112, 84);
            this.buttonHelp_EKP.TabIndex = 4;
            this.buttonHelp_EKP.Text = "Справка";
            this.buttonHelp_EKP.UseVisualStyleBackColor = false;
            this.buttonHelp_EKP.Click += new System.EventHandler(this.buttonHelp_EKP_Click);
            this.buttonHelp_EKP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_EKP_MouseMove);
            // 
            // buttonOpen_EKP
            // 
            this.buttonOpen_EKP.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonOpen_EKP.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_EKP.Location = new System.Drawing.Point(653, 10);
            this.buttonOpen_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpen_EKP.Name = "buttonOpen_EKP";
            this.buttonOpen_EKP.Size = new System.Drawing.Size(112, 84);
            this.buttonOpen_EKP.TabIndex = 3;
            this.buttonOpen_EKP.Text = "Открыть Файл";
            this.buttonOpen_EKP.UseVisualStyleBackColor = false;
            this.buttonOpen_EKP.Click += new System.EventHandler(this.buttonOpen_EKP_Click);
            this.buttonOpen_EKP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpen_EKP_MouseMove);
            // 
            // buttonDo_EKP
            // 
            this.buttonDo_EKP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDo_EKP.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDo_EKP.Location = new System.Drawing.Point(537, 10);
            this.buttonDo_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDo_EKP.Name = "buttonDo_EKP";
            this.buttonDo_EKP.Size = new System.Drawing.Size(112, 84);
            this.buttonDo_EKP.TabIndex = 1;
            this.buttonDo_EKP.Text = "Выполнить";
            this.buttonDo_EKP.UseVisualStyleBackColor = false;
            this.buttonDo_EKP.Click += new System.EventHandler(this.buttonDo_EKP_Click);
            this.buttonDo_EKP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDo_EKP_MouseMove);
            // 
            // groupBoxCondition_EKP
            // 
            this.groupBoxCondition_EKP.Controls.Add(this.textBoxCondition_EKP);
            this.groupBoxCondition_EKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCondition_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_EKP.Location = new System.Drawing.Point(9, 2);
            this.groupBoxCondition_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_EKP.Name = "groupBoxCondition_EKP";
            this.groupBoxCondition_EKP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_EKP.Size = new System.Drawing.Size(524, 92);
            this.groupBoxCondition_EKP.TabIndex = 1;
            this.groupBoxCondition_EKP.TabStop = false;
            this.groupBoxCondition_EKP.Text = "Условие:";
            // 
            // textBoxCondition_EKP
            // 
            this.textBoxCondition_EKP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCondition_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_EKP.Location = new System.Drawing.Point(5, 22);
            this.textBoxCondition_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCondition_EKP.Multiline = true;
            this.textBoxCondition_EKP.Name = "textBoxCondition_EKP";
            this.textBoxCondition_EKP.ReadOnly = true;
            this.textBoxCondition_EKP.Size = new System.Drawing.Size(507, 55);
            this.textBoxCondition_EKP.TabIndex = 0;
            this.textBoxCondition_EKP.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести все элементы, равные 0. " +
    "Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutput_EKP
            // 
            this.groupBoxOutput_EKP.BackColor = System.Drawing.Color.Azure;
            this.groupBoxOutput_EKP.Controls.Add(this.dataGridViewNums_EKP);
            this.groupBoxOutput_EKP.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutput_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_EKP.Location = new System.Drawing.Point(0, 100);
            this.groupBoxOutput_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutput_EKP.Name = "groupBoxOutput_EKP";
            this.groupBoxOutput_EKP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutput_EKP.Size = new System.Drawing.Size(188, 436);
            this.groupBoxOutput_EKP.TabIndex = 2;
            this.groupBoxOutput_EKP.TabStop = false;
            this.groupBoxOutput_EKP.Text = "Вывод:";
            // 
            // dataGridViewNums_EKP
            // 
            this.dataGridViewNums_EKP.AllowUserToAddRows = false;
            this.dataGridViewNums_EKP.AllowUserToDeleteRows = false;
            this.dataGridViewNums_EKP.AllowUserToResizeColumns = false;
            this.dataGridViewNums_EKP.AllowUserToResizeRows = false;
            this.dataGridViewNums_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_EKP.Location = new System.Drawing.Point(2, 18);
            this.dataGridViewNums_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewNums_EKP.Name = "dataGridViewNums_EKP";
            this.dataGridViewNums_EKP.ReadOnly = true;
            this.dataGridViewNums_EKP.RowHeadersVisible = false;
            this.dataGridViewNums_EKP.RowHeadersWidth = 51;
            this.dataGridViewNums_EKP.RowTemplate.Height = 24;
            this.dataGridViewNums_EKP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_EKP.Size = new System.Drawing.Size(184, 416);
            this.dataGridViewNums_EKP.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Azure;
            this.splitter1.Location = new System.Drawing.Point(188, 100);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 436);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelCenter_EKP
            // 
            this.panelCenter_EKP.BackColor = System.Drawing.Color.Azure;
            this.panelCenter_EKP.Controls.Add(this.chartDiag_EKP);
            this.panelCenter_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter_EKP.Location = new System.Drawing.Point(190, 100);
            this.panelCenter_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCenter_EKP.Name = "panelCenter_EKP";
            this.panelCenter_EKP.Size = new System.Drawing.Size(710, 436);
            this.panelCenter_EKP.TabIndex = 5;
            // 
            // chartDiag_EKP
            // 
            this.chartDiag_EKP.BackColor = System.Drawing.Color.Azure;
            chartArea1.Name = "ChartArea1";
            this.chartDiag_EKP.ChartAreas.Add(chartArea1);
            this.chartDiag_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_EKP.Legends.Add(legend1);
            this.chartDiag_EKP.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDiag_EKP.Name = "chartDiag_EKP";
            this.chartDiag_EKP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_EKP.Series.Add(series1);
            this.chartDiag_EKP.Size = new System.Drawing.Size(710, 436);
            this.chartDiag_EKP.TabIndex = 0;
            this.chartDiag_EKP.Text = "chart1";
            // 
            // FormMain_EKP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(900, 536);
            this.Controls.Add(this.panelCenter_EKP);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBoxOutput_EKP);
            this.Controls.Add(this.panelHat_EKP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(860, 519);
            this.Name = "FormMain_EKP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 24 | Емельянова К. П.";
            this.Load += new System.EventHandler(this.FormMain_EKP_Load);
            this.panelHat_EKP.ResumeLayout(false);
            this.groupBoxCondition_EKP.ResumeLayout(false);
            this.groupBoxCondition_EKP.PerformLayout();
            this.groupBoxOutput_EKP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_EKP)).EndInit();
            this.panelCenter_EKP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHat_EKP;
        private System.Windows.Forms.Button buttonHelp_EKP;
        private System.Windows.Forms.Button buttonOpen_EKP;
        private System.Windows.Forms.Button buttonDo_EKP;
        private System.Windows.Forms.GroupBox groupBoxCondition_EKP;
        private System.Windows.Forms.TextBox textBoxCondition_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutput_EKP;
        private System.Windows.Forms.DataGridView dataGridViewNums_EKP;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelCenter_EKP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_EKP;
    }
}

