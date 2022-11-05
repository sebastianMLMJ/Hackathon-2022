using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Hackhathon2022EdgarMilianKevinromero
{
    internal class TextJustifier
    {
        private List<string> dataIn { get; set; }
        private List<string> dataOut { get; set; }
        private int lengthLine { get; set; }

        private string result { get; set; }

        public TextJustifier()
        {
            this.dataOut = new List<string>();
        }

        public string Justifier(string[] dataIn, int lengthLine)
        {
            this.dataIn = dataIn.ToList();
            this.lengthLine = lengthLine;

            if (PrepData())
            {
                foreach (string word in dataOut)
                {
                    result = result + AddSpaces(word);
                }
                return result;
                
            }
            return "Ocurrio un error";
        }

        private string AddSpaces(string line)
        {
            var tempLine = line;
            return result = tempLine + "\n";
        }
        private bool PrepData()
        {
            string line = "";
            try
            {
                foreach (var word in dataIn)
                {
                   
                    if (line.Length + word.Length + 1 < lengthLine)
                    {
                        line = line + word + " ";
                    }
                    else
                    {
                        dataOut.Add(line);
                        line = word + " ";
                    }
                }
                dataOut.Add(line);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        

    }
}
