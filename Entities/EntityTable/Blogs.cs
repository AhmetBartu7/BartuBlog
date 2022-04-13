using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.EntityTable
{
    public class Blogs : BasePrimary, IEntity
    {
        public string BlogName { get; set; }
        public string Images { get; set; }
        public string Explanation { get; set; }
        public DateTime RelaseDate { get; set; }
        public ICollection<ReadTables>ReadTables { get; set; }
        public ICollection<BlogComments> BlogComments { get; set; }


    }
}
