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

        //include both IJoke and IWriteJoke as dependencies for Jester through the constructor 
        public Jester(IJoke joke, IWriteJoke writeJoke)
        {
            //Check both objects for null
            // is null
            // ?? null coalecencing operator
            if (joke == null)
            {
                throw new ArgumentNullException(nameof(Jester));
            }

            if (writeJoke == null)
            {
                throw new ArgumentNullException(nameof(Jester));
            }
            
            Joke = joke;
            WriteJoke = writeJoke;
            
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
