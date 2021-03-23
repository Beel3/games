
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
            // GameWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.TrueAndFalse);
            this.Controls.Add(this.genWord);
            this.Controls.Add(this.check);
            this.Name = "GameWords";
            this.Text = "GameWords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWords_FormClosing);
            this.Shown += new System.EventHandler(this.GameWords_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button genWord;
        private System.Windows.Forms.Label TrueAndFalse;
    }
}