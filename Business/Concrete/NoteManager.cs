using Business.Abstract;
using Business.Constants;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
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
    public class NoteManager : INoteService
    {
        INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        [CacheRemoveAspect("INoteService.Get")]
        public IResult Add(Note note)
        {
            _noteDal.Add(note);
            return new SuccessResult(Messages.NoteAdded);
        }
        [CacheAspect(duration: 10)]
        [PerformanceAspect(interval:5)]
        public IDataResult<List<Note>> GetAll()
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll());
        }

        
        public IResult Update(Note note)
        {
            _noteDal.Update(note);
            return new SuccessResult();
        }
    }
}
