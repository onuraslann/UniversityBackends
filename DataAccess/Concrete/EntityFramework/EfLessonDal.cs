using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLessonDal : EntityRepositoryBase<Lesson, UniversityContext>, ILessonDal
    {
        public List<LessonDtoDetails> GetByDtos()
        {
            using (UniversityContext context = new UniversityContext())
            {
                var result = from lecturer in context.Lecturers
                             join lesson in context.Lessons
                         on lecturer.Id equals lesson.LecturerId
                             join student in context.Students
                             on lesson.StudentId equals student.Id
                             select new LessonDtoDetails
                             {

                                 LessonName = lesson.LessonName,
                                 Credit = lesson.Credit,
                                 LecturerEmail = lecturer.Email,
                                 LecturerFirstName = lecturer.FirstName,
                                 StudentFirstName = student.FirstName,
                                 StudentNo = student.StudentNo


                             };
                return result.ToList();
            }
        }
    }
}
