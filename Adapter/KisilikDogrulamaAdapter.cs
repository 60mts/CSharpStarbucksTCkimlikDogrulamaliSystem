using GamerSystemProject.Abstract;
using GamerSystemProject.Entities;

using MernisServiceReference;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Adapter
{
    internal class KisilikDogrulamaAdapter : IGamersCheckService
    {
        bool IGamersCheckService.CheckIfRealPerson(Gamers gamer)
        {
            return true;
        }
    }
}
