using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public IResult Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);
            return new SuccessResult();
        }

        public IDataResult<List<Lesson>> GetAll()
        {
            return new SuccessDataResult<List<Lesson>>(_lessonDal.GetAll(), Messages.LessonListed);
        }

        public IDataResult<List<LessonDtoDetails>> GetByDto()
        {
            return new SuccessDataResult<List<LessonDtoDetails>>(_lessonDal.GetByDtos());
        }
    }
}
