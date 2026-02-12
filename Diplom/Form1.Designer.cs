namespace Diplom
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.WayToFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButt = new System.Windows.Forms.Button();
            this.RowAdress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WayToFile
            // 
            this.WayToFile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WayToFile.Location = new System.Drawing.Point(3, 29);
            this.WayToFile.Name = "WayToFile";
            this.WayToFile.Size = new System.Drawing.Size(180, 22);
            this.WayToFile.TabIndex = 0;
            this.WayToFile.Text = "Введите путь к файлу";
            this.WayToFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выобор спектра";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartButt
            // 
            this.StartButt.Location = new System.Drawing.Point(6, 92);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(116, 31);
            this.StartButt.TabIndex = 2;
            this.StartButt.Text = "Ввести данные";
            this.StartButt.UseVisualStyleBackColor = true;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // RowAdress
            // 
            this.RowAdress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RowAdress.Location = new System.Drawing.Point(3, 58);
            this.RowAdress.Name = "RowAdress";
            this.RowAdress.Size = new System.Drawing.Size(180, 22);
            this.RowAdress.TabIndex = 3;
            this.RowAdress.Text = "Введите номер строки";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RowAdress);
            this.Controls.Add(this.StartButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WayToFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWin";
            this.Text = "Обработка спектра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WayToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButt;
        private System.Windows.Forms.TextBox RowAdress;
    }
}

