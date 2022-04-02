using System;

namespace Metrology.Models.Dtos
{
    public class VerificationJournalDto
    {
        public int Id { get; set; }
        public Device Device { get; set; }
        public Organization Organization { get; set; }
        public bool IsDone { get; set; }
        public DateTime VerificationDate { get; set; }
    }
}