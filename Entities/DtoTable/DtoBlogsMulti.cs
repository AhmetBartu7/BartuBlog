using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.DtoTable
{
    public class DtoBlogsMulti : IDto
    {
        public string BlogName { get; set; }
        public string Images { get; set; }
        public string Explanation { get; set; }
        public DateTime RelaseDate { get; set; }
        public ICollection<DtoReadTablesList> DtoReadTablesList { get; set; }
        public ICollection<DtoBlogsCommentsList> DtoBlogsCommentsList { get; set; }
    }
}

