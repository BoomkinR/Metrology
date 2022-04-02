using System.Collections.Generic;
using System.Linq;
using Metrology.Models;
using Metrology.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Metrology.Services.ModelService
{
    public class VerificationJournalService
    {
        private static VerificationJournalService instance;

        public VerificationJournalService()
        {
        }

        public static VerificationJournalService GetInstance()
        {
            if (instance == null)
                instance = new VerificationJournalService();
            return instance;
        }

        public List<VerificationJournalDto> GetFullJournal()
        {
            MapService mapService = new MapService();
            using ApplicationContext db = new ApplicationContext();
            var verifications = db.VerificationJournals.Include(x => x.Device);
            return verifications.Select(x => mapService.MapToVerificationJournalDto(x)).ToList();
        }

        public void SaveVerificationJournal(VerificationJournalDto verificationJournalDto)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var verificationJournal = new VerificationJournal
                {
                    ID = verificationJournalDto.Id,
                    Device = db.Devices.FirstOrDefault(x => x.Id == verificationJournalDto.Device.Id),
                    Organization = verificationJournalDto.Organization,
                    IsDone = verificationJournalDto.IsDone,
                    VerificationDate = verificationJournalDto.VerificationDate
                };
                db.VerificationJournals.Add(verificationJournal);
                db.SaveChanges();
            }
        }
    }
}