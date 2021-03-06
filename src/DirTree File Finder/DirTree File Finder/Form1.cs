using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DirTree_File_Finder
{
    delegate void FilePathFound(string path);

    public partial class MainForm : Form
    {
        
        private double DFSTime;
        private double BFSTime;

        private DFS dfs_method;
        private BFS bfs_method;

        private Tree DFSTree;
        private Tree BFSTree;

        public MainForm()
        {
            
            InitializeComponent();
            this.dfs_method = new DFS(null, null);
            this.dfs_method.FileLocation += FileFound;

            this.bfs_method = new BFS(null, null);
            this.bfs_method.FileLocation += FileFound;

            backgroundWorker1.DoWork += Background_Worker;
            backgroundWorker1.RunWorkerCompleted += Completed;

        }

        private void FileFound(string path)
        {
            listBox1.BeginInvoke((Action)delegate ()
           {
               listBox1.Items.Add(path);
           });

            listBox2.BeginInvoke((Action)delegate ()
            {
                listBox2.Items.Add(Directory.GetParent(path).ToString());
            });

        }
        private void Completed(object sender, RunWorkerCompletedEventArgs args)
        {

            if (RadioButtonBFS.Checked)
            {
                this.LabelTimeSpent.Text = this.BFSTime.ToString() + " s";
            }
            else if (RadioButtonDFS.Checked)
            {
                this.LabelTimeSpent.Text = this.DFSTime.ToString() + " s";
            }

            if (listBox1.Items.Count > 0)
            {
                pictureBox1.Visible = false;
                MessageBox.Show("Done");
            }
            else
            {
                pictureBox1.Visible = true;
                MessageBox.Show("File not found");
            }

        }

        private void Background_Worker(object sender,DoWorkEventArgs args)
        {
            bool findAll;
            if (CheckBoxFindAllOccurence.Checked)
            {
                findAll = true;
            } else
            {
                findAll = false;
            }

            if (RadioButtonBFS.Checked)
            {
                // create stopwatch
                Stopwatch stopwatch = new Stopwatch();
                //start stopwatch
                stopwatch.Start();
                bfs_method.findFileBFS(bfs_method.Current_path, findAll);
                //stop stopwatch
                stopwatch.Stop();
                //elapsed time
                this.BFSTime = stopwatch.Elapsed.TotalSeconds;

                this.BFSTree = new Tree(bfs_method.Search_log, bfs_method.FoundFilePath, bfs_method.FilePaths);
                this.BFSTree.generateTree();
                TreeViewer.BeginInvoke((Action)delegate ()
                {
                    var g = this.BFSTree.Graph;
                    this.TreeViewer.Graph = g;
                });

                //Clear buffer, for next search input
                this.bfs_method.Search_log = new List<string>();
                this.bfs_method.FoundFilePath = new List<string>();
                this.bfs_method.FileIsFound = false;
                this.bfs_method.FilePaths = new Queue<string>();
            }

            if (RadioButtonDFS.Checked)
            {
                // Create stopwatch
                Stopwatch stopwatch = new Stopwatch();
                // Start stopwatch
                stopwatch.Start();
                // true = find all occurrences
                dfs_method.findFileDFS(dfs_method.Current_path, true, findAll);
                // Stop stopwatch
                stopwatch.Stop();
                // Elapsed time
                this.DFSTime = stopwatch.Elapsed.TotalSeconds; //in seconds

                //Create Tree
                this.DFSTree = new Tree(dfs_method.Search_log, dfs_method.FoundFilePath, dfs_method.FilePaths);
                this.DFSTree.generateTree();

                TreeViewer.BeginInvoke((Action)delegate ()
                {
                    var g = this.DFSTree.Graph;
                    this.TreeViewer.Graph = g;
                });

                //Clear buffer, for next search input
                this.dfs_method.Search_log = new List<string>();
                this.dfs_method.FoundFilePath = new List<string>();
                this.dfs_method.FileIsFound = false;
                this.dfs_method.FilePaths = new Queue<string>();


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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            this.dfs_method.Filename = TextBoxInputFileName.Text;
            this.dfs_method.Current_path = LabelDirectory.Text;

            this.bfs_method.Filename = TextBoxInputFileName.Text;
            this.bfs_method.Current_path = LabelDirectory.Text;
            backgroundWorker1.RunWorkerAsync();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.Start(listBox1.SelectedItem.ToString());
        }


        private void gViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.Start(listBox2.SelectedItem.ToString());
        }
    }
}
