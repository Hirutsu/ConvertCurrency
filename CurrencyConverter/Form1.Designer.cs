namespace CurrencyConverter
{
    partial class Form1
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
            this.inputTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromCB = new System.Windows.Forms.ComboBox();
            this.ToCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(56, 10);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(156, 20);
            this.inputTB.TabIndex = 0;
            this.inputTB.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма";
            // 
            // fromCB
            // 
            this.fromCB.FormattingEnabled = true;
            this.fromCB.Items.AddRange(new object[] {
            "Dollar",
            "Euro",
            "Rub"});
            this.fromCB.Location = new System.Drawing.Point(56, 36);
            this.fromCB.Name = "fromCB";
            this.fromCB.Size = new System.Drawing.Size(156, 21);
            this.fromCB.TabIndex = 2;
            // 
            // ToCB
            // 
            this.ToCB.FormattingEnabled = true;
            this.ToCB.Items.AddRange(new object[] {
            "Dollar",
            "Euro",
            "Rub"});
            this.ToCB.Location = new System.Drawing.Point(56, 63);
            this.ToCB.Name = "ToCB";
            this.ToCB.Size = new System.Drawing.Size(156, 21);
            this.ToCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ИЗ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "В";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ИТОГО";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(56, 93);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(156, 20);
            this.resultTB.TabIndex = 7;
            this.resultTB.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToCB);
            this.Controls.Add(this.fromCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTB);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fromCB;
        private System.Windows.Forms.ComboBox ToCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Button button1;
    }
}

