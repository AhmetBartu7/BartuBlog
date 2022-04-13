using Core.Entities;

namespace Entities.DtoTable
{
    public class DtoMyAccounts:IDto
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Images { get; set; }
        public string CoverLetter { get; set; }
        public string Information { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
