using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
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
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal _departmanDal;

        public DepartmanManager(IDepartmanDal departmanDal)
        {
            _departmanDal = departmanDal;
        }

        public IResult Add(Departman departman)
        {
            IResult result = BusinessRules.Run(CheckIfTelephone(departman.Telephone));
            if (result != null)
            {
                return result;
            }
            _departmanDal.Add(departman);
            return new SuccessResult(Messages.DepartmanAdded);
        }

        public IResult Delete(Departman departman)
        {
            _departmanDal.Delete(departman);
            return new SuccessResult(Messages.DepartmanDeleted);
        }

        public IDataResult<List<Departman>> GetAll()
        {
            return new SuccessDataResult<List<Departman>>(_departmanDal.GetAll());
        }
        private IResult CheckIfTelephone(Int64 telephone)
        {
            var result = _departmanDal.GetAll(x => x.Telephone == telephone).Any();
            if (result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
