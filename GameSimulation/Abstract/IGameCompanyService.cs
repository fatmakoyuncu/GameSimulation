using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    interface IGameCompanyService
    {
        void Add(GameCompany gameCompany);

        void Update(GameCompany gameCompany);

        void Delete(GameCompany gameCompany);

    }
}
