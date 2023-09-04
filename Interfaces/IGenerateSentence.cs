using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUtterance.Interfaces
{
    public interface IGenerateSentence
    {
        string GenerateSentence(List<string> adj, string[] nouns, int adjectiveNumber, bool useRandom, Random random);
        void getUserInput();
    }
}
