using System.Collections.Generic;
using System.Linq;
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

        private List<UserDto> users;
        public List<UserDto> Users
        {
            get => users;
            set
            {
                users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private UserDto selectedUsers;
        public UserDto SelectedUsers
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

        private RelayCommand addRole { get; set; }

        public RelayCommand AddRole
        {
            get
            {
                return addRole ??
                       (addRole = new RelayCommand(obj => AddRoleCommand()));
            }
        }
        
        private RelayCommand addOrganization { get; set; }

        public RelayCommand AddOrganization
        {
            get
            {
                return addOrganization ??
                       (addOrganization = new RelayCommand(obj => AddOrganizationCommand()));
            }
        }
        
        private RelayCommand addLocation { get; set; }

        public RelayCommand AddLocation
        {
            get
            {
                return addLocation ??
                       (addLocation = new RelayCommand(obj => AddLocationCommand()));
            }
        }

        private void AddLocationCommand()
        {
            WindowService windowService = new WindowService();
            windowService.ShowAddLocalizationView();
            UpdateUsersList();
        }

        private void AddOrganizationCommand()
        {
            WindowService windowService = new WindowService();
            windowService.ShowAddOrganizationView();
            UpdateUsersList();
        }


        private void AddRoleCommand()
        {
            WindowService windowService = new WindowService();
            windowService.ShowAddRoleView();
            UpdateUsersList();
        }

        private void UpdateUsersList()
        {
            Users = new List<UserDto>(_userService.GetAllUsers());
        }

    }
}
