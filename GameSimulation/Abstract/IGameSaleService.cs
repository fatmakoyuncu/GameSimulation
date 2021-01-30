using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    interface IGameSaleService
    {
        void Buy(GameSale gameSale, Gamer gamer);
    }
}
