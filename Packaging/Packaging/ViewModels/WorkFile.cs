using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packaging.ViewModels
{
    class WorkFile
    {
        int CountColum;
        int CountLine;
        string Path;
        StreamReader StreamR;
        public WorkFile(int countColum, int countLine, string path)
        {
            CountColum = countColum;
            CountLine = countLine;
            Path = path;
        }
        public void Reader()
        {
            StreamR = new StreamReader(Path);
        }
        public void ReadBlok ()
        {
            for (int i = 0; i < CountColum* CountLine; i++)
            {

            }
        }
    }
}
