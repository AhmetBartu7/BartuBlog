using Core.Concrete;
using DataAccess.Abstract;
using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class RepositoryMyAccounts : BaseRepository<MyAccounts>, IRepositoryMyAccounts
    {
        public RepositoryMyAccounts(DbContext context) : base(context)
        {

        }
    
    }
}
