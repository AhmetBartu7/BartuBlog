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
    public  class BlogsManager : IBlogsManager
    {
        private readonly IUnitOfWorks work;
        private readonly IMapper mapper;

        public BlogsManager(IUnitOfWorks _work, IMapper _mapper)
        {
            work = _work;
            mapper = _mapper;
        }

        public async Task<IResult> AddAsync(DtoBlogs data)
        {
            return await work.RepositoryBlogs.Add(mapper.Map<Blogs>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IResult> DeleteAsync(int Id)
        {
            return await work.RepositoryBlogs.Delete(x => x.ID == Id).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoBlogsSingle>>> GetAllAsync()
        {
            var BulunanData = mapper.Map<IList<DtoBlogsSingle>>(await work.RepositoryBlogs.GetAll());
            return new DataResult<IList<DtoBlogsSingle>>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IDataResult<DtoBlogsSingle>> GetByIdAsync(int Id)
        {
            var BulunanData = mapper.Map<DtoBlogsSingle>(await work.RepositoryBlogs.GetByFirst(x => x.ID == Id));
            return new DataResult<DtoBlogsSingle>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IDataResult<DtoBlogsMulti>> GetByIdMultiAsync(int Id)
        {
            var BulunanData = mapper.Map<DtoBlogsMulti>(await work.RepositoryBlogs.GetAll(x => x.ID == Id, i => i.ReadTables, e => e.BlogComments));
            return new DataResult<DtoBlogsMulti>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IResult> UpdateAsync(DtoBlogs data)
        {
            return await work.RepositoryBlogs.Update(mapper.Map<Blogs>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }
    }
}
