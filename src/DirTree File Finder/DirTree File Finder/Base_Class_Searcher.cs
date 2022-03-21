using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DirTree_File_Finder
{
    class Base_Class_Searcher
    {
       //Attributes
       protected string filename;         // filename
       protected string current_path;     // in absolute
       protected List<string> search_log; // search path log

       public Base_Class_Searcher(string filename, string current_path)
        {
            this.filename = filename;
            this.current_path = current_path;
            this.search_log = new List<string>();
        }

        public List<string> findContents(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            List<string> contents = new List<string>();
            contents.AddRange(dirs);
            contents.AddRange(files);
            return contents;
        }

        public string Filename
        {
            set { this.filename = value; }
            get { return this.filename;  }
        }
        
        public string Current_path
        {
            set { this.current_path = value; }
            get { return this.current_path;  }
        }

        public List<string> Search_log
        {
            set { this.search_log = value;}
            get { return this.search_log;}
        }
    }
}
