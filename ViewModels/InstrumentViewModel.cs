using Metrology.Definitions;
using Metrology.Models.Dtos;
using Metrology.Services;
using Metrology.Services.ModelService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metrology.ViewModels
{
    public class InstrumentViewModel : ViewModelInteraction
    {
        private readonly DeviceService _deviceService = new DeviceService();
        private readonly WindowService _windowService = new WindowService();
        public InstrumentViewModel()
        {
            UpdateDevices();
            SetButtonVisible();
            SelectedDevice = Devices.FirstOrDefault();
        }


        private IEnumerable<DeviceDto> _devices;
        public IEnumerable<DeviceDto> Devices
        {
            get => _devices; 
            set { _devices = value;
                OnPropertyChanged(nameof(Devices));
            } 
        }

        private DeviceDto selectedDevice;
        public DeviceDto SelectedDevice
        {
            get => selectedDevice;
            set
            {
                selectedDevice = value;
                SetButtonVisible();
                OnPropertyChanged(nameof(SelectedDevice));
            }
        }

        private bool isHangOverAvailable;
        public bool IsHangOverAvailable
        {
            get => isHangOverAvailable;
            set
            {
                isHangOverAvailable = value;
                OnPropertyChanged(nameof(IsHangOverAvailable));
            }
        }

        private bool isCancelAvailable;
        public bool IsCancelAvailable
        {
            get => isCancelAvailable;
            set
            {
                isCancelAvailable = value;
                OnPropertyChanged(nameof(IsCancelAvailable));
            }
        }

        private bool isRecieveAvailable;
        public bool IsRecieveAvailable
        {
            get => isRecieveAvailable;
            set
            {
                isRecieveAvailable = value;
                OnPropertyChanged(nameof(IsRecieveAvailable));
            }
        }

        private bool isTransportAvailable;
        public bool IsTransportAvailable
        {
            get => isTransportAvailable;
            set
            {
                isTransportAvailable = value;
                OnPropertyChanged(nameof(IsTransportAvailable));
            }
        }


        private RelayCommand addDeviceCommand { get; set; }

        public RelayCommand AddDeviceCommand
        {
            get
            {
                return addDeviceCommand ??
                       (addDeviceCommand = new RelayCommand(obj => OnAddDevice()));
            }
        }

        private RelayCommand handOver { get; set; }

        public RelayCommand HandOver
        {
            get { return handOver ?? (handOver = new RelayCommand(obj => OnHandOver())); }
        }

        private void OnHandOver()
        {
            
        }

        private void OnAddDevice() 
        {
            var windowService = new WindowService();
            windowService.ShowAddDeviceModalView();
            UpdateDevices();
        }

        private void UpdateDevices()
        {
            Devices = _deviceService.GetAllDevices();
        }

        private void SetButtonVisible()
        {
            if (SelectedDevice == null)
            {
                return;
            }
            IsHangOverAvailable = SelectedDevice.Status?.Id == 1;
            IsCancelAvailable = SelectedDevice.Status?.Id == 0;
            IsRecieveAvailable = SelectedDevice.Status?.Id == 0;
            IsTransportAvailable = SelectedDevice.Status?.Id == 1;
        }
    }
}
