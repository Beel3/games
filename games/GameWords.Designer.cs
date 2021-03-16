
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
            this.right = new System.Windows.Forms.CheckBox();
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
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(398, 226);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(46, 17);
            this.right.TabIndex = 2;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GameWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.right);
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
        private System.Windows.Forms.CheckBox right;
    }
}