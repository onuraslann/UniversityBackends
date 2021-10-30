using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LecturerManager : ILecturerService
    {
        ILecturerDal _lecturerDal;

        public LecturerManager(ILecturerDal lecturerDal)
        {
            _lecturerDal = lecturerDal;
        }

        [ValidationAspect(typeof(LecturerValidator))]
        [SecuredOperation("admin,editor")]
        public IResult Add(Lecturer lecturer)
        {
            _lecturerDal.Add(lecturer);
            return new SuccessResult();
        }

        public IResult Delete(Lecturer lecturer)
        {
            _lecturerDal.Delete(lecturer);
            return new SuccessResult();
        }

        public IDataResult<List<Lecturer>> GetAll()
        {
            return new SuccessDataResult<List<Lecturer>>(_lecturerDal.GetAll());
        }

        public IDataResult<List<Lecturer>> GetByAge(int age)
        {
            return new SuccessDataResult<List<Lecturer>>(_lecturerDal.GetAll(x=>x.Age>age),Messages.LecturerAge);
        }
    }
}
