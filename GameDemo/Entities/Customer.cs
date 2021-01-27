using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    class Customer:IEntity
    {
        public int Id { get; set; }
        public string NationalityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
    }
}
