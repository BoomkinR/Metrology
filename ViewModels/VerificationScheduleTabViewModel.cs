using System;
using System.Collections.Generic;
using Metrology.Definitions;
using Metrology.Models;
using Metrology.Models.Dtos;
using Metrology.Services.ModelService;

namespace Metrology.ViewModels
{
    public class VerificationScheduleTabViewModel: ViewModelInteraction
    {
        private readonly VerificationJournalService _verificationJournalService = VerificationJournalService.GetInstance();
        public VerificationScheduleTabViewModel()
        {
            OnRefresh();
        }
        
        private IEnumerable<VerificationJournalDto> verificationItems;
        public IEnumerable<VerificationJournalDto> VerificationItems {get => verificationItems;
            set
            {
                verificationItems = value;
                OnPropertyChanged(nameof(VerificationItems));
            }
        }

        private RelayCommand refreshCommand { get; set; }

        public RelayCommand RefreshCommand
        {
            get
            {
                return refreshCommand ??
                       (refreshCommand = new RelayCommand(obj => OnRefresh()));
            }
        }

        private void OnRefresh()
        {
            VerificationItems = _verificationJournalService.GetFullJournal();
        }
    }
}