using Metrology.Definitions;
using Metrology.Models;
using Metrology.Models.Dtos;
using Metrology.Services.ModelService;
using System;
using System.Collections.Generic;

namespace Metrology.ViewModels.Add
{
    public class AddDeviceViewModel : ViewModelInteraction
    {
        private readonly DeviceService _deviceService = new DeviceService();
        public AddDeviceViewModel()
        {
            SetDeviceTypes();
            Locations = _deviceService.GetAllLocations();
            Organizations = _deviceService.GetAllOrganizations();
            Device = new DeviceDto()
            {
                DateExplotationEnd = DateTime.Now,
                DateExplotationStart = DateTime.Now,
                DeviceDate = DateTime.Now
            };
            verificationJournal = new VerificationJournalDto()
            {
                VerificationDate = DateTime.Now.AddMonths(6)
            };
        }

        private void SetDeviceTypes()
        {
            DeviceTypes = _deviceService.GetDeviceTypes();
        }

        private IEnumerable<DeviceType> _deviceTypes { get; set; }
        public IEnumerable<DeviceType> DeviceTypes
        {
            get => _deviceTypes;
            set
            {
                _deviceTypes = value;
                OnPropertyChanged(nameof(DeviceTypes));
            }
        }

        private DeviceType selectedDeviceType { get; set; }
        public DeviceType SelectedDeviceType
        {
            get => selectedDeviceType;
            set 
            {
                selectedDeviceType = value;
                OnPropertyChanged(nameof(SelectedDeviceType));
            }
        }

        private DeviceDto _device { get; set; }
        public DeviceDto Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }

        private VerificationJournalDto verificationJournal;
        public VerificationJournalDto VerificationJournal
        {
            get => verificationJournal;
            set
            {
                verificationJournal = value;
                OnPropertyChanged(nameof(VerificationJournal));
            }
        }

        private List<Location> _locations {get;set;}
        public List<Location> Locations { get => _locations;
            set
            {
                _locations = value;
                OnPropertyChanged(nameof(Locations));
            }
        }

        private List<Organization> organizations;
        public List<Organization> Organizations { get => organizations;
            set
            {
                organizations = value;
                OnPropertyChanged(nameof(Organizations));
            }
        }

        private RelayCommand addCommand { get; set; }
        public RelayCommand AddCommand { get => addCommand ??
                       (addCommand = new RelayCommand(obj => OnAdd()));  }

        private void OnAdd()
        {
            Device.Type = SelectedDeviceType;

            Device.Status = new PresenceStatus() { Id = 1};
            _deviceService.SaveDevice(Device, VerificationJournal);
            CloseWindow();
        }
    }
}