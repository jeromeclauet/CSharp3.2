using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int result;
            string response = "oui";
            while (response != "non")
            {
                Console.WriteLine("La valeur de nombre est " + number);
                Console.WriteLine("Ajoutez un nombre que vous voulez additionner :");
                int sum = int.Parse(Console.ReadLine());
                result = number + sum;
                Console.WriteLine(result);
                number = result;
                Console.WriteLine("Souhaitez vous ajouter un autre nombre à votre opération ?");
                response = Console.ReadLine();
            }
        }
    }
}
