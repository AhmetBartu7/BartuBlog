using Core.Concrete;
using DataAccess.Abstract;
using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class RepositoryBlogs : BaseRepository<Blogs>, IRepositoryBlogs
    {
        public RepositoryBlogs(DbContext context) : base(context)
        {

        }
    
    }
}
