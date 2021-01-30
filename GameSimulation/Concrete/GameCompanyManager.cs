using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    class GameCompanyManager : IGameCompanyService
    {
        public void Add(GameCompany gameCompany)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(GameCompany gameCompany)
        {
            Console.WriteLine("Kampanya güncellendi");
        }

        public void Update(GameCompany gameCompany)
        {
            Console.WriteLine("Kampanya silindi");
        }
    }
}
