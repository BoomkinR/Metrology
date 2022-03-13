using Metrology.Definitions;
using Metrology.Models;
using Metrology.Models.Dtos;
using Metrology.Services.ModelService;
using System;
using System.Collections.Generic;

namespace Metrology.ViewModels
{
    public class AddDeviceViewModel : ViewModelInteraction
    {
        private readonly DeviceService _deviceService = new DeviceService();
        public AddDeviceViewModel()
        {
            SetDeviceTypes();
            Device = new DeviceDto();
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

        private List<Location> _locations {get;set;}
        public List<Location> Locations { get => _locations;
            set
            {
                _locations = value;
                OnPropertyChanged(nameof(Locations));
            }
        }


        private RelayCommand addCommand { get; set; }
        public RelayCommand AddCommand { get => addCommand ??
                       (addCommand = new RelayCommand(obj => OnAdd()));  }

        private void OnAdd()
        {
            var deviceService = new DeviceService();
            Device.Type = SelectedDeviceType;

            Device.Status = new PresenceStatus() { Id = 1};
            deviceService.SaveDevice(Device);
            CloseWindow();
        }
    }
}