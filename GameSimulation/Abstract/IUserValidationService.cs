using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
