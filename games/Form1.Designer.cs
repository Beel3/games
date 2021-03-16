
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
            this.boxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Words
            // 
            this.Words.Location = new System.Drawing.Point(133, 139);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(120, 105);
            this.Words.TabIndex = 0;
            this.Words.Text = "Слова";
            this.Words.UseVisualStyleBackColor = true;
            this.Words.Click += new System.EventHandler(this.Words_Click);
            // 
            // examples
            // 
            this.examples.Location = new System.Drawing.Point(317, 139);
            this.examples.Name = "examples";
            this.examples.Size = new System.Drawing.Size(120, 105);
            this.examples.TabIndex = 1;
            this.examples.Text = "Примерчики";
            this.examples.UseVisualStyleBackColor = true;
            // 
            // boxes
            // 
            this.boxes.Location = new System.Drawing.Point(491, 139);
            this.boxes.Name = "boxes";
            this.boxes.Size = new System.Drawing.Size(120, 105);
            this.boxes.TabIndex = 2;
            this.boxes.Text = "Шкатулки";
            this.boxes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxes);
            this.Controls.Add(this.examples);
            this.Controls.Add(this.Words);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Words;
        private System.Windows.Forms.Button examples;
        private System.Windows.Forms.Button boxes;
    }
}

