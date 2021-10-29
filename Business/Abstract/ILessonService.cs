using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILessonService
    {
        IDataResult<List<Lesson>> GetAll();

        IDataResult<List<LessonDtoDetails>> GetByDto();

        IResult Add(Lesson lesson);

    }
}
