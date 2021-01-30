using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && gamer.FirstName == "FATMA" && gamer.LastName == "KOYUNCU" && gamer.IdentityNumber == 54321)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
