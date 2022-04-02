using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology.Models
{
    [Table("contractors")]
    public class Contractor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get; set; }
        [Column("ORGANISATION_NAME")]
        public virtual string OrganisationName { get; set; }
        [Column("INN")]
        public virtual string Inn { get; set; }
        [Column("CONTACT_CLIENT")]
        public virtual string ContactClient { get; set; }
        [Column("CONTACT_NUMBER")]
        public virtual string ContactNumper { get; set; }
    }
}
