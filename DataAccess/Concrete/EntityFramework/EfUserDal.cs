using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EntityRepositoryBase<User, UniversityContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (UniversityContext context = new UniversityContext())
            {
                var result = from operationClaims in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                           on operationClaims.Id equals userOperationClaims.OperationClaimId
                             join
                            users in context.Users on
                          userOperationClaims.UserId equals users.Id
                             select new OperationClaim
                             {
                                 Id = operationClaims.Id,
                                 Name = operationClaims.Name
                             };
                return result.ToList();
            }
        }
    }
}
