using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class ValidateService
    {
        public void Validate(Customer customer)
        {
                 Console.WriteLine(customer.Name + " " + customer.LastName + " mernis doğrulamasından geçti.");
        }
            
        
    }
}
