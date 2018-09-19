using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace sep_12_2018
{
    public static class Writetolog
    {
        public static void Write(Exception e1)
        {
            string error = " " + DateTime.Now + ":" + e1.StackTrace + Environment.NewLine;
            string path = @"D:\errorlist.txt";
            //File.OpenWrite(path);
            File.AppendAllText(path, error);
        }
    }
}
