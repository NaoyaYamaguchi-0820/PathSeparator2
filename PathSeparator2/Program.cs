using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace PathSeparator2
{
    class Program
    {
        static void Main(string[] args)
        {

            string homePath = Directory.GetCurrentDirectory();
            string inputFilePath = Path.Combine(homePath, "input.txt");


            List<string> rowList = new List<string>();

            // テキストファイルを読み込む
            using (var reader = new StreamReader(inputFilePath))
            {

                string row;

                while((row = reader.ReadLine()) != null){
                    rowList.Add(row);
                }

            }

            string outputFilePath = Path.Combine(homePath, "output.txt");

            using (var writer = new StreamWriter(outputFilePath, false, Encoding.GetEncoding("Shift_JIS")))
            {
                foreach (string str in rowList)
                {
                    string path = Directory.GetParent(str).ToString();
                    string name = Path.GetFileName(str);

                    writer.WriteLine(path + "," + name);
                }
            }

            // 終了
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
