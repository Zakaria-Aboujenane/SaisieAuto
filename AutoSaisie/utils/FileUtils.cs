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
        public static void stringsToFile(String path,List<String> strings)
        {
            string[] lines = strings.ToArray();
            File.WriteAllLines(path, lines);

        }

        public static ImageList getImageListFromFile()
        {
            ImageList imageList = new ImageList() ;
            foreach (var ligne in FileUtils.fileToStrings(MyAppCtx.filesPath + "images.txt"))
            {
                
                string[] l = ligne.Split('-');
                imageList.Images.Add(l[0], Image.FromFile(MyAppCtx.iconsPath + l[1]));
            }
            return imageList;
            
        }
        public static String getSageFor(String parameterName)
        {
            List<String> vars = FileUtils.fileToStrings(MyAppCtx.filesPath + "sageParams.txt");
            foreach (var p in vars)
            {
                string[] keyVal = p.Split('-');
                if (keyVal[0].Equals(parameterName))
                {
                    return keyVal[1];
                }
            }
            return null;
        }

        public static void setSageFor(String parameterName,String value)
        {
            String filePath = MyAppCtx.filesPath + "sageParams.txt";
            List<String> vars = FileUtils.fileToStrings(filePath);
            List<String> newVars = new List<string>();
            foreach (String p in vars)
            {
                string[] keyVal = p.Split('-');
                if (keyVal[0].Equals(parameterName))
                {
                    newVars.Add(keyVal[0] + "-" + value);
                }
                else
                {
                    newVars.Add(p);
                }
               
            }
            FileUtils.stringsToFile(filePath, newVars);
            
        }
        public static String getDBFor(String parameterName)
        {
            List<String> vars = FileUtils.fileToStrings(MyAppCtx.filesPath + "dbParams.txt");
            foreach (var p in vars)
            {
                string[] keyVal = p.Split('-');
                if (keyVal[0].Equals(parameterName))
                {
                    return keyVal[1];
                }
            }
            return null;
        }

        public static void setDBFor(String parameterName, String value)
        {
            String filePath = MyAppCtx.filesPath + "dbParams.txt";
            List<String> vars = FileUtils.fileToStrings(filePath);
            List<String> newVars = new List<string>();
            foreach (String p in vars)
            {
                string[] keyVal = p.Split('-');
                if (keyVal[0].Equals(parameterName))
                {
                    newVars.Add(keyVal[0] + "-" + value);
                }
                else
                {
                    newVars.Add(p);
                }

            }
            FileUtils.stringsToFile(filePath, newVars);

        }
    }
}
