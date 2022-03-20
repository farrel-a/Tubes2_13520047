namespace DirTree_File_Finder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Slogan = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.PanelInput = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.RadioButtonDFS = new System.Windows.Forms.RadioButton();
            this.RadioButtonBFS = new System.Windows.Forms.RadioButton();
            this.LabelInputMetodePencarian = new System.Windows.Forms.Label();
            this.CheckBoxFindAllOccurence = new System.Windows.Forms.CheckBox();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.TextBoxInputFileName = new System.Windows.Forms.TextBox();
            this.LabelInputFileName = new System.Windows.Forms.Label();
            this.LabelDirectory = new System.Windows.Forms.Label();
            this.ButtonChooseFolder = new System.Windows.Forms.Button();
            this.LabelStartingDirectory = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.PanelOutput = new System.Windows.Forms.Panel();
            this.LabelTimeSpent = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelPathFile = new System.Windows.Forms.Label();
            this.PanelOutputTree = new System.Windows.Forms.Panel();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelInput.SuspendLayout();
            this.PanelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.TopPanel.Controls.Add(this.Slogan);
            this.TopPanel.Controls.Add(this.Logo);
            this.TopPanel.Controls.Add(this.AppName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 85);
            this.TopPanel.TabIndex = 0;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.Location = new System.Drawing.Point(321, 48);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(236, 19);
            this.Slogan.TabIndex = 2;
            this.Slogan.Text = "\"your truly systematic file finder\"";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(232, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(62, 58);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(310, 15);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(261, 34);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "DirTree File Finder";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppName.Click += new System.EventHandler(this.AppName_Click);
            // 
            // PanelInput
            // 
            this.PanelInput.BackColor = System.Drawing.Color.Pink;
            this.PanelInput.Controls.Add(this.ButtonSearch);
            this.PanelInput.Controls.Add(this.RadioButtonDFS);
            this.PanelInput.Controls.Add(this.RadioButtonBFS);
            this.PanelInput.Controls.Add(this.LabelInputMetodePencarian);
            this.PanelInput.Controls.Add(this.CheckBoxFindAllOccurence);
            this.PanelInput.Controls.Add(this.ExampleLabel);
            this.PanelInput.Controls.Add(this.TextBoxInputFileName);
            this.PanelInput.Controls.Add(this.LabelInputFileName);
            this.PanelInput.Controls.Add(this.LabelDirectory);
            this.PanelInput.Controls.Add(this.ButtonChooseFolder);
            this.PanelInput.Controls.Add(this.LabelStartingDirectory);
            this.PanelInput.Controls.Add(this.LabelInput);
            this.PanelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelInput.Location = new System.Drawing.Point(0, 85);
            this.PanelInput.Name = "PanelInput";
            this.PanelInput.Size = new System.Drawing.Size(288, 554);
            this.PanelInput.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(12, 467);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(253, 34);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // RadioButtonDFS
            // 
            this.RadioButtonDFS.AutoSize = true;
            this.RadioButtonDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonDFS.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonDFS.Location = new System.Drawing.Point(12, 426);
            this.RadioButtonDFS.Name = "RadioButtonDFS";
            this.RadioButtonDFS.Size = new System.Drawing.Size(62, 23);
            this.RadioButtonDFS.TabIndex = 6;
            this.RadioButtonDFS.TabStop = true;
            this.RadioButtonDFS.Text = "DFS";
            this.RadioButtonDFS.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBFS
            // 
            this.RadioButtonBFS.AutoSize = true;
            this.RadioButtonBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonBFS.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonBFS.Location = new System.Drawing.Point(12, 396);
            this.RadioButtonBFS.Name = "RadioButtonBFS";
            this.RadioButtonBFS.Size = new System.Drawing.Size(60, 23);
            this.RadioButtonBFS.TabIndex = 5;
            this.RadioButtonBFS.TabStop = true;
            this.RadioButtonBFS.Text = "BFS";
            this.RadioButtonBFS.UseVisualStyleBackColor = true;
            // 
            // LabelInputMetodePencarian
            // 
            this.LabelInputMetodePencarian.AutoSize = true;
            this.LabelInputMetodePencarian.Font = new System.Drawing.Font("Leelawadee", 8F);
            this.LabelInputMetodePencarian.Location = new System.Drawing.Point(13, 360);
            this.LabelInputMetodePencarian.Name = "LabelInputMetodePencarian";
            this.LabelInputMetodePencarian.Size = new System.Drawing.Size(174, 19);
            this.LabelInputMetodePencarian.TabIndex = 1;
            this.LabelInputMetodePencarian.Text = "Input metode pencarian";
            // 
            // CheckBoxFindAllOccurence
            // 
            this.CheckBoxFindAllOccurence.AutoSize = true;
            this.CheckBoxFindAllOccurence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxFindAllOccurence.Font = new System.Drawing.Font("Leelawadee", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxFindAllOccurence.Location = new System.Drawing.Point(12, 315);
            this.CheckBoxFindAllOccurence.Name = "CheckBoxFindAllOccurence";
            this.CheckBoxFindAllOccurence.Size = new System.Drawing.Size(141, 21);
            this.CheckBoxFindAllOccurence.TabIndex = 1;
            this.CheckBoxFindAllOccurence.Text = "FindAllOccurence";
            this.CheckBoxFindAllOccurence.UseVisualStyleBackColor = true;
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Font = new System.Drawing.Font("Leelawadee", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleLabel.Location = new System.Drawing.Point(13, 277);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(164, 14);
            this.ExampleLabel.TabIndex = 4;
            this.ExampleLabel.Text = "e.g. \"algorithm strategies.pdf\"";
            // 
            // TextBoxInputFileName
            // 
            this.TextBoxInputFileName.Font = new System.Drawing.Font("Leelawadee", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInputFileName.Location = new System.Drawing.Point(12, 236);
            this.TextBoxInputFileName.Name = "TextBoxInputFileName";
            this.TextBoxInputFileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxInputFileName.Size = new System.Drawing.Size(253, 24);
            this.TextBoxInputFileName.TabIndex = 1;
            // 
            // LabelInputFileName
            // 
            this.LabelInputFileName.AutoSize = true;
            this.LabelInputFileName.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInputFileName.Location = new System.Drawing.Point(12, 201);
            this.LabelInputFileName.Name = "LabelInputFileName";
            this.LabelInputFileName.Size = new System.Drawing.Size(113, 19);
            this.LabelInputFileName.TabIndex = 1;
            this.LabelInputFileName.Text = "Input file name";
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AllowDrop = true;
            this.LabelDirectory.AutoEllipsis = true;
            this.LabelDirectory.Font = new System.Drawing.Font("Leelawadee", 6F);
            this.LabelDirectory.Location = new System.Drawing.Point(14, 145);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(255, 23);
            this.LabelDirectory.TabIndex = 3;
            this.LabelDirectory.Text = "No directory choosen";
            this.LabelDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonChooseFolder
            // 
            this.ButtonChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChooseFolder.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChooseFolder.Location = new System.Drawing.Point(12, 107);
            this.ButtonChooseFolder.Name = "ButtonChooseFolder";
            this.ButtonChooseFolder.Size = new System.Drawing.Size(257, 35);
            this.ButtonChooseFolder.TabIndex = 2;
            this.ButtonChooseFolder.Text = "Choose folder...";
            this.ButtonChooseFolder.UseVisualStyleBackColor = true;
            this.ButtonChooseFolder.Click += new System.EventHandler(this.ButtonChooseFolder_Click);
            // 
            // LabelStartingDirectory
            // 
            this.LabelStartingDirectory.AutoSize = true;
            this.LabelStartingDirectory.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartingDirectory.Location = new System.Drawing.Point(12, 76);
            this.LabelStartingDirectory.Name = "LabelStartingDirectory";
            this.LabelStartingDirectory.Size = new System.Drawing.Size(184, 19);
            this.LabelStartingDirectory.TabIndex = 1;
            this.LabelStartingDirectory.Text = "Choose starting directory";
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelInput.Location = new System.Drawing.Point(94, 17);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(69, 29);
            this.LabelInput.TabIndex = 0;
            this.LabelInput.Text = "Input";
            // 
            // PanelOutput
            // 
            this.PanelOutput.BackColor = System.Drawing.Color.Pink;
            this.PanelOutput.Controls.Add(this.listBox1);
            this.PanelOutput.Controls.Add(this.LabelTimeSpent);
            this.PanelOutput.Controls.Add(this.linkLabel1);
            this.PanelOutput.Controls.Add(this.LabelPathFile);
            this.PanelOutput.Controls.Add(this.PanelOutputTree);
            this.PanelOutput.Controls.Add(this.LabelOutput);
            this.PanelOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelOutput.Location = new System.Drawing.Point(294, 85);
            this.PanelOutput.Name = "PanelOutput";
            this.PanelOutput.Size = new System.Drawing.Size(506, 554);
            this.PanelOutput.TabIndex = 2;
            // 
            // LabelTimeSpent
            // 
            this.LabelTimeSpent.AutoSize = true;
            this.LabelTimeSpent.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeSpent.Location = new System.Drawing.Point(27, 503);
            this.LabelTimeSpent.Name = "LabelTimeSpent";
            this.LabelTimeSpent.Size = new System.Drawing.Size(85, 19);
            this.LabelTimeSpent.TabIndex = 4;
            this.LabelTimeSpent.Text = "Time spent";
            this.LabelTimeSpent.Click += new System.EventHandler(this.LabelTimeSpent_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(27, 467);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // LabelPathFile
            // 
            this.LabelPathFile.AutoSize = true;
            this.LabelPathFile.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPathFile.Location = new System.Drawing.Point(27, 439);
            this.LabelPathFile.Name = "LabelPathFile";
            this.LabelPathFile.Size = new System.Drawing.Size(65, 19);
            this.LabelPathFile.TabIndex = 2;
            this.LabelPathFile.Text = "Path file";
            // 
            // PanelOutputTree
            // 
            this.PanelOutputTree.BackColor = System.Drawing.Color.LavenderBlush;
            this.PanelOutputTree.Location = new System.Drawing.Point(31, 76);
            this.PanelOutputTree.Name = "PanelOutputTree";
            this.PanelOutputTree.Size = new System.Drawing.Size(439, 343);
            this.PanelOutputTree.TabIndex = 1;
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutput.Location = new System.Drawing.Point(216, 17);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(89, 29);
            this.LabelOutput.TabIndex = 0;
            this.LabelOutput.Text = "Output";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(22, 438);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 84);
            this.listBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.PanelOutput);
            this.Controls.Add(this.PanelInput);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DirTree File Finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelInput.ResumeLayout(false);
            this.PanelInput.PerformLayout();
            this.PanelOutput.ResumeLayout(false);
            this.PanelOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Panel PanelInput;
        private System.Windows.Forms.Panel PanelOutput;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.Button ButtonChooseFolder;
        private System.Windows.Forms.Label LabelStartingDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TextBoxInputFileName;
        private System.Windows.Forms.Label LabelInputFileName;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.RadioButton RadioButtonDFS;
        private System.Windows.Forms.RadioButton RadioButtonBFS;
        private System.Windows.Forms.Label LabelInputMetodePencarian;
        private System.Windows.Forms.CheckBox CheckBoxFindAllOccurence;
        private System.Windows.Forms.Label LabelTimeSpent;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LabelPathFile;
        private System.Windows.Forms.Panel PanelOutputTree;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

