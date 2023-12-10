
namespace Tyuiu.EmelianovaKP.Sprint6.Task7.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_EKP = new System.Windows.Forms.Panel();
            this.buttonSave_EKP = new System.Windows.Forms.Button();
            this.buttonInfo_EKP = new System.Windows.Forms.Button();
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.buttonOpenFile_EKP = new System.Windows.Forms.Button();
            this.panelTask_EKP = new System.Windows.Forms.Panel();
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.panelInputMatrix_EKP = new System.Windows.Forms.Panel();
            this.groupBoxInputMatrix_EKP = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_EKP = new System.Windows.Forms.DataGridView();
            this.splitterBetweenInputAndOutput_EKP = new System.Windows.Forms.Splitter();
            this.panelOutputMatrix_EKP = new System.Windows.Forms.Panel();
            this.groupBoxOutputMatrix_EKP = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_EKP = new System.Windows.Forms.DataGridView();
            this.toolTipHelpButtons_EKP = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_EKP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_EKP = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_EKP.SuspendLayout();
            this.panelTask_EKP.SuspendLayout();
            this.groupBoxTask_EKP.SuspendLayout();
            this.panelInputMatrix_EKP.SuspendLayout();
            this.groupBoxInputMatrix_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_EKP)).BeginInit();
            this.panelOutputMatrix_EKP.SuspendLayout();
            this.groupBoxOutputMatrix_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_EKP
            // 
            this.panelButtons_EKP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelButtons_EKP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_EKP.Controls.Add(this.buttonSave_EKP);
            this.panelButtons_EKP.Controls.Add(this.buttonInfo_EKP);
            this.panelButtons_EKP.Controls.Add(this.buttonDone_EKP);
            this.panelButtons_EKP.Controls.Add(this.buttonOpenFile_EKP);
            this.panelButtons_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_EKP.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_EKP.Name = "panelButtons_EKP";
            this.panelButtons_EKP.Size = new System.Drawing.Size(884, 66);
            this.panelButtons_EKP.TabIndex = 1;
            // 
            // buttonSave_EKP
            // 
            this.buttonSave_EKP.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonSave_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_EKP.Enabled = false;
            this.buttonSave_EKP.FlatAppearance.BorderSize = 2;
            this.buttonSave_EKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_EKP.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Properties.Resources.page_save;
            this.buttonSave_EKP.Location = new System.Drawing.Point(168, 4);
            this.buttonSave_EKP.Name = "buttonSave_EKP";
            this.buttonSave_EKP.Size = new System.Drawing.Size(75, 55);
            this.buttonSave_EKP.TabIndex = 3;
            this.buttonSave_EKP.TabStop = false;
            this.toolTipHelpButtons_EKP.SetToolTip(this.buttonSave_EKP, "Сохранить обработанные данные в файл CSV");
            this.buttonSave_EKP.UseVisualStyleBackColor = false;
            this.buttonSave_EKP.Click += new System.EventHandler(this.buttonSave_EKP_Click);
            this.buttonSave_EKP.MouseEnter += new System.EventHandler(this.buttonSave_EKP_MouseEnter);
            // 
            // buttonInfo_EKP
            // 
            this.buttonInfo_EKP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_EKP.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonInfo_EKP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_EKP.FlatAppearance.BorderSize = 2;
            this.buttonInfo_EKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_EKP.ForeColor = System.Drawing.Color.Silver;
            this.buttonInfo_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Properties.Resources.help;
            this.buttonInfo_EKP.Location = new System.Drawing.Point(804, 4);
            this.buttonInfo_EKP.Name = "buttonInfo_EKP";
            this.buttonInfo_EKP.Size = new System.Drawing.Size(75, 55);
            this.buttonInfo_EKP.TabIndex = 2;
            this.buttonInfo_EKP.TabStop = false;
            this.toolTipHelpButtons_EKP.SetToolTip(this.buttonInfo_EKP, "Сведения о программе");
            this.buttonInfo_EKP.UseVisualStyleBackColor = false;
            this.buttonInfo_EKP.Click += new System.EventHandler(this.buttonInfo_EKP_Click);
            this.buttonInfo_EKP.MouseEnter += new System.EventHandler(this.buttonInfo_EKP_MouseEnter);
            // 
            // buttonDone_EKP
            // 
            this.buttonDone_EKP.BackColor = System.Drawing.Color.Indigo;
            this.buttonDone_EKP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_EKP.Enabled = false;
            this.buttonDone_EKP.FlatAppearance.BorderSize = 2;
            this.buttonDone_EKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_EKP.ForeColor = System.Drawing.Color.Silver;
            this.buttonDone_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Properties.Resources.page_white_go;
            this.buttonDone_EKP.Location = new System.Drawing.Point(86, 4);
            this.buttonDone_EKP.Name = "buttonDone_EKP";
            this.buttonDone_EKP.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_EKP.TabIndex = 1;
            this.buttonDone_EKP.TabStop = false;
            this.toolTipHelpButtons_EKP.SetToolTip(this.buttonDone_EKP, "Выполнить обработку данных");
            this.buttonDone_EKP.UseVisualStyleBackColor = false;
            this.buttonDone_EKP.Click += new System.EventHandler(this.buttonDone_EKP_Click);
            this.buttonDone_EKP.MouseEnter += new System.EventHandler(this.buttonDone_EKP_MouseEnter);
            // 
            // buttonOpenFile_EKP
            // 
            this.buttonOpenFile_EKP.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonOpenFile_EKP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_EKP.FlatAppearance.BorderSize = 2;
            this.buttonOpenFile_EKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_EKP.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Properties.Resources.folder_page;
            this.buttonOpenFile_EKP.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_EKP.Name = "buttonOpenFile_EKP";
            this.buttonOpenFile_EKP.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_EKP.TabIndex = 0;
            this.buttonOpenFile_EKP.TabStop = false;
            this.toolTipHelpButtons_EKP.SetToolTip(this.buttonOpenFile_EKP, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_EKP.UseVisualStyleBackColor = false;
            this.buttonOpenFile_EKP.Click += new System.EventHandler(this.buttonOpenFile_EKP_Click);
            this.buttonOpenFile_EKP.MouseEnter += new System.EventHandler(this.buttonOpenFile_EKP_MouseEnter);
            // 
            // panelTask_EKP
            // 
            this.panelTask_EKP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTask_EKP.Controls.Add(this.groupBoxTask_EKP);
            this.panelTask_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_EKP.Location = new System.Drawing.Point(0, 66);
            this.panelTask_EKP.Name = "panelTask_EKP";
            this.panelTask_EKP.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_EKP.Size = new System.Drawing.Size(884, 68);
            this.panelTask_EKP.TabIndex = 2;
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(874, 58);
            this.groupBoxTask_EKP.TabIndex = 0;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие:";
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_EKP.BackColor = System.Drawing.Color.MintCream;
            this.textBoxTask_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EKP.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxTask_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EKP.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(861, 32);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.TabStop = false;
            this.textBoxTask_EKP.Text = resources.GetString("textBoxTask_EKP.Text");
            // 
            // panelInputMatrix_EKP
            // 
            this.panelInputMatrix_EKP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelInputMatrix_EKP.Controls.Add(this.groupBoxInputMatrix_EKP);
            this.panelInputMatrix_EKP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputMatrix_EKP.Location = new System.Drawing.Point(0, 134);
            this.panelInputMatrix_EKP.Name = "panelInputMatrix_EKP";
            this.panelInputMatrix_EKP.Padding = new System.Windows.Forms.Padding(2);
            this.panelInputMatrix_EKP.Size = new System.Drawing.Size(439, 377);
            this.panelInputMatrix_EKP.TabIndex = 3;
            // 
            // groupBoxInputMatrix_EKP
            // 
            this.groupBoxInputMatrix_EKP.Controls.Add(this.dataGridViewInput_EKP);
            this.groupBoxInputMatrix_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputMatrix_EKP.Location = new System.Drawing.Point(2, 2);
            this.groupBoxInputMatrix_EKP.Name = "groupBoxInputMatrix_EKP";
            this.groupBoxInputMatrix_EKP.Size = new System.Drawing.Size(435, 373);
            this.groupBoxInputMatrix_EKP.TabIndex = 0;
            this.groupBoxInputMatrix_EKP.TabStop = false;
            this.groupBoxInputMatrix_EKP.Text = "Ввод:";
            // 
            // dataGridViewInput_EKP
            // 
            this.dataGridViewInput_EKP.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewInput_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_EKP.ColumnHeadersVisible = false;
            this.dataGridViewInput_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_EKP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_EKP.Name = "dataGridViewInput_EKP";
            this.dataGridViewInput_EKP.ReadOnly = true;
            this.dataGridViewInput_EKP.RowHeadersVisible = false;
            this.dataGridViewInput_EKP.Size = new System.Drawing.Size(429, 354);
            this.dataGridViewInput_EKP.TabIndex = 0;
            this.dataGridViewInput_EKP.TabStop = false;
            // 
            // splitterBetweenInputAndOutput_EKP
            // 
            this.splitterBetweenInputAndOutput_EKP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.splitterBetweenInputAndOutput_EKP.Location = new System.Drawing.Point(439, 134);
            this.splitterBetweenInputAndOutput_EKP.Name = "splitterBetweenInputAndOutput_EKP";
            this.splitterBetweenInputAndOutput_EKP.Size = new System.Drawing.Size(3, 377);
            this.splitterBetweenInputAndOutput_EKP.TabIndex = 4;
            this.splitterBetweenInputAndOutput_EKP.TabStop = false;
            // 
            // panelOutputMatrix_EKP
            // 
            this.panelOutputMatrix_EKP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelOutputMatrix_EKP.Controls.Add(this.groupBoxOutputMatrix_EKP);
            this.panelOutputMatrix_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutputMatrix_EKP.Location = new System.Drawing.Point(442, 134);
            this.panelOutputMatrix_EKP.Name = "panelOutputMatrix_EKP";
            this.panelOutputMatrix_EKP.Padding = new System.Windows.Forms.Padding(2);
            this.panelOutputMatrix_EKP.Size = new System.Drawing.Size(442, 377);
            this.panelOutputMatrix_EKP.TabIndex = 5;
            // 
            // groupBoxOutputMatrix_EKP
            // 
            this.groupBoxOutputMatrix_EKP.Controls.Add(this.dataGridViewOutput_EKP);
            this.groupBoxOutputMatrix_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputMatrix_EKP.Location = new System.Drawing.Point(2, 2);
            this.groupBoxOutputMatrix_EKP.Name = "groupBoxOutputMatrix_EKP";
            this.groupBoxOutputMatrix_EKP.Size = new System.Drawing.Size(438, 373);
            this.groupBoxOutputMatrix_EKP.TabIndex = 0;
            this.groupBoxOutputMatrix_EKP.TabStop = false;
            this.groupBoxOutputMatrix_EKP.Text = "Вывод:";
            // 
            // dataGridViewOutput_EKP
            // 
            this.dataGridViewOutput_EKP.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewOutput_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_EKP.ColumnHeadersVisible = false;
            this.dataGridViewOutput_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_EKP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_EKP.Name = "dataGridViewOutput_EKP";
            this.dataGridViewOutput_EKP.ReadOnly = true;
            this.dataGridViewOutput_EKP.RowHeadersVisible = false;
            this.dataGridViewOutput_EKP.Size = new System.Drawing.Size(432, 354);
            this.dataGridViewOutput_EKP.TabIndex = 0;
            this.dataGridViewOutput_EKP.TabStop = false;
            // 
            // toolTipHelpButtons_EKP
            // 
            this.toolTipHelpButtons_EKP.IsBalloon = true;
            this.toolTipHelpButtons_EKP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelpButtons_EKP.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_EKP
            // 
            this.openFileDialogTask_EKP.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelOutputMatrix_EKP);
            this.Controls.Add(this.splitterBetweenInputAndOutput_EKP);
            this.Controls.Add(this.panelInputMatrix_EKP);
            this.Controls.Add(this.panelTask_EKP);
            this.Controls.Add(this.panelButtons_EKP);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Емельянова К. П.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_EKP.ResumeLayout(false);
            this.panelTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            this.panelInputMatrix_EKP.ResumeLayout(false);
            this.groupBoxInputMatrix_EKP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_EKP)).EndInit();
            this.panelOutputMatrix_EKP.ResumeLayout(false);
            this.groupBoxOutputMatrix_EKP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_EKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_EKP;
        private System.Windows.Forms.Button buttonInfo_EKP;
        private System.Windows.Forms.Button buttonDone_EKP;
        private System.Windows.Forms.Button buttonOpenFile_EKP;
        private System.Windows.Forms.Panel panelTask_EKP;
        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
        private System.Windows.Forms.Panel panelInputMatrix_EKP;
        private System.Windows.Forms.GroupBox groupBoxInputMatrix_EKP;
        private System.Windows.Forms.Splitter splitterBetweenInputAndOutput_EKP;
        private System.Windows.Forms.Panel panelOutputMatrix_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputMatrix_EKP;
        private System.Windows.Forms.DataGridView dataGridViewInput_EKP;
        private System.Windows.Forms.DataGridView dataGridViewOutput_EKP;
        private System.Windows.Forms.Button buttonSave_EKP;
        private System.Windows.Forms.ToolTip toolTipHelpButtons_EKP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EKP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_EKP;
    }
}

