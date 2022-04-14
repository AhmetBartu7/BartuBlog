using Core.Entities;
using System;

namespace Entities.EntityTable
{
    public class ReadTables: BasePrimary,IEntity
    {
        public int BlogId { get; set; }
        public int Count { get; set; }
        public DateTime ReadDate { get; set; }
        public int UserIP { get; set; }
        public Blogs Blogs { get; set; }
    }
}
