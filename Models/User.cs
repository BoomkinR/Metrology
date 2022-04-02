using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("NAME")]
        public virtual string Name { get; set; }
        [Column("SURNAME")]
        public virtual string Surname { get; set; }
        [Column("PATRTNAME")]
        public virtual string PatrName { get; set; }
        [Column("EMAIL")]
        public virtual string Email { get; set; }
        [Column("BIRTHDAY")]
        public virtual DateTime BirthDay { get; set; }
        [Column("REGISTRATION_DATE")]
        public virtual DateTime RegistrationDate { get; set;}
        [Column("PHONE")]
        public virtual string Phone { get; set; }
        [Column("LOGIN")]
        public virtual string Login { get; set; }
        [Column("PASSWORD")]
        public virtual string Password { get; set; }
        [Column("ROLE")]
        public virtual Role Role { get; set; }
    }
}
