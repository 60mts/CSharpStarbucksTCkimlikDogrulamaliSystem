using GamerSystemProject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Abstract
{
    internal class BaseGamersManager:ICustomerService
    {
        public void Save(Gamers gamers)
        {
           
            Console.WriteLine("Save to db");
        }
    }
}
