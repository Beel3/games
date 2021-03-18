
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genWord);
            this.Controls.Add(this.check);
            this.Name = "GameWords";
            this.Text = "GameWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button genWord;
        private System.Windows.Forms.Label label1;
    }
}