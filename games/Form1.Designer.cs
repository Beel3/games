
namespace games
{
    partial class MainForm
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
            this.Words = new System.Windows.Forms.Button();
            this.examples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Words
            // 
            this.Words.Location = new System.Drawing.Point(79, 41);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(299, 167);
            this.Words.TabIndex = 0;
            this.Words.Text = "Слова";
            this.Words.UseVisualStyleBackColor = true;
            this.Words.Click += new System.EventHandler(this.Words_Click);
            // 
            // examples
            // 
            this.examples.Location = new System.Drawing.Point(428, 41);
            this.examples.Name = "examples";
            this.examples.Size = new System.Drawing.Size(297, 167);
            this.examples.TabIndex = 1;
            this.examples.Text = "Примерчики";
            this.examples.UseVisualStyleBackColor = true;
            this.examples.Click += new System.EventHandler(this.examples_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.examples);
            this.Controls.Add(this.Words);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Words;
        private System.Windows.Forms.Button examples;
    }
}

