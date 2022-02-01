using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny 
{
    public class WriteJokeService : IWriteJoke
    {
        public void WriteJokeToConsole(string jokeText)
        {
            Console.WriteLine(jokeText);
        }
    }
}
