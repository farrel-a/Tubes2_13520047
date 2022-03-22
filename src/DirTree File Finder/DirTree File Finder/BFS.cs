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

        //CTOR
        public BFS(string filename, string current_path) : base(filename, current_path) {
            this.findAllOccurrences = true;
        }

        //Methods
        public void findFileBFS(string current_path, bool findAllOccurrences)
        {
            //Add BFS Algorithm here
            Queue <string> files = new Queue <string>();
            this.findAllOccurrences = findAllOccurrences;
            files.Enqueue(current_path);
            Console.WriteLine(current_path);

            while (files.Count > 0)
            {
                string path = files.Dequeue();
                string [] listFile = path.Split('/');
                if (listFile != null)
                {
                    foreach(string file in listFile)
                    {
                        if (file != current_path)
                        {
                            Console.WriteLine(file);
                            files.Enqueue(file);
                            findAllOccurrences = true;
                        }
                    }
                }
            }
        }
    }
}
