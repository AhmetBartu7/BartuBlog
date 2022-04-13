using Core.Results.Abstract;
using Entities.DtoTable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IAccountsManager
    {
       public Task<IDataResult<IList<DtoMyAccountsList>>> GetAllAsync();
       public Task<IDataResult<DtoMyAccountsList>> GetByIdAsync(int Id);

        public Task<IResult> AddAsync(DtoMyAccounts data);

        public Task<IResult> UpdateAsync(DtoMyAccounts data);
        public Task<IResult> DeleteAsync(int Id);



    }
}
