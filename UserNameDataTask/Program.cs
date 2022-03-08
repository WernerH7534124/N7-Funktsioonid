using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja eesnime
            //Programm küsib kasutajalt numbri 1-3;
            //Kui kasutaja sisestab '1', siis kuvatakse eesnimi tagurpidi
            //Kui kasutaja sisestab '2', siis kuvatakse eesnime esimene täht
            //Kui kasutaja sisestab '3', siis kuvatakse eesnime pikkus

            Console.WriteLine("Sisestage oma eesnimi: ");
            string userName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Valik 1 kuvab eesnime tagurpidi ");
            Console.WriteLine("Valik 2 kuvab eesnime esimese tähe ");
            Console.WriteLine("Valik 3 kuvab eesnime pikkuse ");
            Console.WriteLine(" ");
            Console.WriteLine("Sisestage oma valik('1', '2', või '3'): ");
            char userChoice = Convert.ToChar(Console.ReadLine());

            switch (userChoice)
            {
                case '1':
                    Backwards(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    NameLenght(userName);
                    break;               
                default:
                    Console.WriteLine("Ole tähelepanelikum! - Kena päeva!");
                    break;
            }

            static void Backwards(string userName)
            {
                for (int i = userName.Length - 1; i >= 0; i--)
                {
                    Console.Write(userName[i]);
                }
            }
            static void FirstLetter(string userName)
            {
                Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}!");
            }

            static void NameLenght(string userName)
            {
                Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk!");
            }
        }
}
}
