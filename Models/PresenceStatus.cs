using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
        [Table("presence_status")]
        public class PresenceStatus
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID")]
            public int Id { get; set; }
            [Column("NAME")]
            public string Name { get; set; }
        }    
}
