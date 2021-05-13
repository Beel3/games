
namespace games
{
    partial class GameWords
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
            this.check = new System.Windows.Forms.Button();
            this.genWord = new System.Windows.Forms.Button();
            this.TrueAndFalse = new System.Windows.Forms.Label();
            this.goback = new System.Windows.Forms.Button();
            this.viewStatistics = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(560, 226);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 0;
            this.check.Text = "Проверить слово";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.chek_Click);
            // 
            // genWord
            // 
            this.genWord.Location = new System.Drawing.Point(171, 226);
            this.genWord.Name = "genWord";
            this.genWord.Size = new System.Drawing.Size(75, 23);
            this.genWord.TabIndex = 1;
            this.genWord.Text = "Задать слово";
            this.genWord.UseVisualStyleBackColor = true;
            this.genWord.Click += new System.EventHandler(this.genWord_Click);
            // 
            // TrueAndFalse
            // 
            this.TrueAndFalse.AutoSize = true;
            this.TrueAndFalse.Location = new System.Drawing.Point(387, 231);
            this.TrueAndFalse.Name = "TrueAndFalse";
            this.TrueAndFalse.Size = new System.Drawing.Size(35, 13);
            this.TrueAndFalse.TabIndex = 2;
            this.TrueAndFalse.Text = "label1";
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(697, 12);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(75, 23);
            this.goback.TabIndex = 3;
            this.goback.Text = "Вернуться";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // viewStatistics
            // 
            this.viewStatistics.Location = new System.Drawing.Point(599, 12);
            this.viewStatistics.Name = "viewStatistics";
            this.viewStatistics.Size = new System.Drawing.Size(75, 23);
            this.viewStatistics.TabIndex = 4;
            this.viewStatistics.Text = "Статистика";
            this.viewStatistics.UseVisualStyleBackColor = true;
            this.viewStatistics.Click += new System.EventHandler(this.viewStatistics_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(718, 208);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // GameWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.viewStatistics);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.TrueAndFalse);
            this.Controls.Add(this.genWord);
            this.Controls.Add(this.check);
            this.Name = "GameWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWords_FormClosing);
            this.Load += new System.EventHandler(this.GameWords_Load);
            this.Shown += new System.EventHandler(this.GameWords_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button genWord;
        private System.Windows.Forms.Label TrueAndFalse;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.Button viewStatistics;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}