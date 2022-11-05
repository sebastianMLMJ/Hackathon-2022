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

        public string Problema4(string total, string primernumero, string segundonumero)
        {
            int totalint = Convert.ToInt32(total);
            int primernumeroint = Convert.ToInt32(primernumero);
            int segundonumeroint = Convert.ToInt32(segundonumero);
            int comprobacion = primernumeroint + segundonumeroint;
            if (totalint != comprobacion)
            {
                Console.WriteLine("Los dos numeros no suman el total");
                return "Los dos numeros no suman el total";
                
            }

            string primernumbin = Convert.ToString(primernumeroint, 2);
            string segundonnumbin = Convert.ToString(segundonumeroint, 2);

            int respuesta = 0;

            var arreglopprimernumbin = primernumbin.ToCharArray();
            var arreglosegundonumbin = segundonnumbin.ToCharArray();

            for (int i = 0; i < arreglopprimernumbin.Length; i++)
            {
                if (arreglopprimernumbin[i] == '1')
                {
                    respuesta++;
                }
            }
            for (int i = 0; i < arreglosegundonumbin.Length; i++)
            {
                if (arreglosegundonumbin[i] == '1')
                {
                    respuesta++;
                }
            }

            Console.WriteLine(Convert.ToString(respuesta) + " avellanas");

            return Convert.ToString(respuesta) + " avellanas";

        }
    }
}
