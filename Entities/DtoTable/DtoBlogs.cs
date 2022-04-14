using Core.Entities;
using System;

namespace Entities.DtoTable
{
    public class DtoBlogs : IDto
    {
        public string BlogName { get; set; }
        public string Images { get; set; }
        public string Explanation { get; set; }
        public DateTime RelaseDate { get; set; }
    }
}
