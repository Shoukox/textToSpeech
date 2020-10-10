namespace textToSpeech
{
    partial class Main
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Speak = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label.Location = new System.Drawing.Point(7, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(283, 46);
            this.label.TabIndex = 1;
            this.label.Text = "Text to speech";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 87);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(270, 246);
            this.textBox.TabIndex = 2;
            // 
            // Speak
            // 
            this.Speak.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Speak.Location = new System.Drawing.Point(202, 339);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(88, 29);
            this.Speak.TabIndex = 3;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBox.Location = new System.Drawing.Point(20, 344);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(159, 23);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "Сохранять в файл?";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 380);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

