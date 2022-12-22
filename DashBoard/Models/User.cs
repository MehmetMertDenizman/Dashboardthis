using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DashBoard.Models
{
    public class User : BaseEntity
    {
        //[DisplayName("Name"),DataType(DataType.Text)]
        //public string? Name { get; set; }
        //[DisplayName("Surname"),DataType(DataType.Text)]
        //public string? Surname { get; set; }
        //[ DataType(DataType.Password),DisplayName("Password")]
        //public string? Password { get; set; }
        //[DisplayName("Email"),DataType(DataType.EmailAddress)]
        //public string? Email { get; set; }
        //[DisplayName("Dogum Tarihi"), DataType(DataType.DateTime)]
        //public DateTime BirthDate{ get; set; }


        public string? Username { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Picture { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Google { get; set; }
        public string? Linkedin { get; set; }
        public string? About { get; set; }
        public string? RegDate { get; set; }
        public string? UserToken { get; set; }
        public string? Statu { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? OwnerDesignation { get; set; }
        public string? Instagram { get; set; }
    }
}
