﻿using System;

namespace File_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your language :");
            Console.WriteLine("ENG\nRUS\nAZE\n");
            string language = Console.ReadLine();
            switch (language)
            {
                case "ENG":
                    Console.WriteLine("Enter your file name :");
                    break;
                case "RUS":
                    Console.WriteLine("Введите имя файла :");
                    break;
                case "AZE":
                    Console.WriteLine("Fayl adını daxil edin :");
                    break;
                default:
                    Console.WriteLine("Enter your file name :");
                    break;

            }
        }
    }
}