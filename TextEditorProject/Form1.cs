using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditorProject
{
    public partial class Form1 : Form
    {
        //Setting OpenFileDialog as object
        private OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        //Event handler for click on File for File DropDown Menu
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = openFileDialog1.FileName;
            string file_data = File.ReadAllText(s);
            richTextBox1.Text = file_data;

            openFileDialog1.Filter = "Text files | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        /*private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.Filter = "Text Files | *.txt";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                richTextBox1.SaveFile(SaveFileDialog.FileName, richTextBox1StreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog();
        }

        //Event handler for click on Edit for Edit DropDown Menu
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) richTextBox1.Font = fontDialog1.Font;
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Event handler for click on View for View DropDown Menu
        private void windowThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Event handler for click on About for About DropDown Menu
        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/ 
    }
}
