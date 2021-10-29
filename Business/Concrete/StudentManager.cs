using Business.Abstract;
using Business.Constants;
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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }
    }
}
