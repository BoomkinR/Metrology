using Metrology.Definitions;
using Metrology.Models.Dtos;
using Metrology.Services;
using Metrology.Services.ModelService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metrology.ViewModels
{
    public class HandoverViewModel : ViewModelInteraction
    {
        private UserService _userService;
        public HandoverViewModel(DeviceDto deviceToTransfer)
        {
            _userService = new UserService();

            DeviceDto = deviceToTransfer;
            UserList = _userService.GetAllUsers();
            SelectedUser = UserList.FirstOrDefault();
        }

        private DeviceDto deviceDto;
        public DeviceDto DeviceDto
        {
            get => deviceDto;
            set
            {
                deviceDto = value;
                OnPropertyChanged(nameof(DeviceDto));
            }
        }
        private string note;
        public string Note { get => note;
            set
            {
                note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

       
        private IEnumerable<UserDto> userList;
        public IEnumerable<UserDto> UserList
        {
            get => userList;
            set
            {
                userList = value;
                OnPropertyChanged(nameof(UserList));
            }
        }

        private UserDto selectedUser;
        public UserDto SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                OnPropertyChanged(nameof(UserList));
            }
        }

        private RelayCommand handOverDeviceCommand;

        public RelayCommand HandOverDeviceCommand
        {
            get
            {
                return handOverDeviceCommand ??
                       (handOverDeviceCommand = new RelayCommand(obj => HandOverDevice()));
            }
        }

        private void HandOverDevice()
        {
            var transferLogService = TransferLogService.GetInstance();
            transferLogService.HandOverDeviceWithAccept(DeviceDto.Id, SelectedUser.ID,Note);  
            CloseWindow();
        }
    }
}
