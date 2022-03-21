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

        //CTOR
        public DFS(string filename, string current_path) : base(filename, current_path) { }

        //Methods
        public void findFileDFS(string current_path)
        {
            List<string> contents = findContents(current_path);  //all content (files and dirs) in a form of abs. path
            foreach(string c in contents)                        //for every content (path) in contents
            {
                //Add to search_log
                this.search_log.Add(c);

                //To Debug
                //Debug.WriteLine(c);
                
                //Search directory first, findContents already sorted by dir first then file
                if (Directory.Exists(c) && (c != "." || c != ".."))
                {
                    this.findFileDFS(c);    //if path c is a directory, go to inside c
                    continue;
                }
                else if (c.ToLower().Contains(this.filename.ToLower()))
                {
                    this.FileLocation(c); //path c is a file found
                }
            }
        }
    }
}
