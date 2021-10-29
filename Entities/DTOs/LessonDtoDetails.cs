using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class LessonDtoDetails: IDto
    {
        public string LessonName { get; set; }
        public int Credit { get; set; }
        public string StudentNo { get; set; }
        public string StudentFirstName { get; set; }
        public string LecturerFirstName { get; set; }
        public string LecturerEmail { get; set; }
    }
}
