
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.buttonResultCaclulation = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            this.groupBoxOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBoxCondition);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(303, 167);
            this.groupBoxCondition.TabIndex = 1;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCondition.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task0.V6.Properties.Resources.Calculation;
            this.pictureBoxCondition.Location = new System.Drawing.Point(180, 19);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(117, 54);
            this.pictureBoxCondition.TabIndex = 0;
            this.pictureBoxCondition.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition.Location = new System.Drawing.Point(17, 19);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(157, 137);
            this.textBoxCondition.TabIndex = 2;
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Text = "Посчитать значение выражения при x = 3";
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.labelResult);
            this.groupBoxOutputData.Controls.Add(this.buttonResultCaclulation);
            this.groupBoxOutputData.Controls.Add(this.textBoxResult);
            this.groupBoxOutputData.Location = new System.Drawing.Point(321, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(98, 91);
            this.groupBoxOutputData.TabIndex = 2;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // buttonResultCaclulation
            // 
            this.buttonResultCaclulation.Location = new System.Drawing.Point(6, 62);
            this.buttonResultCaclulation.Name = "buttonResultCaclulation";
            this.buttonResultCaclulation.Size = new System.Drawing.Size(85, 23);
            this.buttonResultCaclulation.TabIndex = 2;
            this.buttonResultCaclulation.Text = "Выполнить";
            this.buttonResultCaclulation.UseVisualStyleBackColor = true;
            this.buttonResultCaclulation.Click += new System.EventHandler(this.buttonResultCaclulation_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.AccessibleDescription = "";
            this.textBoxResult.Location = new System.Drawing.Point(6, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(85, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Tag = "";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(350, 123);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(42, 36);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = " ?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 29);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 0 | V6 | Emelianova K. P.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Button buttonResultCaclulation;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelResult;
    }
}

