﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class VowelsConsonants
    {
        public static void vowelsConsonants()
        {
            Console.WriteLine("INPUT ANY ALPHABETIC LETTER :");
            
            char alphabet;
            alphabet = Convert.ToChar(Console.ReadLine());

            //VOWELS are "a e i o u" others are CONSONANTS

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'e':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'i':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'o':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                case 'u':
                    Console.WriteLine("THIS ALPHABET IS A VOWEL");
                    break;
                default:
                    Console.WriteLine("GIVEN ALPHABETIC LETTER IS A CONSONANT");
                    break;
                    Console.ReadKey();
            }
        }
    }
}