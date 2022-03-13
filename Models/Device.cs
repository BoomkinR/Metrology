using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology.Models
{
    [Table("devices")]
    public class Device
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("NAME"), Required]
        public string Name { get; set; }
        [Column("DEVICE_TYPE"), Required]
        public DeviceType Type { get; set; }
        [Column("DEVICE_DATE")]
        public DateTime DeviceDate { get; set; }
        [Column("DATE_EXPLOTATION_START")]
        public DateTime DateExplotationStart { get; set; }
        
        [Column("DATE_EXPLOTATION_END")]        
        public DateTime DateExplotationEnd { get; set; }

        [Column("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }
        [Column("LOCATION")]
        public Location Location { get; set; }
        [Column("PRESENCE_STATUS")]
        public PresenceStatus Status { get; set; }

    }
}
