using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IDepartmanService
    {
        IDataResult<List<Departman>> GetAll();
        IResult Add(Departman departman);
        IResult Delete(Departman departman);
    }
}
