using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metrology.Models
{
    [Table("verification_journal")]
    public class VerificationJournal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("DEVICE")]
        public virtual Device Device { get; set; }
        [Column("ORGANIZATION")]
        public virtual Organization Organization { get; set; }
        [Column("IS_DONE")]
        public virtual bool IsDone { get; set; }
        [Column("VERIFICATION_DATE")]
        public virtual DateTime VerificationDate { get; set; }
    }
}