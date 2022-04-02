using Metrology.Definitions;
using Metrology.Models.Dtos;
using Metrology.Services;
using Metrology.Services.ModelService;
using System.Collections.Generic;
using System.Linq;

namespace Metrology.ViewModels
{
    public class InstrumentViewModel : ViewModelInteraction
    {
        private readonly DeviceService _deviceService = new DeviceService();
        private readonly WindowService _windowService = new WindowService();
        private readonly TransferLogService _transferLogService = TransferLogService.GetInstance();
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
        private RelayCommand cancelTransfer { get; set; }
        public RelayCommand CancelTransfer
        {
            get { return cancelTransfer ?? (cancelTransfer = new RelayCommand(obj => OnCancelTransfer())); }
        }

        private RelayCommand receiveTransfer { get; set; }
        public RelayCommand ReceiveTransfer
        {
            get { return receiveTransfer ?? (receiveTransfer = new RelayCommand(obj => OnReceiveTransfer())); }
        }

        private void OnReceiveTransfer()
        {
            _transferLogService.ReceiveActualTransfer(SelectedDevice.Id);
            UpdateDevices();
        }

        private void OnCancelTransfer()
        {
            _transferLogService.CancelActualTransfer(SelectedDevice.Id);
            SetButtonVisible();
        }

        private void OnHandOver()
        {
            _windowService.ShowHandOverModalView(SelectedDevice);
            SetButtonVisible();
        }

        private void OnAddDevice() 
        {
            var windowService = new WindowService();
            windowService.ShowAddDeviceModalView();
            UpdateDevices();
        }

        private void UpdateDevices()
        {
            var selectedDeviceId = SelectedDevice?.Id;
            Devices = _deviceService.GetAllDevicesForUser();
            SelectedDevice = Devices.FirstOrDefault(x => x.Id == selectedDeviceId);
        }

        private void SetButtonVisible()
        {
            if (SelectedDevice == null)
            {
                return;
            }
            var actualLog = _transferLogService.GetLastTransferLogDtoBy(SelectedDevice.Id);
            var isAvailableToHandOverDevice = IsAvailableToHandOverDevice();

            if (actualLog == null)
            {
                IsHangOverAvailable = isAvailableToHandOverDevice;
                IsCancelAvailable = false;
                IsRecieveAvailable = false;
                IsTransportAvailable = SelectedDevice.Status?.Id == 1;
                return;
            }
            
            var isDeviceWaitingAccept = !actualLog.Accepted;
            IsHangOverAvailable = isAvailableToHandOverDevice && !isDeviceWaitingAccept;
            IsCancelAvailable = isAvailableToHandOverDevice && isDeviceWaitingAccept;
            IsRecieveAvailable = actualLog.UserTo.ID == LoginService.CurrentUser.ID && isDeviceWaitingAccept;
            IsTransportAvailable = SelectedDevice.Status?.Id == 1;
        }

        private bool IsAvailableToHandOverDevice()
        {
            return SelectedDevice.OwnerUser.ID == LoginService.CurrentUser.ID;
        }
    }
}
