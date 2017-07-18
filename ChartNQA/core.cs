using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ChartNQA
{
    public class CsvReader
    {

        public string fileName { get; set; }
        public string[] lines;
        public string[] headers;

        public string FileName
        {
            get { return fileName; }
        }


        public CsvReader(string fileName)
        {
            this.fileName = fileName;
        }

        public void Read()
        {
            lines = File.ReadAllLines(fileName);
            headers = lines[0].Split(';');
        }

        public static class Builder
        {
            public static CsvReader CreateInstance(string filePath)
            {
                if (!File.Exists(filePath))
                {
                    throw new ArgumentException();
                }
                CsvReader reader = new CsvReader(filePath);
                reader.Read();
                return reader;
            }
        }

        public static void start(string filename)
        {
            MessageBox.Show(filename);
        }   
    }
}
