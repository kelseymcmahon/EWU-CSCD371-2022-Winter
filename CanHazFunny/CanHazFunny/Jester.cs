using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester
    {
        IJoke Joke;
        IWriteJoke WriteJoke;

        public Jester(IJoke? joke, IWriteJoke? writeJoke)
        {   
            Joke = joke ?? throw new ArgumentNullException(nameof(Jester));
            WriteJoke = writeJoke ?? throw new ArgumentNullException(nameof(Jester));
        }

        public void TellJoke()
        {
            string jokeText = Joke.GetJoke();

            while (jokeText.Contains("Chuck Norris"))
            {
                jokeText = Joke.GetJoke();
            }

            WriteJoke?.WriteJokeToConsole(jokeText);
        }
    }
}
