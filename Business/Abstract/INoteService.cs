using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface INoteService
    {
        IDataResult<List<Note>> GetAll();
        IResult Add(Note note);
        IResult Update(Note note);
       
          
    }
}
