using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology.Models
{
    [Table("device_type")]
    public class DeviceType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("NAME")]
        public virtual string Name { get; set; }
    }
}
