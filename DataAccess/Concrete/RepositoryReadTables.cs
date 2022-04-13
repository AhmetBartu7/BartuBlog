using Core.Concrete;
using DataAccess.Abstract;
using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class RepositoryReadTables : BaseRepository<ReadTables>,IRepositoryReadTables
    {
        public RepositoryReadTables(DbContext context):base (context)
        {

        }
    }
}
 