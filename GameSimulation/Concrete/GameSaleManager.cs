using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Buy(GameSale gameSale, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + gameSale.GameName + " " + "oyununu" + gameSale.GamePrice + " " + "TL' ye satın almıştır.");
        }
    }
}
