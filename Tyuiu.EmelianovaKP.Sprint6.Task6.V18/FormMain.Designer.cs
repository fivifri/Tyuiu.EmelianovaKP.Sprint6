
namespace Tyuiu.EmelianovaKP.Sprint6.Task6.V18
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
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_EKP = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_EKP = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.buttonHelp_EKP = new System.Windows.Forms.Button();
            this.buttonOpen_EKP = new System.Windows.Forms.Button();
            this.panelButtons_EKP = new System.Windows.Forms.Panel();
            this.panelTask_EKP = new System.Windows.Forms.Panel();
            this.panelInput_EKP = new System.Windows.Forms.Panel();
            this.groupBoxInput_EKP = new System.Windows.Forms.GroupBox();
            this.textBoxIn_EKP = new System.Windows.Forms.TextBox();
            this.panelOutput_EKP = new System.Windows.Forms.Panel();
            this.groupBoxOut_EKP = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxOut_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxTask_EKP.SuspendLayout();
            this.panelButtons_EKP.SuspendLayout();
            this.panelTask_EKP.SuspendLayout();
            this.panelInput_EKP.SuspendLayout();
            this.groupBoxInput_EKP.SuspendLayout();
            this.panelOutput_EKP.SuspendLayout();
            this.groupBoxOut_EKP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(990, 110);
            this.groupBoxTask_EKP.TabIndex = 1;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие";
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.BackColor = System.Drawing.Color.Azure;
            this.textBoxTask_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_EKP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EKP.Location = new System.Drawing.Point(2, 16);
            this.textBoxTask_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(986, 92);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.Text = resources.GetString("textBoxTask_EKP.Text");
            // 
            // openFileDialogTask_EKP
            // 
            this.openFileDialogTask_EKP.FileName = "openFileDialog1";
            // 
            // toolTip_EKP
            // 
            this.toolTip_EKP.ToolTipTitle = "Подсказка";
            // 
            // buttonDone_EKP
            // 
            this.buttonDone_EKP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDone_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_EKP.Enabled = false;
            this.buttonDone_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Properties.Resources.application_go;
            this.buttonDone_EKP.Location = new System.Drawing.Point(82, 3);
            this.buttonDone_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_EKP.Name = "buttonDone_EKP";
            this.buttonDone_EKP.Size = new System.Drawing.Size(78, 60);
            this.buttonDone_EKP.TabIndex = 3;
            this.toolTip_EKP.SetToolTip(this.buttonDone_EKP, "Производит поиск в файле вхождений символов \"n\"\r\nВыводит через пробел слова, в ко" +
        "торых данный символ нашелся");
            this.buttonDone_EKP.UseVisualStyleBackColor = false;
            this.buttonDone_EKP.Click += new System.EventHandler(this.buttonDone_EKP_Click);
            // 
            // buttonHelp_EKP
            // 
            this.buttonHelp_EKP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EKP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHelp_EKP.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHelp_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Properties.Resources.help;
            this.buttonHelp_EKP.Location = new System.Drawing.Point(914, 3);
            this.buttonHelp_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_EKP.Name = "buttonHelp_EKP";
            this.buttonHelp_EKP.Size = new System.Drawing.Size(73, 60);
            this.buttonHelp_EKP.TabIndex = 2;
            this.buttonHelp_EKP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_EKP.SetToolTip(this.buttonHelp_EKP, "Сведения о программе");
            this.buttonHelp_EKP.UseVisualStyleBackColor = false;
            this.buttonHelp_EKP.Click += new System.EventHandler(this.buttonHelp_EKP_Click);
            // 
            // buttonOpen_EKP
            // 
            this.buttonOpen_EKP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpen_EKP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Properties.Resources.folder_page;
            this.buttonOpen_EKP.Location = new System.Drawing.Point(2, 3);
            this.buttonOpen_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_EKP.Name = "buttonOpen_EKP";
            this.buttonOpen_EKP.Size = new System.Drawing.Size(76, 60);
            this.buttonOpen_EKP.TabIndex = 4;
            this.toolTip_EKP.SetToolTip(this.buttonOpen_EKP, "Открыть файл\r\nВыберите файл для обработки\r\n");
            this.buttonOpen_EKP.UseVisualStyleBackColor = false;
            this.buttonOpen_EKP.Click += new System.EventHandler(this.buttonOpen_EKP_Click);
            // 
            // panelButtons_EKP
            // 
            this.panelButtons_EKP.BackColor = System.Drawing.Color.LightCyan;
            this.panelButtons_EKP.Controls.Add(this.buttonDone_EKP);
            this.panelButtons_EKP.Controls.Add(this.buttonHelp_EKP);
            this.panelButtons_EKP.Controls.Add(this.buttonOpen_EKP);
            this.panelButtons_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_EKP.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons_EKP.Name = "panelButtons_EKP";
            this.panelButtons_EKP.Size = new System.Drawing.Size(990, 67);
            this.panelButtons_EKP.TabIndex = 5;
            // 
            // panelTask_EKP
            // 
            this.panelTask_EKP.BackColor = System.Drawing.Color.LightCyan;
            this.panelTask_EKP.Controls.Add(this.groupBoxTask_EKP);
            this.panelTask_EKP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_EKP.Location = new System.Drawing.Point(0, 67);
            this.panelTask_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.panelTask_EKP.Name = "panelTask_EKP";
            this.panelTask_EKP.Size = new System.Drawing.Size(990, 110);
            this.panelTask_EKP.TabIndex = 6;
            // 
            // panelInput_EKP
            // 
            this.panelInput_EKP.BackColor = System.Drawing.Color.LightCyan;
            this.panelInput_EKP.Controls.Add(this.groupBoxInput_EKP);
            this.panelInput_EKP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInput_EKP.Location = new System.Drawing.Point(0, 177);
            this.panelInput_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.panelInput_EKP.Name = "panelInput_EKP";
            this.panelInput_EKP.Size = new System.Drawing.Size(417, 372);
            this.panelInput_EKP.TabIndex = 7;
            // 
            // groupBoxInput_EKP
            // 
            this.groupBoxInput_EKP.Controls.Add(this.textBoxIn_EKP);
            this.groupBoxInput_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_EKP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_EKP.Name = "groupBoxInput_EKP";
            this.groupBoxInput_EKP.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_EKP.Size = new System.Drawing.Size(417, 372);
            this.groupBoxInput_EKP.TabIndex = 0;
            this.groupBoxInput_EKP.TabStop = false;
            this.groupBoxInput_EKP.Text = "Ввод:";
            // 
            // textBoxIn_EKP
            // 
            this.textBoxIn_EKP.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxIn_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_EKP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn_EKP.Location = new System.Drawing.Point(2, 16);
            this.textBoxIn_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIn_EKP.Multiline = true;
            this.textBoxIn_EKP.Name = "textBoxIn_EKP";
            this.textBoxIn_EKP.ReadOnly = true;
            this.textBoxIn_EKP.Size = new System.Drawing.Size(413, 354);
            this.textBoxIn_EKP.TabIndex = 0;
            this.textBoxIn_EKP.TextChanged += new System.EventHandler(this.textBoxIn_EKP_TextChanged);
            // 
            // panelOutput_EKP
            // 
            this.panelOutput_EKP.BackColor = System.Drawing.Color.LightCyan;
            this.panelOutput_EKP.Controls.Add(this.groupBoxOut_EKP);
            this.panelOutput_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput_EKP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutput_EKP.Location = new System.Drawing.Point(417, 177);
            this.panelOutput_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.panelOutput_EKP.Name = "panelOutput_EKP";
            this.panelOutput_EKP.Size = new System.Drawing.Size(573, 372);
            this.panelOutput_EKP.TabIndex = 8;
            // 
            // groupBoxOut_EKP
            // 
            this.groupBoxOut_EKP.Controls.Add(this.splitter1);
            this.groupBoxOut_EKP.Controls.Add(this.textBoxOut_EKP);
            this.groupBoxOut_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_EKP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOut_EKP.Name = "groupBoxOut_EKP";
            this.groupBoxOut_EKP.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOut_EKP.Size = new System.Drawing.Size(573, 372);
            this.groupBoxOut_EKP.TabIndex = 0;
            this.groupBoxOut_EKP.TabStop = false;
            this.groupBoxOut_EKP.Text = "Вывод";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(2, 16);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 354);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // textBoxOut_EKP
            // 
            this.textBoxOut_EKP.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxOut_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_EKP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut_EKP.Location = new System.Drawing.Point(2, 16);
            this.textBoxOut_EKP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOut_EKP.Multiline = true;
            this.textBoxOut_EKP.Name = "textBoxOut_EKP";
            this.textBoxOut_EKP.ReadOnly = true;
            this.textBoxOut_EKP.Size = new System.Drawing.Size(569, 354);
            this.textBoxOut_EKP.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 549);
            this.Controls.Add(this.panelOutput_EKP);
            this.Controls.Add(this.panelInput_EKP);
            this.Controls.Add(this.panelTask_EKP);
            this.Controls.Add(this.panelButtons_EKP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(904, 506);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Емельянова К. П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            this.panelButtons_EKP.ResumeLayout(false);
            this.panelTask_EKP.ResumeLayout(false);
            this.panelInput_EKP.ResumeLayout(false);
            this.groupBoxInput_EKP.ResumeLayout(false);
            this.groupBoxInput_EKP.PerformLayout();
            this.panelOutput_EKP.ResumeLayout(false);
            this.groupBoxOut_EKP.ResumeLayout(false);
            this.groupBoxOut_EKP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
        private System.Windows.Forms.Button buttonHelp_EKP;
        private System.Windows.Forms.Button buttonDone_EKP;
        private System.Windows.Forms.Button buttonOpen_EKP;
        private System.Windows.Forms.ToolTip toolTip_EKP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EKP;
        private System.Windows.Forms.Panel panelButtons_EKP;
        private System.Windows.Forms.Panel panelTask_EKP;
        private System.Windows.Forms.Panel panelInput_EKP;
        private System.Windows.Forms.GroupBox groupBoxInput_EKP;
        private System.Windows.Forms.TextBox textBoxIn_EKP;
        private System.Windows.Forms.Panel panelOutput_EKP;
        private System.Windows.Forms.GroupBox groupBoxOut_EKP;
        private System.Windows.Forms.TextBox textBoxOut_EKP;
        private System.Windows.Forms.Splitter splitter1;
    }
}

