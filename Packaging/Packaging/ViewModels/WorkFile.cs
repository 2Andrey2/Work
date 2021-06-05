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
        int CountColumns;
        int CountLine;
        string Path;
        string PathRez;
        StreamReader StreamR;
        StreamWriter StreamW;
        string[,,] rezmass;
        int z;
        public WorkFile(int countColum, int countLine, string path, string pathrez)
        {
            CountColumns = countColum;
            CountLine = countLine;
            Path = path;
            PathRez = pathrez;
            rezmass = new string[countLine, countColum, System.IO.File.ReadAllLines(Path).Length/ (countLine+1)];
            z = 0;
        }
        public void BildFile()
        {
            int countbloks = System.IO.File.ReadAllLines(Path).Length / (CountLine + 1);
            ReaderWriterOpen();
            for (int i = 0; i < countbloks; i++)
            {
                BildMass(ReadBlok());
            }
            WriteFile();
            ReaderWriterClose();
        }
        private void ReaderWriterOpen()
        {
            StreamR = new StreamReader(Path);
            StreamW = new StreamWriter(PathRez + "/Rez.txt");
        }
        private void ReaderWriterClose()
        {
            StreamR.Close();
            StreamW.Close();
        }
        private string[] ReadBlok ()
        {
            string[] mass = new string[CountLine];
            StreamR.ReadLine();
            for (int i = 0; i < CountLine; i++)
            {
                mass[i] = StreamR.ReadLine();
            }
            return mass;
        }
        private void BildMass (string[] mass)
        {
            string[,] series = new string[CountLine, CountColumns];
            string[,] number = new string[CountLine, CountColumns];
            string[,] masstemp = new string[CountLine, CountColumns];
            for (int i = 0; i < CountLine; i++)
            {
                string[] temp = mass[i].Split(' ').ToArray();
                temp = temp.Where(x => x != "" && x != " ").ToArray();
                int flag = 0;
                int longlinr = temp.Length / CountColumns;
                for (int j = 0; j < CountColumns; j++)
                {
                    rezmass[i, j,z] = temp[flag];
                    rezmass[i, j,z] += temp[flag + 1];
                    flag += longlinr + 1;
                }
            }
            z++;
        }
        private void WriteFile ()
        {
            int zcont = System.IO.File.ReadAllLines(Path).Length / (CountLine + 1);
            for (int i = 0; i < CountColumns; i++)
            {
                for (int j = 0; j < CountLine; j++)
                {
                    for (int z = 0; z < zcont; z++)
                    {
                        StreamW.WriteLine(rezmass[j,i,z]);
                    }
                }
            }
        }

    }
}
