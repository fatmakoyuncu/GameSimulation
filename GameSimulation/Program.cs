using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "FATMA", LastName = "KOYUNCU", BirthYear = 1997, IdentityNumber = 54321 });

            GameCompanyManager gameCompanyManager = new GameCompanyManager();
            gameCompanyManager.Add(new GameCompany { Id = 1, CompanyName = "Yaz İndirimi", CompanyDetails = "sepette %20 indirim" });

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Buy(new GameSale { Id = 1, GameName = "PUBG", GamePrice = 150 }, new Gamer {FirstName = "Ali", LastName = "Kaya" });




            Console.ReadLine();
        }
    }
}
