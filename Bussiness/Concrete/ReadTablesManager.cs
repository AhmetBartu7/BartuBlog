using AutoMapper;
using Bussiness.Abstract;
using Core.Results.Abstract;
using Core.Results.ComplexType;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.DtoTable;
using Entities.EntityTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    class ReadTablesManager : IReadTablesManager
    {
        private readonly IUnitOfWorks work;
        private readonly IMapper mapper;

        public ReadTablesManager(IUnitOfWorks _work, IMapper _mapper)
        {
            work = _work;
            mapper = _mapper;
        }

        public async Task<IResult> AddAsync(DtoReadTables data)
        {
            return await work.RepositoryReadTables.Add(mapper.Map<ReadTables>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IResult> DeleteAsync(int Id)
        {
            return await work.RepositoryReadTables.Delete(x => x.ID == Id).ContinueWith(x => work.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoReadTablesList>>> GetAllAsync()
        {
            var BulunanData = mapper.Map<IList<DtoReadTablesList>>(await work.RepositoryReadTables.GetAll());
            return new DataResult<IList<DtoReadTablesList>>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IDataResult<DtoReadTablesList>> GetByIdAsync(int Id)
        {
            var BulunanData = mapper.Map<DtoReadTablesList>(await work.RepositoryReadTables.GetByFirst(x => x.ID == Id));
            return new DataResult<DtoReadTablesList>(BulunanData, ResultStatus.Success, "");
        }

        public async Task<IResult> UpdateAsync(DtoReadTables data)
        {
            return await work.RepositoryReadTables.Update(mapper.Map<ReadTables>(data)).ContinueWith(x => work.SaveChanges()).Result;
        }
    }
}
