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
        public virtual int Id { get; set; }
        [Column("NAME"), Required]
        public virtual string Name { get; set; }
        [Column("DEVICE_TYPE"), Required]
        public virtual DeviceType Type { get; set; }
        [Column("DEVICE_DATE")]
        public virtual DateTime DeviceDate { get; set; }
        [Column("DATE_EXPLOTATION_START")]
        public virtual DateTime DateExplotationStart { get; set; }
        
        [Column("DATE_EXPLOTATION_END")]        
        public virtual DateTime DateExplotationEnd { get; set; }

        [Column("SERIAL_NUMBER")]
        public virtual string SerialNumber { get; set; }
        [Column("LOCATION")]
        public virtual Location Location { get; set; }
        [Column("PRESENCE_STATUS")]
        public virtual PresenceStatus Status { get; set; }
        [Column("OWNER_USER")]
        public virtual User OwnerUser { get; set; }

    }
}
