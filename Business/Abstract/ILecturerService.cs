using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ILecturerService
    {
        IDataResult<List<Lecturer>> GetAll();
        IResult Add(Lecturer lecturer);
        IDataResult<List<Lecturer>> GetByAge(int age);
        IResult Delete(Lecturer lecturer);
    }
}
