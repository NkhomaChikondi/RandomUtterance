using RandomUtterance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUtterance.Services
{
    public class GenerateSentenceService : IGenerateSentence
    {
        public void getUserInput()
        {
            int adjectiveNumber = 0, sentenceNumber = 0;

            // handle all user input
            Console.Write("Welcome! please enter the number of adjectives for your generated sentence: ");
            try
            {
                adjectiveNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: You have not specified a number");
                return;
            }
           

            Console.Write("Please enter the number of sentences you want to be generate: ");            
            try
            {
                sentenceNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: You have not specified a number");
                return;
            }


            Console.Write("Do you want the sentence to be generated randomly? (yes/no): ");
            bool useRandom = Console.ReadLine().ToLower() == "yes";

            // get the time that has ellapsed since the application started running
            int seed = Environment.TickCount;

            if (!useRandom)
            {
                
                Console.Write("Specify the number of times you want the sentence to be generate: ");
                try
                {
                    seed = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Error: You have not specified a number");
                    return;
                }
              
            }
            Random random = new Random(seed);

            List<string> adjectives = new List<string>
            {
               "beautiful", "colorful", "exciting", "delicious", "mysterious","Captivating","Captivating","Exquisite"
            };
            // create an array of string containing nouns
            string[] nouns = { "flower", "painting", "adventure", "dish", "puzzle","car","application" };

            for (int i = 0; i < sentenceNumber; i++)
            {
                string sentence = GenerateSentence(adjectives, nouns, adjectiveNumber, useRandom, random);
                Console.WriteLine(sentence);
            }
        }
        public string GenerateSentence(List<string> adj, string[] nouns, int adjectiveNumber, bool useRandom, Random random)
        {
            string adjectiveString = "";
            if (useRandom)
            {
                for (int i = 0; i < adjectiveNumber; i++)
                {
                    int index = random.Next(adj.Count);
                    adjectiveString += adj[index] + (i < adjectiveNumber - 1 ? ", " : "");
                }
            }
            else
            {
                adjectiveString = string.Join(", ", adj.Take(adjectiveNumber));
            }

            string noun = nouns[random.Next(nouns.Length)];
            return $"A {adjectiveString} {noun}";
        }

        
    }
}
