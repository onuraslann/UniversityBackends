using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public  class Student:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string StudentNo { get; set; }
        public int DepartmanId { get; set; }
        public int Age { get; set; }
    
    }
}
