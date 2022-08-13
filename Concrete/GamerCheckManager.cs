using GamerSystemProject.Abstract;
using GamerSystemProject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Concrete
{
    internal class GamerCheckManager:IGamersCheckService
    {
        public bool CheckIfRealPerson(Gamers gamers)
        {
            return true;
        }

        bool IGamersCheckService.CheckIfRealPerson(Gamers gamer)
        {
            return true;
        }

        public static implicit operator GamerCheckManager(GamersManager v)
        {
            throw new NotImplementedException();
        }
    }
}
