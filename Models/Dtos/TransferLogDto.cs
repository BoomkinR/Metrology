

using System;

namespace Metrology.Models.Dtos
{
    public class TransferLogDto
    {
        public int ID { get; set; }
        public User UserFrom { get; set; }
        public User UserTo { get; set; }
        public Device Device { get; set; }
        public bool Accepted { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string Note { get; set; }
    }
}
