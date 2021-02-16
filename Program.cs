using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Esercizio_Condizioni
{
    class Program
    {
        /*
Scrivere un programma che:
- Chieda all'utente 2 stringhe
- Nel caso le due stringhe siano uguali tra di loro come contenuto:
- Stampi su schermo "Le stringhe sono uguali"
- Nel caso la prima stringa sia più lunga della seconda:
- Stampi su schermo "La prima stringa è più lunga della seconda"
- Nel caso la seconda stringa sia più lunga della prima:
- Chieda all'utente una terza stringa
- Nel caso la terza stringa sia uguale alla prima come contenuto:
- Stampi su schermo "Easter egg"
*/

        static void Main(string[] args)
        {
            string validStringaUno = "Admin";
            string validStringaDue = "Admin";

            Console.WriteLine("StringaUno");
            string StringaUno = Console.ReadLine();

            Console.WriteLine("StringaDue");
            string StringaDue = Console.ReadLine();

            if (StringaUno == validStringaUno && StringaDue == validStringaDue)

            {
                Console.WriteLine("Le stringe sono uguali");
            }
            if (StringaUno => StringaDue)
            {
                Console.WriteLine("La prima stringa e piu lunga della seconda");
            }




            /*
             * static void Main(string[] args)
                {


                /*Scrivere un programma che:
                 * chieda username e pass
                 * valuti l'esattezza dei dati immessi rispetto a due valori preimpostati
                 * in caso di esattezza:
                 * dia il benvenuto al utente
                 * in caso contrario:
                 * mostri errore
                 * 
            
            string validUsername = "Admin";
            string validPassword = "1234";

            Console.WriteLine("Username");
            string Username = Console.ReadLine();

            
            Console.WriteLine("Password");
            string Password = Console.ReadLine();

            if (Username == validUsername && Password == validPassword)
            {
                Console.WriteLine("Benvenuto Admin");
            }
            else
            {
                Console.WriteLine("Errore");
            }
            Console.ReadKey();

            */













                /*
                 *   /* 
                Scrivere un programma che:
                -Prenda in input una stringa dall'utente
                -Verifichi che la stringa comincia con la A maiuscola:
                 - in caso positivo, chieda all'tente una seconda stringa
                 - verifichi che la seconda stringa sia lunga 10 caratteri:
                 - in caso positivo scriva "10" sullo schermo 
                   */
                /*
                 * 
                 * static void Main(string[] args)
            {
                Console.WriteLine("Inserisci una stringa qualsiasi");
                string input = Console.ReadLine();
                if (input.StartsWith("A"))
                {
                    Console.WriteLine("Inserisci una seconda stringa qualsiasi");
                    input = Console.ReadLine();
                    if (input.Length == 10)
                    {
                        Console.WriteLine("10");
                    }
                }


                Console.ReadKey();
                */
        }
    }
}
