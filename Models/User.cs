using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("SURNAME")]
        public string Surname { get; set; }
        [Column("PATRTNAME")]
        public string PatrName { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("BIRTHDAY")]
        public DateTime BirthDay { get; set; }
        [Column("REGISTRATION_DATE")]
        public DateTime RegistrationDate { get; set;}
        [Column("PHONE")]
        public string Phone { get; set; }
        [Column("LOGIN")]
        public string Login { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
        [Column("ROLE")]
        public Role Role { get; set; }
    }
}
