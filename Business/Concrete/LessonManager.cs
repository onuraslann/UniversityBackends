using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Business;
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

        [ValidationAspect(typeof(LessonValidator))]
        public IResult Add(Lesson lesson)
        {
            IResult result = BusinessRules.Run(CheckIfLessonNameExist(lesson.LessonName), CheckIfStudentId(lesson.StudentId));
            if (result != null)
            {
                return result;
            }
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
        private IResult CheckIfLessonNameExist(string lessonName)
        {
            var result = _lessonDal.GetAll(x => x.LessonName == lessonName).Any();
            if (result)
            {
                return new ErrorResult();

            }
            return new SuccessResult();
        }
     private IResult CheckIfStudentId(int studentId)
        {
            var result = _lessonDal.GetAll(x => x.StudentId == studentId).Count;
            if (result > 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
