using GamerSystemProject.Abstract;
using GamerSystemProject.Adapter;
using GamerSystemProject.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemProject.Concrete
{
     class GamersManager:BaseGamersManager
    {
        private KisilikDogrulamaAdapter kisilikDogrulamaAdapter;

        public GamersManager(KisilikDogrulamaAdapter kisilikDogrulamaAdapter)
        {
            this.kisilikDogrulamaAdapter = kisilikDogrulamaAdapter;
        }

        public void Save(Gamers gamers)
        {
            Console.WriteLine("Saved to db");
        }

    }
}
