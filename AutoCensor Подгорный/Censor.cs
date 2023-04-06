using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Лабораторная_ГДиК_AutoCensor_Подгорный
{
    class Censor
    {

        List<string> ForReplacement;
        public List<string> Logs { get; set; }

        public int CountReplace { get; set; }

        public Censor(string str_ForReplacement) 
        {
            if (str_ForReplacement == null)
                throw new ArgumentNullException("Данные список не может быть null!");

            string[] arrStr = Regex.Replace(str_ForReplacement, "\r", "").Split('\n');

            ForReplacement = new List<string>();

            foreach(string str in arrStr)
            {
                ForReplacement.Add(str);
            }
        }

        public Censor(List<string> _ForReplacement)
        {
            if (_ForReplacement == null)
                throw new ArgumentNullException("Данные список не может быть null!");

            ForReplacement = _ForReplacement;
        }

        public List<string> StartConsor(string Path_to_File, string Path_to_EndFile)
        {
            if (!File.Exists(Path_to_File))
                throw new FileNotFoundException("Такого файла не существует!");

            if (Path_to_EndFile != null && !Directory.Exists(Path_to_EndFile))
                throw new DirectoryNotFoundException("Такой директории не существует!");

            Logs = new List<string>();

            CountReplace = 0;

            CensorOperation(Path_to_File, Path_to_EndFile);

            if(Logs.Count == 0)
            {
                return new List<string>() { "Данный файл не содержит слова из заданного списка." };
            }

            return Logs;
        }

        private void CensorOperation(string Path_to_File, string Path_to_EndFile)
        {
            string[] LeftData = Regex.Replace(Path_to_File, @"\\", @"\").Split('\\');

            string OutputFileName = "";

            if (Path_to_EndFile != null)
            {
                OutputFileName = Path_to_EndFile + "Censor_" + LeftData[LeftData.Length - 1];
            }
            else
            {
                for (int i = 0; i < LeftData.Length - 1; i++)
                {
                    OutputFileName += LeftData[i] + @"\";
                }
                OutputFileName += "Censor_" + LeftData[LeftData.Length - 1];
            }

            int PositionLine = 0;

            using (var sr = new StreamReader(Path_to_File))
            {
                File.WriteAllText(OutputFileName, string.Empty); //Очищяем данные файла в случае если такой файл существует

                string datastr = "";
                while ((datastr = sr.ReadLine()) != null)
                {
                    PositionLine++;

                    foreach (string dataReplacment in ForReplacement)
                    {
                        if (Regex.IsMatch(datastr, dataReplacment))
                        {
                            string StringToReplace = "";

                            foreach (char s in dataReplacment)
                            {
                                if (s != ' ')
                                    StringToReplace += "*";
                                else
                                    StringToReplace += " ";
                            }

                            CountReplace++;
                            Logs.Add($"{DateTime.Now.ToLongTimeString()} Строка {PositionLine} Соответствие по [{dataReplacment}]");
                            datastr = Regex.Replace(datastr, dataReplacment, StringToReplace);
                        }

                    }

                    using (var sw = new StreamWriter(OutputFileName, true)) ///
                    {
                        sw.WriteLine(datastr);
                    }
                }
            }
        }

    }
}
