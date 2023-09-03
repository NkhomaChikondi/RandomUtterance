using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using RandomUtterance.Interfaces;
using RandomUtterance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUtterance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // register dependencies
            var serviceProvider = new ServiceCollection().AddSingleton<IGenerateSentence, GenerateSentenceService>().BuildServiceProvider();
            
            // Resolve dependencies
            var generateSentence = serviceProvider.GetRequiredService<IGenerateSentence>();
            // get user input and generate sentences
            generateSentence.getUserInput();
            
        }
    }
}
