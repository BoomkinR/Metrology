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
        public int ID { get; set; }
        [Column("ORGANISATION_NAME")]
        public string OrganisationName { get; set; }
        [Column("INN")]
        public string Inn { get; set; }
        [Column("CONTACT_CLIENT")]
        public string ContactClient { get; set; }
        [Column("CONTACT_NUMBER")]
        public string ContactNumper { get; set; }


    }
}
