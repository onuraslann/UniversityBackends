using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Lesson:IEntity
    {
        public int Id { get; set; }

        public string LessonName { get; set; }
        public int StudentId { get; set; }

        public int Credit { get; set; }
        public int LecturerId { get; set; }
    }
}
