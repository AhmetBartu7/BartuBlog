using Core.Results.Abstract;
using Entities.DtoTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBlogsManager
    {
        public Task<IDataResult<IList<DtoBlogsSingle>>> GetAllAsync();
        public Task<IDataResult<DtoBlogsSingle>> GetByIdAsync(int Id);
        public Task<IDataResult<DtoBlogsMulti>> GetByIdMultiAsync(int Id);

        public Task<IResult> AddAsync(DtoBlogs data);

        public Task<IResult> UpdateAsync(DtoBlogs data);
        public Task<IResult> DeleteAsync(int Id);
    }
}
