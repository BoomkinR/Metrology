using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("transfer_log")]
    public class TransferLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("USER_FROM")]
        public virtual User UserFrom { get; set; }
        [Column("USER_TO")]
        public virtual User UserTo { get; set; }
        [Column("DEVICE")]
        public virtual Device Device { get; set; }
        [Column("ACCEPTED")]
        public virtual bool? Accepted { get; set; }
        [Column("TRANSFER_DATE")]
        public virtual DateTime? TransferDate { get; set; }
        [Column("ACCEPTED_DATE")]
        public virtual DateTime? AcceptedDate { get; set; }
        [Column("NOTE")]
        public virtual string Note { get; set; }
    }
}
