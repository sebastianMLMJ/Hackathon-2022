using System;
using System.Linq;

namespace Hackhathon2022EdgarMilianKevinromero
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            bool terminarPrograma = false;
            string opcion = "";
            Programas programas = new Programas();
            while (terminarPrograma == false)
            {

                Console.WriteLine("Ingrese el numero del problema a resolver de lo contrario se cerrara el programa");
                Console.WriteLine("1. Primer Problema");
                Console.WriteLine("3. Tercer Problema");
                Console.WriteLine("4. Cuarto Problema");

               
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese dos cadenas");
                        string p1c = Console.ReadLine();
                        string p1c2 = Console.ReadLine();
                        programas.Problema1(p1c, p1c2);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese dos cadenas");
                        string p3c = Console.ReadLine();
                        string p3c2 = Console.ReadLine();
                        programas.Problema3(p3c, p3c2);
                        break;
                    case "4":
                        Console.WriteLine("Ingrese tres numeros, primero el total, luego dos que deben sumar el valor del primer numero");
                        string p4c = Console.ReadLine();
                        string p4c2 = Console.ReadLine();
                        string p4c3 = Console.ReadLine();
                        programas.Problema4(p4c, p4c2, p4c3);
                        break;
                    default:
                        terminarPrograma = true;
                        break;
                }

            };


            //programas.Problema1("Hola", "oaHl");

            //programas.problema4("10", "5", "5");


=======
            TextJustifier text = new TextJustifier();
            var test = "Hola fulanito como estas hoy";
            var send = test.Split(' ');
            Console.WriteLine(text.Justifier(send,16));
            Console.ReadLine();
>>>>>>> Stashed changes
        }
    }
}
