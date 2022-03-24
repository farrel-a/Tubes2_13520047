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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TreeViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.PanelOutput = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTimeSpent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.PanelOutput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(1026, 85);
            this.TopPanel.TabIndex = 0;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.Location = new System.Drawing.Point(387, 48);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(236, 19);
            this.Slogan.TabIndex = 2;
            this.Slogan.Text = "\"your truly systematic file finder\"";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(298, 12);
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
            this.AppName.Location = new System.Drawing.Point(376, 15);
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
            this.PanelInput.Size = new System.Drawing.Size(288, 521);
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
            this.CheckBoxFindAllOccurence.Location = new System.Drawing.Point(12, 302);
            this.CheckBoxFindAllOccurence.Name = "CheckBoxFindAllOccurence";
            this.CheckBoxFindAllOccurence.Size = new System.Drawing.Size(144, 21);
            this.CheckBoxFindAllOccurence.TabIndex = 1;
            this.CheckBoxFindAllOccurence.Text = "Find all occurence";
            this.CheckBoxFindAllOccurence.UseVisualStyleBackColor = true;
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Font = new System.Drawing.Font("Leelawadee", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleLabel.Location = new System.Drawing.Point(13, 270);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(164, 14);
            this.ExampleLabel.TabIndex = 4;
            this.ExampleLabel.Text = "e.g. \"algorithm strategies.pdf\"";
            // 
            // TextBoxInputFileName
            // 
            this.TextBoxInputFileName.Font = new System.Drawing.Font("Leelawadee", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInputFileName.Location = new System.Drawing.Point(12, 230);
            this.TextBoxInputFileName.Name = "TextBoxInputFileName";
            this.TextBoxInputFileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxInputFileName.Size = new System.Drawing.Size(253, 24);
            this.TextBoxInputFileName.TabIndex = 1;
            // 
            // LabelInputFileName
            // 
            this.LabelInputFileName.AutoSize = true;
            this.LabelInputFileName.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInputFileName.Location = new System.Drawing.Point(12, 197);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(288, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 521);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Pink;
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(20, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(368, 521);
            this.panel8.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Controls.Add(this.TreeViewer);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 64);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.panel11.Size = new System.Drawing.Size(368, 393);
            this.panel11.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 393);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TreeViewer
            // 
            this.TreeViewer.ArrowheadLength = 10D;
            this.TreeViewer.AsyncLayout = false;
            this.TreeViewer.AutoScroll = true;
            this.TreeViewer.BackColor = System.Drawing.Color.LavenderBlush;
            this.TreeViewer.BackwardEnabled = false;
            this.TreeViewer.BuildHitTree = true;
            this.TreeViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.TreeViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewer.EdgeInsertButtonVisible = false;
            this.TreeViewer.FileName = "";
            this.TreeViewer.ForwardEnabled = false;
            this.TreeViewer.Graph = null;
            this.TreeViewer.InsertingEdge = false;
            this.TreeViewer.LayoutAlgorithmSettingsButtonVisible = false;
            this.TreeViewer.LayoutEditingEnabled = true;
            this.TreeViewer.Location = new System.Drawing.Point(18, 0);
            this.TreeViewer.LooseOffsetForRouting = 0.25D;
            this.TreeViewer.MouseHitDistance = 0.05D;
            this.TreeViewer.Name = "TreeViewer";
            this.TreeViewer.NavigationVisible = true;
            this.TreeViewer.NeedToCalculateLayout = true;
            this.TreeViewer.OffsetForRelaxingInRouting = 0.6D;
            this.TreeViewer.PaddingForEdgeRouting = 8D;
            this.TreeViewer.PanButtonPressed = false;
            this.TreeViewer.SaveAsImageEnabled = true;
            this.TreeViewer.SaveAsMsaglEnabled = true;
            this.TreeViewer.SaveButtonVisible = true;
            this.TreeViewer.SaveGraphButtonVisible = true;
            this.TreeViewer.SaveInVectorFormatEnabled = true;
            this.TreeViewer.Size = new System.Drawing.Size(332, 393);
            this.TreeViewer.TabIndex = 0;
            this.TreeViewer.TightOffsetForRouting = 0.125D;
            this.TreeViewer.ToolBarIsVisible = true;
            this.TreeViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("TreeViewer.Transform")));
            this.TreeViewer.UndoRedoButtonsVisible = false;
            this.TreeViewer.WindowZoomButtonPressed = false;
            this.TreeViewer.ZoomF = 1D;
            this.TreeViewer.ZoomWindowThreshold = 0.05D;
            this.TreeViewer.Load += new System.EventHandler(this.gViewer1_Load_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 457);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(368, 64);
            this.panel10.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "©️ 2022, MTMA";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(368, 64);
            this.panel9.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tree";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(388, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(18, 521);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 521);
            this.panel6.TabIndex = 0;
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutput.Location = new System.Drawing.Point(116, 17);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(89, 29);
            this.LabelOutput.TabIndex = 0;
            this.LabelOutput.Text = "Output";
            // 
            // PanelOutput
            // 
            this.PanelOutput.BackColor = System.Drawing.Color.Pink;
            this.PanelOutput.Controls.Add(this.panel13);
            this.PanelOutput.Controls.Add(this.panel12);
            this.PanelOutput.Controls.Add(this.panel5);
            this.PanelOutput.Controls.Add(this.panel4);
            this.PanelOutput.Controls.Add(this.panel2);
            this.PanelOutput.Controls.Add(this.panel3);
            this.PanelOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelOutput.Location = new System.Drawing.Point(694, 85);
            this.PanelOutput.Name = "PanelOutput";
            this.PanelOutput.Size = new System.Drawing.Size(332, 521);
            this.PanelOutput.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(296, 172);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(314, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 393);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 393);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LabelTimeSpent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 64);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time spent:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelTimeSpent
            // 
            this.LabelTimeSpent.AutoSize = true;
            this.LabelTimeSpent.Font = new System.Drawing.Font("Leelawadee", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeSpent.Location = new System.Drawing.Point(104, 21);
            this.LabelTimeSpent.Name = "LabelTimeSpent";
            this.LabelTimeSpent.Size = new System.Drawing.Size(18, 19);
            this.LabelTimeSpent.TabIndex = 4;
            this.LabelTimeSpent.Text = "0";
            this.LabelTimeSpent.Click += new System.EventHandler(this.LabelTimeSpent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelOutput);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 64);
            this.panel3.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.listBox2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(18, 255);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.panel12.Size = new System.Drawing.Size(296, 202);
            this.panel12.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.listBox1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(18, 64);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.panel13.Size = new System.Drawing.Size(296, 190);
            this.panel13.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(0, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(296, 184);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Open the file here!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Open the folder here!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1026, 606);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.PanelOutput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Panel PanelInput;
        private System.Windows.Forms.Label LabelInput;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Panel PanelOutput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTimeSpent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private Microsoft.Msagl.GraphViewerGdi.GViewer TreeViewer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

