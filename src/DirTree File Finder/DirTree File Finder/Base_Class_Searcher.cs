using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirTree_File_Finder
{
    delegate void FilePathFound(string path);
    class Base_Class_Searcher
    {
        private string term;
        private string dir;

        public event FilePathFound FileLocation;
        public Base_Class_Searcher(string dir, string term)
        {
            this.dir = dir;
            this.term = term;
        }

        private void scan_directory(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            List<string> insideDirectory = new List<string>();
            insideDirectory.AddRange(files);
            insideDirectory.AddRange(dirs);
        
            foreach (string s in insideDirectory)
            {
                string _s = s.ToLower();
                string _term = this.term.ToLower();

                if (Directory.Exists(s) && s != "." && s != "..")
                {
                    scan_directory(s);
                    continue;
                }

                if (_s.Contains(_term))
                {
                    FileLocation(s);
                }
            }
        }
        public void search_in()
        {
            scan_directory(this.dir);
        }
        public string Term
        {
            set { term = value; }
            get { return this.term;  }
        }
        
        public string Dir
        {
            set { dir = value; }
            get { return this.dir;  }
        }
    }
}
