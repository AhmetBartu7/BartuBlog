using Core.Results.Abstract;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnitOfWorks
    {
        public IRepositoryBlogComments RepositoryBlogComments { get; }
        public IRepositoryBlogs RepositoryBlogs { get; }
        public IRepositoryMyAccounts RepositoryMyAccounts { get; }
        public IRepositoryReadTables RepositoryReadTables { get; }
        Task<IResult> SaveChanges();
    }
}
