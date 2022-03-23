using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DirTree_File_Finder
{
    class BFS : Base_Class_Searcher
    {
        //Attributes
        public event FilePathFound FileLocation;
        private bool findAllOccurrences;
        private Queue<string> filepaths;
        private bool fileIsFound;

        //CTOR
        public BFS(string filename, string current_path) : base(filename, current_path) {
            this.findAllOccurrences = false;
            this.filepaths = new Queue<string>();
            this.fileIsFound = false;
        }

        //Methods
        public void findFileBFS(string current_path, bool findAllOccurrences)
        {
            
            this.findAllOccurrences = findAllOccurrences;
            filepaths.Enqueue(current_path);

            if (!this.findAllOccurrences)
            {
                while (!this.fileIsFound)
                {
                    string path = filepaths.Dequeue();
                    this.search_log.Add(path);
                    List<string> contents = findContents(path);
                    //by default sorted by dir, (heuristic) -> because bfs, reverse to sort by file first
                    contents.Reverse();
                    foreach (string c in contents)
                    {
                        if (Path.GetFileName(c).Equals(this.filename) && !this.fileIsFound)
                        {
                            this.search_log.Add(c);
                            this.FileLocation(c);
                            this.fileIsFound = true;  
                        }
                        else if (!Path.GetFileName(c).Equals(this.filename) && !Directory.Exists(c) && !this.fileIsFound)
                        {
                            this.search_log.Add(c);
                        }
                        else if (Directory.Exists(c))
                        {
                            filepaths.Enqueue(c);
                        }
                        else if (this.fileIsFound)
                        {
                            filepaths.Enqueue(c);
                        }
                    }

                }
            }

            else
            {
                while (filepaths.Count>0)
                {
                    string path = filepaths.Dequeue();
                    this.search_log.Add(path);
                    List<string> contents = findContents(path);
                    //by default sorted by dir, (heuristic) -> because bfs, reverse to sort by file first
                    contents.Reverse();
                    foreach (string c in contents)
                    {
                        if (Path.GetFileName(c).Equals(this.filename) && !this.fileIsFound)
                        {
                            this.search_log.Add(c);
                            this.FileLocation(c);
                        }
                        else if (!Path.GetFileName(c).Equals(this.filename) && !Directory.Exists(c))
                        {
                            this.search_log.Add(c);
                        }
                        else if (Directory.Exists(c))
                        {
                            filepaths.Enqueue(c);
                        }
                        else if (this.fileIsFound)
                        {
                            filepaths.Enqueue(c);
                        }
                    }

                }
            }
        }

        // Getter & Setter
        public bool FileIsFound
        {
            set { this.fileIsFound = value; }
            get { return this.fileIsFound; }
        }
    }
}
