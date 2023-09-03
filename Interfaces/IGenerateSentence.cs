using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUtterance.Interfaces
{
    public interface IGenerateSentence
    {
        string generateSentence(int adjectiveNumber, bool randomSentence);
        void getUserInput();
    }
}
