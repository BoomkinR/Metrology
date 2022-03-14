using Metrology.Definitions;
using Metrology.Models.Dtos;
using Metrology.Services.ModelService;
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

        private UserDto userTo;
        public UserDto UserTo
        {
            get => userTo;
            set
            {
                userTo = value;
                OnPropertyChanged(nameof(UserTo));
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

    }
}
