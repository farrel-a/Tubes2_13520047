using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Core.Geometry;
using Microsoft.Msagl.Routing;
using System.Diagnostics;

namespace DirTree_File_Finder
{
    class Tree
    {
        // Attributes
        private List<string> search_log;       // path search log
        private Microsoft.Msagl.Drawing.Graph graph;   // graph object
        private List<string> edge;             // edge list
        private List<string> foundFilePath;
        private Queue<string> uncheckedPath;

        //CTOR
        public Tree(List<string> search_log, List<string> foundFilePath, Queue<string> uncheckedPath)
        {
            this.search_log = search_log;
            this.graph = new Microsoft.Msagl.Drawing.Graph("Search Tree");
            this.edge = new List<string>();
            this.foundFilePath = foundFilePath;
            this.uncheckedPath = uncheckedPath;
        }

        // Methods
        public void generateTree()
        {
            // colorise unchecked as black
            foreach (string p in uncheckedPath)
            {
                string[] subs = p.Split('\\');
                for (int i = 0; i < subs.Length - 1; i++)
                {
                    string edgeName = subs[i] + subs[i + 1];
                    if (!this.edge.Contains(edgeName))
                    {
                        Edge e = graph.AddEdge(subs[i], subs[i + 1]);
                        e.SourceNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        e.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        e.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        this.edge.Add(edgeName);
                    }
                }
            }

            // colorise checked as red
            foreach (string p in this.search_log)
            {
                string[] subs = p.Split('\\');
                if (!this.foundFilePath.Contains(p))
                {
                    for (int i = 0; i < subs.Length - 1; i++)
                    {
                        string edgeName = subs[i] + subs[i + 1];
                        if (!this.edge.Contains(edgeName))
                        {
                            Edge e = graph.AddEdge(subs[i], subs[i + 1]);
                            e.SourceNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            e.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            this.edge.Add(edgeName);
                        }
                        else
                        {
                            foreach (Edge e in graph.Edges)
                            {
                                if (e.Source.Equals(subs[i]) && e.Target.Equals(subs[i + 1]))
                                {
                                    e.SourceNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                    e.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                }
                            }
                        }
                    }
                }
            }

            // colorise found as blue
            foreach (string p in this.foundFilePath)
            {
                string[] subs = p.Split('\\');
                for (int i = 0; i < subs.Length - 1; i++)
                {
                    string edgeName = subs[i] + subs[i + 1];
                    if (!this.edge.Contains(edgeName))
                    {
                        Edge e = graph.AddEdge(subs[i], subs[i + 1]);
                        e.SourceNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        e.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        e.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        this.edge.Add(edgeName);
                    }
                    else
                    {
                        foreach (Edge e in graph.Edges)
                        {
                            if (e.Source.Equals(subs[i]) && e.Target.Equals(subs[i + 1]))
                            {
                                e.SourceNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                                e.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                                e.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            }
                        }
                    }
                }
            }
        }

        public void displayTree()
        {
            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();

            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //bind the graph object to the viewer
            viewer.Graph = this.graph;

            //associate the viewer with the form
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();

            //show the form 
            form.ShowDialog();
        }

        // Getter & Setter
        public Microsoft.Msagl.Drawing.Graph Graph
        {
            set { this.graph = value; }
            get { return this.graph; }
        }

        public List<string> Search_log
        {
            set { this.search_log = value; }
            get { return this.search_log; }
        }




    }
}
