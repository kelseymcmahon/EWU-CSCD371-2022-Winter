using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester : IJokeService, IWriteJoke
    {
        string IJokeService.GetJoke()
        {
            throw new NotImplementedException();
        }

        void IWriteJoke.WriteJoke()
        {
            throw new NotImplementedException();
        }
    }
}
