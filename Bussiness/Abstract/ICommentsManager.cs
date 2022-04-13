using Core.Results.Abstract;
using Entities.DtoTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICommentsManager
    {
        public Task<IDataResult<IList<DtoBlogsCommentsList>>> GetAllAsync();
        public Task<IDataResult<DtoBlogsCommentsList>> GetByIdAsync(int Id);

        public Task<IResult> AddAsync(DtoBlogsComments data);

        public Task<IResult> UpdateAsync(DtoBlogsComments data);
        public Task<IResult> DeleteAsync(int Id);
    }
}
