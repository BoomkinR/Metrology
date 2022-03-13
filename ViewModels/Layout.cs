using Metrology.Models;
using System;
using System.Linq;

namespace Metrology.ViewModels
{
    internal class Layout
    {
         public Layout()
        {
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            InitViewModels();
        }

        public PersonalAreaTabViewModel personalAreaTabViewModel { get; set; }
        public InstrumentViewModel instrumentViewModel { get; set; }

        private void InitViewModels()
        {
            personalAreaTabViewModel = new PersonalAreaTabViewModel();
            instrumentViewModel = new InstrumentViewModel();
        }

    }
}
