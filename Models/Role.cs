using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Metrology.Models
{
    [Table("role")]
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID")]     
        public virtual int Id { get; set; }
        [Column("NAME")]
        public virtual string Name { get; set; }
        [Column("PREVILEGIES")]
        public virtual int Privelegies { get; set; }
    }
}
