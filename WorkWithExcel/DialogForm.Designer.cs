namespace WorkWithExcel
{
    partial class DialogForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainUtilBTN = new System.Windows.Forms.Button();
            this.CalculationBTN = new System.Windows.Forms.Button();
            this.ResultBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MainUtilBTN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с файлом \"Пример\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalculationBTN);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с файлом расчета мощности генератора";
            // 
            // MainUtilBTN
            // 
            this.MainUtilBTN.Location = new System.Drawing.Point(119, 71);
            this.MainUtilBTN.Name = "MainUtilBTN";
            this.MainUtilBTN.Size = new System.Drawing.Size(75, 23);
            this.MainUtilBTN.TabIndex = 2;
            this.MainUtilBTN.Text = "Приступить";
            this.MainUtilBTN.UseVisualStyleBackColor = true;
            this.MainUtilBTN.Click += new System.EventHandler(this.MainUtilBTN_Click);
            // 
            // CalculationBTN
            // 
            this.CalculationBTN.Location = new System.Drawing.Point(119, 71);
            this.CalculationBTN.Name = "CalculationBTN";
            this.CalculationBTN.Size = new System.Drawing.Size(75, 23);
            this.CalculationBTN.TabIndex = 3;
            this.CalculationBTN.Text = "Приступить";
            this.CalculationBTN.UseVisualStyleBackColor = true;
            this.CalculationBTN.Click += new System.EventHandler(this.CalculationBTN_Click);
            // 
            // ResultBTN
            // 
            this.ResultBTN.Location = new System.Drawing.Point(217, 135);
            this.ResultBTN.Name = "ResultBTN";
            this.ResultBTN.Size = new System.Drawing.Size(210, 23);
            this.ResultBTN.TabIndex = 2;
            this.ResultBTN.Text = "Сгенерировать конечный Excel файл";
            this.ResultBTN.UseVisualStyleBackColor = true;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 170);
            this.Controls.Add(this.ResultBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DialogForm";
            this.Text = "Прототип интерфейса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MainUtilBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CalculationBTN;
        private System.Windows.Forms.Button ResultBTN;
    }
}