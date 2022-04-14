using Core.Concrete;
using DataAccess.Abstract;
using Entities.EntityTable;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class RepositoryBlogComments : BaseRepository<BlogComments>, IRepositoryBlogComments
    {
        public RepositoryBlogComments(DbContext context) : base(context)
        {

        }
    
    }
}
