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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TextEditorProject
{
    public partial class Form1 : Form
    {
        string RememberFileName;

        public Form1()
        {
            InitializeComponent();
        }

        bool wordwrap = false;

        bool FindText = false;

        //Event handler to open a file for File DropDown Menu
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                RememberFileName = openFileDialog1.FileName;
            }

            string file_data = File.ReadAllText(s);
            richTextBox1.Text = file_data;

            openFileDialog1.Filter = "Text files | *.txt";
            richTextBox1.Text = file_data;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if remember File Name
            if (RememberFileName != null)
            {
                //This excutes if remember it
                richTextBox1.SaveFile(RememberFileName);
            } else {
                //Check to see if we don't remember File Name
                saveAsToolStripMenuItem_Click(sender, e);
            }

        }
            //Event handler to Save text
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                RememberFileName = saveFileDialog1.FileName;
            }
        }

        //Event handler for click on Edit for Edit DropDown Menu
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dlg.Font;
                string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                MessageBox.Show(fontName + "" + fontSize);
            }
        }

        //Setting Font Size for text
        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                fontToolStripMenuItem_Click(sender, e);
            }
        }

        public override System.Drawing.Font Font { get; set; }

        //Setting the options for Font Style
        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem_Click(sender, e);
        }

        //Setting the Font Color
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            //Set the intial color of the dialog to the current text color.
            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog1.Color != richTextBox1.SelectionColor)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
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

        //Event handler for Word Wrap
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordwrap == false)
            {    //'If it's checked, set word wrap
                richTextBox1.WordWrap = true;
                wordwrap = true;
            }
            else
            {    //'If not, set it to false
                richTextBox1.WordWrap = false;
                wordwrap = false;
            }
        }

        /*//Event handler for click on About for About DropDown Menu
        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.openDialog1 = new Dialog.ShowDialog.OK();
            Console.WriteLine("First Text editor that uses basic formatting features");
            Console.WriteLine("Eric Viohl");
            Console.WriteLine("Version 2.5");
            Console.WriteLine("Web Development Boot Camp");
            Console.ReadKey();
        }*/
    }
}
