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
        private GameWordsLogic GameWordsLogic;

        public GameWords()
        {
            InitializeComponent();
            GameWordsLogic = new GameWordsLogic();
        }

        #region TableLayoutPanel 
        private void CreateTableLayoutPanel(string word)
        {            
            tableLayoutPanel = new TableLayoutPanel
            {
                Parent = this,
                Dock = DockStyle.Top,
                AllowDrop = true,
                ColumnCount = word.Length                
            };
            for (int i = 0; i < word.Length; i++)
            {
                var button = new Button { Parent = tableLayoutPanel, Text = Convert.ToString(word[i]) };
                button.MouseDown += Button_MouseDown;
                button.MouseMove += Button_MouseMove;
                button.MouseUp += Button_MouseUp;
                button.MouseClick += Button_MouseClick;
            }
            tableLayoutPanel.DragOver += TableLayoutPanel_DragOver;
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

            CreateTableLayoutPanel(GameWordsLogic.DoMixedWord());
        }

        private void chek_Click(object sender, EventArgs e)
        {
            var buttons = tableLayoutPanel.Controls;
            int index = 0;
            char[] startWord = ((GameWordsLogic.GetWord()).ToArray());
            foreach (Button btn in buttons)
            {
                if ((btn.Text.ToArray())[0] != startWord[index])
                {
                    //var ParentButton = (Button)sender;
                    //ParentButton.BackColor = Color.Green;
                    right.Text = "False";
                    return;
                }                   

                ++index;
            }
            right.Text = "True";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
