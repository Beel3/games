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
        public static MainForm myMainForm;
        public MainForm()
        {
            InitializeComponent();
            myMainForm = this;
        }

        private void Words_Click(object sender, EventArgs e)
        {
            GameWords gameWords = new GameWords();
            gameWords.Visible = true;
            myMainForm.Visible = false;
        }
    }
}
