﻿using System;

namespace UsernameData
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutaja eesnime
            //Programm kuvab kasutaja eesnime pikkust
            //Programm kuvab kasutaja eesnime esimest tähte
            //Programm kuvab kasutaja eesnime tagurpidi
            //Main meetodis ei tohi olla rohkem, kui 3 rida koodi


            Console.WriteLine("Sisestage oma eesnimi: ");
            string userName = Console.ReadLine();
            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk!");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}!");

            for(int i = userInput.Length -1; i>=0; i--)
            {
                Console.Write(userInput[i]);

            }

        }


    }
}