using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class SalesManager:ISalesService
    {
        public SalesManager(Game game)
        {
        }
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " indirim yapıldı.");
        }
        
    }
}
