using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AppRhh
{
    public class LogSingleton
    {
   
        private string Path = "";

        public LogSingleton(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena = " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path +"/"+nombre, true);
            sw.Write(cadena);
            sw.Close();
        }

        #region HELPER

        private string GetNameFile()
        {
            string nombre = "";

            nombre ="log_ "+ DateTime.Now.Year + "_" + DateTime.Now.Month + DateTime.Now.Day + " .txt";
           

            return nombre;
        }
        private void CreateDirectory()
        {
            try
            {
                if (Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

                    

            }catch(DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
        #endregion
    }
}
