using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("organizations")]
    public class Organization
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("Name")]
        public virtual string Name { get; set; }
    }
}