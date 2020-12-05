using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoviesFolder
{
    public class MovFolder
    {
        private string dir;

        public MovFolder(string dir)
        {
            this.dir = dir;
        }

        public void changeFolder(string dir) { this.dir = dir; }

        public string[] getFiles()
        {
            if(Directory.Exists(dir))
            {
                return Directory.GetFiles(dir);
            }
            else
            {
                throw new IOException("Directory does not exist");
            }
        }
    }
}
