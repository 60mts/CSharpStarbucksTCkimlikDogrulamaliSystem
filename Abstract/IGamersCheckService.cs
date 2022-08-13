using GamerSystemProject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Abstract
{
     interface IGamersCheckService 
    {
        bool CheckIfRealPerson(Gamers gamer);
    }
}
