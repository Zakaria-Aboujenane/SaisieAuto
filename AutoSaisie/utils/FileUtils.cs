using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.data.lecturefichier
{
    class FileUtils
    {
        public static Dictionary<String, int> stuctureToMap(String structure)
        {
            var structureMap = new Dictionary<String, int>();
            String[] strlist = structure.Split(';');
            foreach (var item in strlist)
            {
                String[] keyval = item.Split('-');
                structureMap[keyval[0]] = Int16.Parse(keyval[1]);
            }
            return structureMap;
        }

        public static List<String> fileToStrings(String path)
        {
            List<String> lines = new List<String>();
            using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }
            }
            return lines;
        }
    }
}
