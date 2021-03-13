using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthOfYear==1996 && gamer.FirstName == "TUNA" && gamer.LastName == "ÖZKAN" 
                && gamer.IdentityNumber == 01010101010)
            {
                return true;
            }
            return false;
        }
    }
}
