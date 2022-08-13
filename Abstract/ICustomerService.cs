using GamerSystemProject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Abstract
{
     interface ICustomerService
    {
        void Save(Gamers gamers)
        {
            Console.WriteLine(gamers.FirstName + "Adlı oyuncu eklendi!");
        }
    }
}
