using AutoMapper;
using Bussiness.Abstract;
using Core.Results.Abstract;
using Core.Results.ComplexType;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.DtoTable;
using Entities.EntityTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CommentsManager : ICommentsManager
    {
        private readonly IUnitOfWorks work;
        private readonly IMapper mapper;

        public CommentsManager(IUnitOfWorks _work, IMapper _mapper)
        {
            work = _work;
            mapper = _mapper;
        }

        public async Task<IResult> AddAsync(DtoBlogsComments data)
        {
            return await work.RepositoryBlogComments.Add(mapper.Map<BlogComments>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IResult> DeleteAsync(int Id)
        {
            return await work.RepositoryBlogComments.Delete(x => x.ID == Id).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoBlogsCommentsList>>> GetAllAsync()
        {
            var BulunanData = mapper.Map<IList<DtoBlogsCommentsList>>(await work.RepositoryMyAccounts.GetAll());
            return new DataResult<IList<DtoBlogsCommentsList>>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IDataResult<DtoBlogsCommentsList>> GetByIdAsync(int Id)
        {
            var BulunanData = mapper.Map<DtoBlogsCommentsList>(await work.RepositoryMyAccounts.GetByFirst(x => x.ID == Id));
            return new DataResult<DtoBlogsCommentsList>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IResult> UpdateAsync(DtoBlogsComments data)
        {
            return await work.RepositoryBlogComments.Update(mapper.Map<BlogComments>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }
    }
}
