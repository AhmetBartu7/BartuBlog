using Core.Entities;
using System;

namespace Entities.DtoTable
{
    public class DtoBlogsSingle : IDto
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string Images { get; set; }
        public string Explanation { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
