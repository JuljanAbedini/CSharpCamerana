using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTDPC12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserisci il primo numero");
                string number1AsString = Console.ReadLine();
                decimal number1AsDecimal = decimal.Parse(number1AsString);

                Console.WriteLine("Inserisci il secondo numero");
                string number2AsString = Console.ReadLine();
                decimal number2AsDecimal = decimal.Parse(number2AsString);

                decimal addizione = number1AsDecimal + number2AsDecimal;
                decimal sottrazione = number1AsDecimal - number2AsDecimal;
                decimal moltiplicazione = number1AsDecimal * number2AsDecimal;

                Console.WriteLine(number1AsString + " + " + number2AsString + " = " + addizione);
                Console.WriteLine(number1AsString + " - " + number2AsString + " = " + sottrazione);
                Console.WriteLine(number1AsString + " * " + number2AsString + " = " + moltiplicazione);
                if (number2AsDecimal != 0)
                {
                    decimal divisione = number1AsDecimal / number2AsDecimal;
                    Console.WriteLine(number1AsString + " / " + number2AsString + " = " + divisione);
                }
            }
            catch
            {
                Console.WriteLine("Puoi inserire solo numeri");
            }
            Console.ReadKey();
        }
    }
}

                /* int y = int.Parse(stringa);
                 Console.WriteLine(y - 1);


                 int z = int.Parse(stringa);
                 Console.WriteLine(z * 1);


                 int w = int.Parse(stringa);

                    Console.WriteLine(w / 1);*/
