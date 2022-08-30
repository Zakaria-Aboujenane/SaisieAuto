using AutoSaisie.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static ImageList getImageListFromFile()
        {
            ImageList imageList = new ImageList() ;
            foreach (var ligne in FileUtils.fileToStrings(MyApplicationContext.filesPath + "images.txt"))
            {
                
                string[] l = ligne.Split('-');
                imageList.Images.Add(l[0], Image.FromFile(MyApplicationContext.iconsPath + l[1]));
            }
            return imageList;
            
        }
      
    }
}
