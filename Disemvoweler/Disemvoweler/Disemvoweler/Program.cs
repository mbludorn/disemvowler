using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the funtion
            Disemvoweler("TWO DRUMS AND A CYMBAL FALL OFF A CLIFF");

            Console.ReadKey();
        }

        static void Disemvoweler(string input)
        {
            string vowels = string.Empty;
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                //check if the letter is a vowel or not
                string letter = input[i].ToString();
                if ("AEIOU".Contains(letter))

                    vowels = vowels + letter;

                else if (" ".Contains(letter))
                {
                    continue;
                }
                else
                    {
                    output = output + letter;
                    }
                }
            Console.WriteLine(output);
            Console.WriteLine(vowels);
            }
        }
    }
