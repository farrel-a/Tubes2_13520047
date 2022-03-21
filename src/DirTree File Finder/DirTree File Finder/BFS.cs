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

        //CTOR
        public BFS(string filename, string current_path) : base(filename, current_path) { }

        //Methods
        public void findFileBFS(string current_path, bool findAllOccurrences)
        {
            //Add BFS Algorithm here
        }
    }
}
