using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Metrology.Models
{
    [Table("role")]
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID")]     
        public int Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("PREVILEGIES")]
        public int Privelegies { get; set; }
    }
}
