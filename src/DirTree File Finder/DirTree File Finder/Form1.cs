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
    delegate void FilePathFound(string path);

    public partial class MainForm : Form
    {
        private DFS dfs_method;
        // Add BFS here (follow like DFS)

        public MainForm()
        {
            InitializeComponent();
            this.dfs_method = new DFS(null, null);
            this.dfs_method.FileLocation += FileFound;

            // Add BFS here (follow like DFS)

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
            if (RadioButtonBFS.Checked)
            {
                //add BFS here
            }

            if (RadioButtonDFS.Checked)
            {
                //true = find all occurrences
                dfs_method.findFileDFS(dfs_method.Current_path, true);
            }   
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
            this.dfs_method.Filename = TextBoxInputFileName.Text;
            this.dfs_method.Current_path = LabelDirectory.Text;
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
