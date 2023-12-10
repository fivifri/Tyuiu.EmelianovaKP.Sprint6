
namespace Tyuiu.EmelianovaKP.Sprint6.Task6.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_EKP = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_EKP
            // 
            this.buttonOK_EKP.Location = new System.Drawing.Point(491, 212);
            this.buttonOK_EKP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK_EKP.Name = "buttonOK_EKP";
            this.buttonOK_EKP.Size = new System.Drawing.Size(92, 34);
            this.buttonOK_EKP.TabIndex = 0;
            this.buttonOK_EKP.Text = "OK";
            this.buttonOK_EKP.UseVisualStyleBackColor = true;
            this.buttonOK_EKP.Click += new System.EventHandler(this.buttonOK_EKP_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(211, 11);
            this.LabelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(372, 187);
            this.LabelInfo.TabIndex = 1;
            this.LabelInfo.Text = resources.GetString("LabelInfo.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Properties.Resources.me;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.buttonOK_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_EKP;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}