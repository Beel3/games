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
        private bool stateStatistic = false;
        
        public GameEquationForm()
        {
            InitializeComponent();
            сhoosingLevel(true);
            satatistic.Visible = false;
            labelTrueFalse.Visible = false;
        }

        private void level1_10_Click(object sender, EventArgs e)
        {
            сhoosingLevel(false);
            gameEquation = new GameEquationLogic(1,10, multipTrueFalse.Checked);
        }        

        private void level10_100_Click(object sender, EventArgs e)
        {
            сhoosingLevel(false);
            gameEquation = new GameEquationLogic(10, 100, multipTrueFalse.Checked);
        }

        private void lavel1_100_Click(object sender, EventArgs e)
        {
            сhoosingLevel(false);
            gameEquation = new GameEquationLogic(1, 100, multipTrueFalse.Checked);
        }

        private void level100_1000_Click(object sender, EventArgs e)
        {
            сhoosingLevel(false);
            gameEquation = new GameEquationLogic(100, 1000, multipTrueFalse.Checked);
        }

        private void level1_1000_Click(object sender, EventArgs e)
        {
            сhoosingLevel(false);
            gameEquation = new GameEquationLogic(1, 1000, multipTrueFalse.Checked);
        }

        private void multipTrueFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void time_CheckedChanged(object sender, EventArgs e) 
        {

        }

        private void viewStatistics_Click(object sender, EventArgs e)
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

        private void goback_Click(object sender, EventArgs e)
        {
            this.GameEquationForm_FormClosing(sender, null);
            this.Dispose();
        }

        private void genEquation_Click(object sender, EventArgs e)
        {
            parametrs.Text = gameEquation.GetGameObject();
            labelTrueFalse.Visible = false;
            ansverTextBox.Text = "";
        }

        private void check_Click(object sender, EventArgs e)
        {            
            if (gameEquation.WordIsRight(ansverTextBox.Text))
            {
                labelTrueFalse.Text = "Верный ответ";                
            }
            else
            {
                labelTrueFalse.Text = "Не верный ответ";
            }
            labelTrueFalse.Visible = true;
        }

        private void parametrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ansverTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void satatistic_TextChanged(object sender, EventArgs e)
        {
            satatistic.Visible = true;
            
        }

        private void GameEquationForm_Load(object sender, EventArgs e)
        {

        }

        private void GameEquationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameEquation.SaveData();
            MainForm.myMainForm.Visible = true;
        }

        private void сhoosingLevel(bool val)
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

        private void genGameObj()
        {
            gameEquation.GetGameObject();
        }

        private void labelTrueFalse_Click(object sender, EventArgs e)
        {

        }
    }
}
