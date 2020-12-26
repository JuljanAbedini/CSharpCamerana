using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
        scrivere un programma che:
        -chieda 3 stringhe all'utente
        -verifichi se le tre stringhe terminano con la stessa lettera
        - in caso positivo:
          - stampi su schermo "Eureka"
        -in caso negativo:
          -chieda all'utente una quarta stringa
          - stampi su schermo la somma delle lunghezze della 4 stringa

        */

        static void Main(string[] args)

        {

            Console.WriteLine("Inserisci stringa uno");
            Console.ReadLine();
            Console.WriteLine("Inserisci stringa due");
            Console.ReadLine();
            Console.WriteLine("Inserisci stringa tre");
            Console.ReadLine();



            Console.ReadKey();

        }













        /*
         srivere un programma che:
        - generi un numero casuale
        - stampi sullo schermo il numero
        - chieda all'utente un secondo numero intero
        - stampi su schermo la defferenza  tra il primo numero e il secondo

       
        static void Main(string[] args)

        {
            Random random = new Random();
            int num1 = random.Next();
            Console.WriteLine(num1);

            Console.WriteLine("inserisci un numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 - num2);
            

            Console.ReadKey();
        }
       
        */




        /*
          scrivere un programma che:
              - dai 4 nr interi (Non chiesti all'utente)
              - stampi su schermo la media dei 4 nr (decimal)
              - stampi il maggiore tra il primo e il quarto numero
        - chieda al utente una stringa qualsiasi e:
        - stampi la somma tra la lunghezza della stringa e il primo nr 



          static void Main(string[] args)
          {
              int num1 = 7;
              int num2 = 3;
              int num3 = 7;
              int num4 = 4;

              decimal media = Convert.ToDecimal((num1 + num2 + num3 + num4)) / 4;




              Console.WriteLine(media);

              if (num1 > num4)
                  Console.WriteLine(num1);
              else if (num4 > num1)
                  Console.WriteLine(num4);

              Console.WriteLine("Inserisci una stringa qualsiasi");
              string input = Console.ReadLine();
              int lunghezza = input.Length;
              int somma = lunghezza + num1;
              Console.WriteLine(input.Length + num1 );


        */


        //termine: 19:30
        /*
         Scrivere un programma che:
            - Chieda all'utente due numeri (solo interi)
            - Stampi su schermo la somma tra i due numeri
            - Stampi su schermo la data corrente (formato indifferente)
            - Stampi su schermo la data ottenuta tramite la somma 
            tra i giorni della data corrente e il primo numero
                es: - 10/05/1988 + 5 = 15/05/1988



        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Somma: " + (numero1 + numero2));

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Data corrente: " + currentDate);

            Console.WriteLine("Data corrente + " + numero1 + " giorni: " + currentDate.AddDays(numero1));
        }





  }
  */

    }
}
