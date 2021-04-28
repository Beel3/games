using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games
{
    public partial class GameWords : Form
    {
        private TableLayoutPanel tableLayoutPanel;
        private GameWordsLogic gameWordsLogic;
        private bool stateStatistic;
        public GameWords()
        {
            InitializeComponent();
            gameWordsLogic = new GameWordsLogic();
            richTextBox1.Visible = false;
            stateStatistic = false;
        }

        #region TableLayoutPanel 
        private void CreateTableLayoutPanel(string word)
        {
            Point point = new Point(120, 55);
            tableLayoutPanel = new TableLayoutPanel
            {
                Location= point,
                Parent = this,
                Width=700,
                AllowDrop = true,
                ColumnCount = word.Length
            };
            
            for (int i = 0; i < word.Length; i++)
            {
                var button = new Button { 
                    Parent = tableLayoutPanel,
                    Text = Convert.ToString(word[i]),
                    Width=50,
                    Height=50                    
                };
                button.MouseDown += Button_MouseDown;
                button.MouseMove += Button_MouseMove;
                button.MouseUp += Button_MouseUp;
                button.MouseClick += Button_MouseClick;
            }
            tableLayoutPanel.DragOver += TableLayoutPanel_DragOver;
            //tableLayoutPanel.Location = point;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).Tag = new object();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            if (button.Tag != null)
                button.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).Tag = null;
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            Text = ((Control)sender).Text;
                var pos = tableLayoutPanel.GetPositionFromControl(((Button)sender));
            Text += pos.ToString()+' ';
        }

        private void TableLayoutPanel_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(Button)))
                return;

            e.Effect = e.AllowedEffect;
            var draggedButton = (Button)e.Data.GetData(typeof(Button));

            var pt = tableLayoutPanel.PointToClient(new Point(e.X, e.Y));
            var button = (Button)tableLayoutPanel.GetChildAtPoint(pt);

            if (button != null)
            {
                var pos = tableLayoutPanel.GetPositionFromControl(button);
                tableLayoutPanel.Controls.Add(draggedButton, pos.Column, pos.Row);
                draggedButton.Tag = null;
            }
        }
        #endregion

        private void genWord_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel != null)
                tableLayoutPanel.Dispose();

            CreateTableLayoutPanel(gameWordsLogic.DoMixedWord());
            TrueAndFalse.Text = "";
        }

        private void chek_Click(object sender, EventArgs e)
        {
            try
            { 
                var buttons = tableLayoutPanel.Controls;                
            }
            catch
            {
                MessageBox.Show("Слово не заданно.");
                return;
            }

            Point pnt = new Point(1,0);
            Control btn;            
            string resWord = default;
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++, pnt.X++)
            {
                btn = tableLayoutPanel.GetControlFromPosition(i, 0);
                resWord += btn.Text[0];
            }
            if (gameWordsLogic.WordIsRight(resWord))
                TrueAndFalse.Text = "the word is correct";            
            else
                TrueAndFalse.Text = "the word is incorrect";
        }

        private void GameWords_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameWordsLogic.SaveData();
            MainForm.myMainForm.Visible = true;
        }

        private void GameWords_Shown(object sender, EventArgs e)
        {
            TrueAndFalse.Text = "";            
        }

        private void GameWords_Load(object sender, EventArgs e)
        {
            if (tableLayoutPanel != null)
                tableLayoutPanel.Dispose();

            CreateTableLayoutPanel(gameWordsLogic.DoMixedWord());
            TrueAndFalse.Text = "";
        }

        private void viewStatistics_Click(object sender, EventArgs e)
        {
            if (!stateStatistic)
            {
                richTextBox1.Text = gameWordsLogic.GetDataSaver();
                richTextBox1.Enabled = false;
                richTextBox1.Visible = true;
                stateStatistic = true;
            }
            else
            {
                richTextBox1.Visible = false;
                stateStatistic = false;
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.GameWords_FormClosing(sender, null);
            this.Dispose();
        }
    }
}
