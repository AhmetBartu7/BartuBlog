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
    public class MyAccountsManager : IAccountsManager

    {
        private readonly IUnitOfWorks work;
        private readonly IMapper mapper;
        
        public MyAccountsManager(IUnitOfWorks _work, IMapper _mapper)
        {
            work = _work;
            mapper = _mapper;
        }

        public async Task<IResult> AddAsync(DtoMyAccounts data)
        {

           return await work.RepositoryMyAccounts.Add(mapper.Map<MyAccounts>(data)).ContinueWith(x => work.SaveChanges()).Result;

        }

        public async Task<IResult> DeleteAsync(int Id)
        {
            return await work.RepositoryMyAccounts.Delete(x=> x.ID == Id).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoMyAccountsList>>> GetAllAsync()
        {
            var BulunanData = mapper.Map<IList<DtoMyAccountsList>>(await work.RepositoryMyAccounts.GetAll());
            return new DataResult<IList<DtoMyAccountsList>>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IDataResult<DtoMyAccountsList>> GetByIdAsync(int Id)
        {
            var BulunanData = mapper.Map<DtoMyAccountsList>(await work.RepositoryMyAccounts.GetByFirst(x => x.ID == Id));
            return new DataResult<DtoMyAccountsList>(BulunanData, ResultStatus.Success, "");
         
        }

        public async Task<IResult> UpdateAsync(DtoMyAccounts data)
        {
            return await work.RepositoryMyAccounts.Update(mapper.Map<MyAccounts>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }
    }
}
