using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.GameEcuation
{
    public partial class GameEquationForm : Form
    {
        protected GameEquationLogic gameEquation;        
        protected bool stateStatistic = false;
        protected bool withTimer = false;
        protected bool haveAnsver = false;
        public GameEquationForm()
        {
            InitializeComponent();
            choisingForm(true);
            satatistic.Visible = false;
            labelTrueFalse.Visible = false;
            numericUpDown1.Visible = false;
        }

        private void level1_10_Click(object sender, EventArgs e)
        {
            correctCreateLogic(1,10, false);
        }        

        private void level10_100_Click(object sender, EventArgs e)
        {
            correctCreateLogic(10, 100, false);
        }

        private void lavel1_100_Click(object sender, EventArgs e)
        {
            correctCreateLogic(1, 100, false);
        }

        private void level100_1000_Click(object sender, EventArgs e)
        {
            correctCreateLogic(100, 1000, false);
        }

        private void level1_1000_Click(object sender, EventArgs e)
        {
            correctCreateLogic(1, 1000, false);            
        }

        protected void multipTrueFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void time_CheckedChanged(object sender, EventArgs e) 
        {
            if (withTimer)
                withTimer = false;
            else
            {
                withTimer = true;
                numericUpDown1.Visible = true;
            }            
        }

        protected void viewStatistics_Click(object sender, EventArgs e)
        {
            if (!stateStatistic)
            {
                satatistic.Visible = true;
                stateStatistic = true;
                satatistic.Text = gameEquation.GetDataInSaver();
                satatistic.BringToFront();
            }
            else
            {
                satatistic.Visible = false;
                stateStatistic = false;
            }
        }

        protected void goback_Click(object sender, EventArgs e)
        {
            this.GameEquationForm_FormClosing(sender, null);
            this.Dispose();
        }

        protected void genEquation_Click(object sender, EventArgs e)
        {
            if (!haveAnsver)
            {
                parametrs.Text = gameEquation.GetGameObject();
                labelTrueFalse.Visible = false;
                ansverTextBox.Text = "";
                haveAnsver = true;
                if (withTimer)
                    timer1.Start();
            }
        }

        protected void check_Click(object sender, EventArgs e)
        {            
            if (gameEquation.WordIsRight(ansverTextBox.Text) && ansverTextBox.Text != "")
            {
                labelTrueFalse.Text = "Верный ответ";                
            }
            else
            {
                labelTrueFalse.Text = "Не верный ответ";
            }
            labelTrueFalse.Visible = true;
            haveAnsver = false;
            if (withTimer)
                timer1.Stop();
        }

        protected void parametrs_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ansverTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GameEquationForm_Load(object sender, EventArgs e)
        {

        }

        protected void GameEquationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameEquation.SaveData();
            MainForm.myMainForm.Visible = true;
        }

        protected void choisingForm(bool val)
        {
            level1_10.Visible = val;
            level10_100.Visible = val;
            level100_1000.Visible = val;
            level1_1000.Visible = val;
            lavel1_100.Visible = val;
            time.Visible = val;
            multipTrueFalse.Visible = val;

            viewStatistics.Visible = !val;
            goback.Visible = !val;
            genEquation.Visible = !val;
            check.Visible = !val;
            parametrs.Visible = !val;
            ansverTextBox.Visible = !val;
        }

        protected void genGameObj()
        {
            gameEquation.GetGameObject();
        }

        protected void labelTrueFalse_Click(object sender, EventArgs e)
        {

        }

        protected void correctCreateLogic(int ref1, int ref2, bool choisingFormVal)
        {
            choisingForm(choisingFormVal);
            if (withTimer)
            {
                gameEquation = new GameEquationWithTimer(ref1, ref2, multipTrueFalse.Checked);
                timer1.Enabled = true;
                if (numericUpDown1.Value != 0)
                    timer1.Interval = Convert.ToInt32(numericUpDown1.Value * 1000);
                else
                    timer1.Interval = 1000;
                numericUpDown1.Visible = false;
            }
            else
                gameEquation = new GameEquationLogic(ref1, ref2, multipTrueFalse.Checked);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            MessageBox.Show(((GameEquationWithTimer)gameEquation).TimeIsOver());            
            this.GameEquationForm_FormClosing(sender, null);
            this.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}