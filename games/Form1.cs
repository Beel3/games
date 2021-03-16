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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Words_Click(object sender, EventArgs e)
        {
            GameWords gameWords = new GameWords();
            gameWords.Visible = true;
        }
    }
}
