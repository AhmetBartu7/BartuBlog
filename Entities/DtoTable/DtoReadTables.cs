using Core.Entities;
using System;

namespace Entities.DtoTable
{
    public class DtoReadTables : IDto
    {
        public int BlogId { get; set; }
        public int Count { get; set; }
        public DateTime ReadDate { get; set; }
        public int UserIP { get; set; }
      
    }
}
