using Core.Results.Abstract;
using Core.Results.ComplexType;
using Core.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.ContextConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private RepositoryBlogComments RepoBlogComments ;

        private RepositoryBlogs RepoBlogs ;

        private RepositoryMyAccounts RepoMyAccounts ;

        private RepositoryReadTables RepoReadTables ;
        private readonly BlogContext context;
        public UnitOfWorks(BlogContext _context)
        {
            context = _context;
        }


        public IRepositoryBlogComments RepositoryBlogComments => RepoBlogComments ?? new RepositoryBlogComments(context);

        public IRepositoryBlogs RepositoryBlogs => RepoBlogs ?? new RepositoryBlogs(context);

        public IRepositoryMyAccounts RepositoryMyAccounts => RepoMyAccounts ?? new RepositoryMyAccounts(context);

        public IRepositoryReadTables RepositoryReadTables => RepoReadTables ?? new RepositoryReadTables(context); 

       
        // TEK BİR YERDEN HATA KONTROLÜ YAPMA
        // Aspect Oriented Programming(AOP)
        // Cache, Hata Kontrolü gibi Yapıların Tek Bir Yerden Olmasını Benimseyten Yaklaşım


        public async Task<IResult> SaveChanges()
        {
            using (context.Database.BeginTransaction())
            {
                try
                {
                  await context.SaveChangesAsync().ContinueWith(x=> context.Database.CommitTransaction());
                    return new Result(ResultStatus.Success, "İşlem Başarılı");
                }
                catch (Exception)
                {

                    context.Database.RollbackTransaction();
                    return new Result(ResultStatus.Success, "İşlem Başarısız");
                }
            }
        }
    }
}
