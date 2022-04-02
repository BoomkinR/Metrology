using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("location_type")]
    public class LocationType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        [Column("NAME")]
        public virtual string Name { get; set; }
    }
}
