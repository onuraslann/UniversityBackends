using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note:IEntity
    {
        public int Id { get; set; }

        public int LessonId { get; set; }

        public int StudentId { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public Nullable<double> Average { get; set; }

        public bool Status { get; set; }

    }
}
