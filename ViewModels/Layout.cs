using Metrology.Models;
using System;
using System.Linq;

namespace Metrology.ViewModels
{
    public class Layout
    {
         public Layout()
        {
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            InitViewModels();
        }

        public PersonalAreaTabViewModel PersonalAreaTabViewModel { get; set; }
        public InstrumentViewModel InstrumentViewModel { get; set; }
        public VerificationScheduleTabViewModel VerificationScheduleTabViewModel { get; set; }

        private void InitViewModels()
        {
            PersonalAreaTabViewModel = new PersonalAreaTabViewModel();
            InstrumentViewModel = new InstrumentViewModel();
            VerificationScheduleTabViewModel = new VerificationScheduleTabViewModel();
        }

    }
}
