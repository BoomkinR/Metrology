using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("locations")]
    public class Location
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("REGION")]
        public string Region { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("LOCATION_TYPE_ID")]
        public LocationType LocationType { get; set; }

    }
}
