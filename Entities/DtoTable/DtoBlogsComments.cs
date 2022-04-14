using Core.Entities;
using System;

namespace Entities.DtoTable
{
    public class DtoBlogsComments : IDto
    {
        public int BlogId { get; set; }
        public string Commenter { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }
    }
}
