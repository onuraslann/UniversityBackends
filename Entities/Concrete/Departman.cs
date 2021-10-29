using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Departman:IEntity
    {
        public int Id { get; set; }
        public string DepartmanName { get; set; }

        public string Address { get; set; }
        public Int64 Telephone { get; set; }
    }
}
