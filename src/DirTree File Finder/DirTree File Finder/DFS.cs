using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DirTree_File_Finder
{
    class DFS : Base_Class_Searcher
    {
        //Attributes
        public event FilePathFound FileLocation;
        private bool findAllOccurrences;
        private bool fileIsFound;

        //CTOR
        public DFS(string filename, string current_path) : base(filename, current_path)
        {
            //default
            this.findAllOccurrences = false;
            this.fileIsFound = false;
        }

        //Methods
        public void findFileDFS(string current_path, bool findAllOccurrences)
        {
            this.findAllOccurrences = findAllOccurrences;
            List<string> contents = findContents(current_path);  //all content (files and dirs) in a form of abs. path
            foreach (string c in contents)                        //for every content (path) in contents
            {
                if (this.fileIsFound && !this.findAllOccurrences)
                {
                    break;
                }
                else
                {
                    //Add to search_log
                    this.search_log.Add(c);

                    //To Debug
                    //Debug.WriteLine(c);

                    //Search directory first, findContents already sorted by dir first then file
                    if (Directory.Exists(c) && (c != "." || c != ".."))
                    {
                        this.findFileDFS(c, this.findAllOccurrences);    //if path c is a directory, go to inside c
                        continue;
                    } // c.ToLower().Contains(this.filename.ToLower())
                    else if ((Path.GetFileName(c)).Equals(this.filename))
                    {
                        this.FileLocation(c); //path c is a file found
                        this.fileIsFound = true;
                    }
                }
            }
        }
    }
}