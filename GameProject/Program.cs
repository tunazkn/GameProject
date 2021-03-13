using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthOfYear = 1996,
                FirstName = "TUNA",
                LastName = "ÖZKAN",
                IdentityNumber = 01010101010
            });
            Console.WriteLine("Hello World! :)");
        }
    }
}
