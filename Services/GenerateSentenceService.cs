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
        public string generateSentence(int adjectiveNumber, bool randomSentence)
        {
            // create a list of adjectives 
            List<string> adjectives = new List<string>
            {
                "Beautiful","Colorful","Exciting","Delicious","Mysterious","Elegant","Vibrant","Serene","Captivating","Enchanting","Mesmerizing","Tranquil"
            };
            // Noun (you can replace this with a list of nouns)
            string noun = "item";

            // Select random adjectives
            List<string> selectedAdjectives = new List<string>();
            if (randomSentence)
            {
                for (int i = 0; i < adjectiveNumber; i++)
                {
                    int index = random.Next(adjectives.Count);
                    selectedAdjectives.Add(adjectives[index]);
                }
            }
            else
            {
                selectedAdjectives = adjectives.Take(adjectiveNumber).ToList();
            }

            // Generate the sentence
            string adjectiveString = string.Join(", ", selectedAdjectives);
            string sentence = $"A {adjectiveString} {noun}";

            return sentence;
        }
        public void getUserInput()
        {
            int numberofSentence = 0;
            int numberofAdjectives = 0;
            Console.WriteLine("Welcome! lets generate interesting sentences");
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
