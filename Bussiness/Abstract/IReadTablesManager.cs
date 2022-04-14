using Core.Results.Abstract;
using Entities.DtoTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IReadTablesManager
    {
        public Task<IDataResult<IList<DtoReadTablesList>>> GetAllAsync();
        public Task<IDataResult<DtoReadTablesList>> GetByIdAsync(int Id);

        public Task<IResult> AddAsync(DtoReadTables data);

        public Task<IResult> UpdateAsync(DtoReadTables data);
        public Task<IResult> DeleteAsync(int Id);
    }
}
