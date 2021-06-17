
namespace games.GameEcuation
{
    partial class GameEquationForm
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
            this.components = new System.ComponentModel.Container();
            this.level1_10 = new System.Windows.Forms.Button();
            this.level10_100 = new System.Windows.Forms.Button();
            this.lavel1_100 = new System.Windows.Forms.Button();
            this.level100_1000 = new System.Windows.Forms.Button();
            this.level1_1000 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.CheckBox();
            this.viewStatistics = new System.Windows.Forms.Button();
            this.goback = new System.Windows.Forms.Button();
            this.parametrs = new System.Windows.Forms.RichTextBox();
            this.ansverTextBox = new System.Windows.Forms.RichTextBox();
            this.genEquation = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.multipTrueFalse = new System.Windows.Forms.CheckBox();
            this.satatistic = new System.Windows.Forms.RichTextBox();
            this.labelTrueFalse = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // level1_10
            // 
            this.level1_10.Location = new System.Drawing.Point(84, 77);
            this.level1_10.Name = "level1_10";
            this.level1_10.Size = new System.Drawing.Size(75, 23);
            this.level1_10.TabIndex = 0;
            this.level1_10.Text = "1-10";
            this.level1_10.UseVisualStyleBackColor = true;
            this.level1_10.Click += new System.EventHandler(this.level1_10_Click);
            // 
            // level10_100
            // 
            this.level10_100.Location = new System.Drawing.Point(208, 77);
            this.level10_100.Name = "level10_100";
            this.level10_100.Size = new System.Drawing.Size(75, 23);
            this.level10_100.TabIndex = 1;
            this.level10_100.Text = "10-100";
            this.level10_100.UseVisualStyleBackColor = true;
            this.level10_100.Click += new System.EventHandler(this.level10_100_Click);
            // 
            // lavel1_100
            // 
            this.lavel1_100.Location = new System.Drawing.Point(339, 77);
            this.lavel1_100.Name = "lavel1_100";
            this.lavel1_100.Size = new System.Drawing.Size(75, 23);
            this.lavel1_100.TabIndex = 2;
            this.lavel1_100.Text = "1-100";
            this.lavel1_100.UseVisualStyleBackColor = true;
            this.lavel1_100.Click += new System.EventHandler(this.lavel1_100_Click);
            // 
            // level100_1000
            // 
            this.level100_1000.Location = new System.Drawing.Point(474, 77);
            this.level100_1000.Name = "level100_1000";
            this.level100_1000.Size = new System.Drawing.Size(75, 23);
            this.level100_1000.TabIndex = 3;
            this.level100_1000.Text = "100-1000";
            this.level100_1000.UseVisualStyleBackColor = true;
            this.level100_1000.Click += new System.EventHandler(this.level100_1000_Click);
            // 
            // level1_1000
            // 
            this.level1_1000.Location = new System.Drawing.Point(603, 77);
            this.level1_1000.Name = "level1_1000";
            this.level1_1000.Size = new System.Drawing.Size(75, 23);
            this.level1_1000.TabIndex = 4;
            this.level1_1000.Text = "1-1000";
            this.level1_1000.UseVisualStyleBackColor = true;
            this.level1_1000.Click += new System.EventHandler(this.level1_1000_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(427, 170);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(111, 17);
            this.time.TabIndex = 6;
            this.time.Text = "Добавить время";
            this.time.UseVisualStyleBackColor = true;
            this.time.CheckedChanged += new System.EventHandler(this.time_CheckedChanged);
            // 
            // viewStatistics
            // 
            this.viewStatistics.Location = new System.Drawing.Point(586, 12);
            this.viewStatistics.Name = "viewStatistics";
            this.viewStatistics.Size = new System.Drawing.Size(75, 23);
            this.viewStatistics.TabIndex = 7;
            this.viewStatistics.Text = "Статистика";
            this.viewStatistics.UseVisualStyleBackColor = true;
            this.viewStatistics.Click += new System.EventHandler(this.viewStatistics_Click);
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(686, 12);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(75, 23);
            this.goback.TabIndex = 8;
            this.goback.Text = "Вернуться";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // parametrs
            // 
            this.parametrs.Enabled = false;
            this.parametrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parametrs.Location = new System.Drawing.Point(92, 68);
            this.parametrs.Name = "parametrs";
            this.parametrs.Size = new System.Drawing.Size(365, 96);
            this.parametrs.TabIndex = 9;
            this.parametrs.Text = "";
            this.parametrs.TextChanged += new System.EventHandler(this.parametrs_TextChanged);
            // 
            // ansverTextBox
            // 
            this.ansverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansverTextBox.Location = new System.Drawing.Point(509, 68);
            this.ansverTextBox.Name = "ansverTextBox";
            this.ansverTextBox.Size = new System.Drawing.Size(152, 96);
            this.ansverTextBox.TabIndex = 10;
            this.ansverTextBox.Text = "";
            this.ansverTextBox.TextChanged += new System.EventHandler(this.ansverTextBox_TextChanged);
            // 
            // genEquation
            // 
            this.genEquation.Location = new System.Drawing.Point(120, 223);
            this.genEquation.Name = "genEquation";
            this.genEquation.Size = new System.Drawing.Size(75, 23);
            this.genEquation.TabIndex = 11;
            this.genEquation.Text = "Задать";
            this.genEquation.UseVisualStyleBackColor = true;
            this.genEquation.Click += new System.EventHandler(this.genEquation_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(537, 223);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 12;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // multipTrueFalse
            // 
            this.multipTrueFalse.AutoSize = true;
            this.multipTrueFalse.Location = new System.Drawing.Point(84, 170);
            this.multipTrueFalse.Name = "multipTrueFalse";
            this.multipTrueFalse.Size = new System.Drawing.Size(183, 17);
            this.multipTrueFalse.TabIndex = 5;
            this.multipTrueFalse.Text = "Добавить умножение и часное";
            this.multipTrueFalse.UseVisualStyleBackColor = true;
            this.multipTrueFalse.CheckedChanged += new System.EventHandler(this.multipTrueFalse_CheckedChanged);
            // 
            // satatistic
            // 
            this.satatistic.Enabled = false;
            this.satatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.satatistic.Location = new System.Drawing.Point(33, 38);
            this.satatistic.Name = "satatistic";
            this.satatistic.Size = new System.Drawing.Size(718, 208);
            this.satatistic.TabIndex = 13;
            this.satatistic.Text = "";
            // 
            // labelTrueFalse
            // 
            this.labelTrueFalse.AutoSize = true;
            this.labelTrueFalse.Location = new System.Drawing.Point(336, 228);
            this.labelTrueFalse.Name = "labelTrueFalse";
            this.labelTrueFalse.Size = new System.Drawing.Size(35, 13);
            this.labelTrueFalse.TabIndex = 14;
            this.labelTrueFalse.Text = "label1";
            this.labelTrueFalse.Click += new System.EventHandler(this.labelTrueFalse_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(427, 194);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GameEquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.satatistic);
            this.Controls.Add(this.labelTrueFalse);
            this.Controls.Add(this.check);
            this.Controls.Add(this.genEquation);
            this.Controls.Add(this.ansverTextBox);
            this.Controls.Add(this.parametrs);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.viewStatistics);
            this.Controls.Add(this.time);
            this.Controls.Add(this.multipTrueFalse);
            this.Controls.Add(this.level1_1000);
            this.Controls.Add(this.level100_1000);
            this.Controls.Add(this.lavel1_100);
            this.Controls.Add(this.level10_100);
            this.Controls.Add(this.level1_10);
            this.Name = "GameEquationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Примерчки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameEquationForm_FormClosing);
            this.Load += new System.EventHandler(this.GameEquationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button level1_10;
        private System.Windows.Forms.Button level10_100;
        private System.Windows.Forms.Button lavel1_100;
        private System.Windows.Forms.Button level100_1000;
        private System.Windows.Forms.Button level1_1000;
        private System.Windows.Forms.CheckBox time;
        private System.Windows.Forms.Button viewStatistics;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.RichTextBox parametrs;
        private System.Windows.Forms.Button genEquation;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.CheckBox multipTrueFalse;
        private System.Windows.Forms.RichTextBox satatistic;
        protected System.Windows.Forms.Label labelTrueFalse;
        protected System.Windows.Forms.RichTextBox ansverTextBox;
        protected System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}