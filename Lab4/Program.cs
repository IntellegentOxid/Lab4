using System;

using System.Linq;



class Program
{

    static void Main(string[] args)
    {

        // введення трьох слів 

        Console.Write("Введіть перше слово: ");

        string word1 = Console.ReadLine().ToLower();

        Console.Write("Введіть друге слово: ");

        string word2 = Console.ReadLine().ToLower();

        Console.Write("Введіть третє слово: ");

        string word3 = Console.ReadLine().ToLower();



        // обчислення літер, які зустрічаються у всіх словах лише один раз 

        var uniqueLetters = word1

            .Intersect(word2)

            .Intersect(word3)

            .Where(c => word1.Count(x => x == c) == 1

                     && word2.Count(x => x == c) == 1

                     && word3.Count(x => x == c) == 1);



        // виведення результату 

        Console.WriteLine("Літери, які зустрічаються у всіх словах лише один раз:");

        foreach (var c in uniqueLetters)
        {

            Console.Write(c + " ");

        }

    }

}

