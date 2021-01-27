using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CustomerManager:IEntityService
    {
        ValidateService _validateServices;

        public CustomerManager(Customer customer,ValidateService validateServices)
        {
            
            _validateServices = validateServices;
        }

        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name +" eklendi");
        }
        public void Update(IEntity entity)
        {
            Console.WriteLine("güncellendi");
        }
        public void Delete(IEntity entity)
        {
            Console.WriteLine("silindi");
        }
    }
}
