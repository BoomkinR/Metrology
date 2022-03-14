using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("transfer_log")]
    public class TransferLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("USER_FROM")]
        public User UserFrom { get; set; }
        [Column("USER_TO")]
        public User UserTo { get; set; }
        [Column("DEVICE")]
        public Device Device { get; set; }
        [Column("ACCEPTED")]
        public bool Accepted { get; set; }
        [Column("TRANSFER_DATE")]
        public DateTime TransferDate { get; set; }
        [Column("ACCEPTED_DATE")]
        public DateTime AcceptedDate { get; set; }
        [Column("NOTE")]
        public string Note { get; set; }
    }
}
