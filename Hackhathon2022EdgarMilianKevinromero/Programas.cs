using System;
using System.Collections.Generic;
using System.Text;

namespace Hackhathon2022EdgarMilianKevinromero
{
    internal class Programas
    {
        public bool Problema1 (string cadenaOriginal, string cadenaComparar)
        {

            char [] caracteres = cadenaOriginal.ToCharArray();
            char [] caracteres2 = cadenaComparar.ToCharArray();
            int cantCoincidencias = 0;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (cadenaComparar.Contains(caracteres[i]))
                {
                    cantCoincidencias++;
                }
            }

            if (cantCoincidencias==caracteres.Length && caracteres.Length==caracteres2.Length)
            {
                Console.WriteLine("Verdadero");
                return true;
            }
            else
            {
                Console.WriteLine("Falso");
                return false;
            }

        }
    }
}
