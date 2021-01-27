using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IEntityService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
