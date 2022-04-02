using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("locations")]
    public class Location
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("REGION")]
        public virtual string Region { get; set; }
        [Column("NAME")]
        public virtual string Name { get; set; }
        [Column("LOCATION_TYPE_ID")]
        public virtual LocationType LocationType { get; set; }

    }
}
