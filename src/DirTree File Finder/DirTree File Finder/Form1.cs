using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirTree_File_Finder
{
    public partial class MainForm : Form
    {
        private Base_Class_Searcher base_class_searcher;
        public MainForm()
        {
            InitializeComponent();
            this.base_class_searcher = new Base_Class_Searcher(null, null);
            this.base_class_searcher.FileLocation += FileFound;
            backgroundWorker1.DoWork += Background_Worker;
            backgroundWorker1.RunWorkerCompleted += Completed;
      
        }

        private void FileFound(string path)
        {
            listBox1.BeginInvoke((Action)delegate ()
           {
               listBox1.Items.Add(path);
           });
        }
        private void Completed(object sender, RunWorkerCompletedEventArgs args)
        {
            MessageBox.Show("Done");
        }

        private void Background_Worker(object sender,DoWorkEventArgs args)
        {
            base_class_searcher.search_in();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChooseFolder_Click(object sender, EventArgs e)
        {
            // Memilih Folder (Choose Folder)
            FolderBrowserDialog dialog = new FolderBrowserDialog(); // membuat objek baru

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LabelDirectory.Text = dialog.SelectedPath;
            }
        }

        private void LabelTimeSpent_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            this.base_class_searcher.Term = TextBoxInputFileName.Text;
            this.base_class_searcher.Dir = LabelDirectory.Text;
            backgroundWorker1.RunWorkerAsync();
            if (RadioButtonBFS.Checked)
            {
                
            }

            if (RadioButtonDFS.Checked)
            {

            }
        }
    }
}
