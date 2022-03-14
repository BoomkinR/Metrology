using System.Collections.Generic;
using Metrology.Definitions;
using Metrology.Models;
using Metrology.Models.Dtos;
using Metrology.Services;
using Metrology.Services.ModelService;

namespace Metrology.ViewModels
{
    public class PersonalAreaTabViewModel:ViewModelInteraction
    {
        UserService _userService = new UserService();

        public PersonalAreaTabViewModel()
        {
            UpdateUsersList();
        }

        private IEnumerable<UserDto> users;
        public IEnumerable<UserDto> Users
        {
            get => users;
            set
            {
                users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private User selectedUsers;
        public User SelectedUsers
        {
            get => selectedUsers;
            set
            {
                selectedUsers = value;
                OnPropertyChanged(nameof(SelectedUsers));
            }
        }

        private RelayCommand addUser { get; set; }

        public RelayCommand AddUser
        {
            get
            {
                return addUser ??
                       (addUser = new RelayCommand(obj => AddUserCommand()));
            }
        }


        private void AddUserCommand()
        {
            WindowService windowService = new WindowService();
            windowService.ShowAddUserView();
            UpdateUsersList();
        }

        private void UpdateUsersList()
        {
            Users = new List<UserDto>(_userService.GetAllUsers());
        }

    }
}
