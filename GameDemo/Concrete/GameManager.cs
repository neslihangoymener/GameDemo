using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IEntityService
    { 
        public GameManager(Game game)
        {

        }
    
        public void Add(IEntity game)
        {
            Console.WriteLine("alındı : " + game.Name);
        }
        public void Update(IEntity game)
        {
            Console.WriteLine("güncellendi");
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine("silindi");
        }
    }
}
