using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile()
        {
            string filename = openFileDialog1.FileName;
            this.Text = filename;
            string fileText = System.IO.File.ReadAllText(filename, Encoding.Default);
            richTextBox1.Text = fileText;
        }
        private void SaveFile()
        {
            string filename;
            if (openFileDialog1.FileName != "")
            {
                filename = saveFileDialog1.FileName;
            }
            else
                filename = openFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, richTextBox1.Text, Encoding.Default);
        }

        private void SaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
            saveFileDialog1.FileName.Length > 0)
            {
                string filename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filename, richTextBox1.Text, Encoding.Default);
                this.Text = filename;
            }
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //кнопка создать
            if (richTextBox1.TextLength == 0) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)        
                richTextBox1.Clear();
            else
                SaveAs();//самописная
        }
        private void оToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //кнопка открыть
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
                OpenFile();//самописная
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сохранить как...
            if (openFileDialog1.FileName != "")
                SaveAs();
            else
                SaveFile();
        }
        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                    SaveFile();
            }
        }

        private void вырезатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }


        private void параетрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Поисковый запрос pageSetupDialog1 с#
            pageSetupDialog1.PageSettings =
             new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            pageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog1.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{ 
            pageSetupDialog1.PageSettings.Margins, 
            pageSetupDialog1.PageSettings.PaperSize, 
            pageSetupDialog1.PageSettings.Landscape, 
            pageSetupDialog1.PrinterSettings.PrinterName, 
            pageSetupDialog1.PrinterSettings.PrintRange};             
            }
        }
         private System.Drawing.Printing.PrintDocument docToPrint = 
    new System.Drawing.Printing.PrintDocument();
         private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
         {

             //Запрос PrintDialog1 c#
             printDialog1.AllowSomePages = true;
             // Show the help button.
             printDialog1.ShowHelp = true;
             printDialog1.Document = docToPrint;
             DialogResult result = printDialog1.ShowDialog();
             if (result == DialogResult.OK)
             {
                 docToPrint.Print();
             }
         }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == false)
            {
                richTextBox1.WordWrap = true;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            }
            else
                richTextBox1.WordWrap = false;
        }

        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible == false)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
                
        }
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void впередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text ="Koл-во символов: " + (richTextBox1.TextLength).ToString();
            string[] words = richTextBox1.Text.Split(' ');
            toolStripStatusLabel2.Text = "Koл-во слов: " + words.Length.ToString(); 
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Иванов Иван Иванович группа Т50-1-18");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     
       
    }
}
