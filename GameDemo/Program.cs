using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityService customerManager = new CustomerManager(new Customer() , new ValidateService());

            Customer customer1 = new Customer(){Id = 1,NationalityNumber = "1111111111",Name = "Engin",LastName = "Demiroğ",YearOfBirth = 1985};

            Customer customer2 = new Customer(){Id = 2,NationalityNumber = "2222222222",Name = "Neslihan",LastName = "Göymener",YearOfBirth = 1979};

            customerManager.Add(customer1);
            customerManager.Add(customer2);


            IEntityService gameManager = new GameManager(new Game());
            IEntity game1 = new Game() { Id = 1, Name = "game1", UnitPrice = 1000};
            IEntity game2 = new Game() { Id = 2, Name = "game2", UnitPrice = 2000 };
            
            
            gameManager.Add(game1);
            gameManager.Add(game2);


            ISalesService indirim = new SalesManager(new Game());
            indirim.Discount(game1);

            Console.ReadLine();
        }
    }
}
