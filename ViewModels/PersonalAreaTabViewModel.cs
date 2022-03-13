using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Metrology.Annotations;
using Metrology.Definitions;
using Metrology.Models;
using Metrology.Services;
using Microsoft.EntityFrameworkCore;

namespace Metrology.ViewModels
{
    public class PersonalAreaTabViewModel:ViewModelInteraction
    {

        public PersonalAreaTabViewModel()
        {
            using ApplicationContext db = new ApplicationContext();
            var mapService = new MapService();
            Users = db.Users
                .Include(u => u.Role).ToList();
        }

        private IEnumerable<User> users;
        public IEnumerable<User> Users
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
        }

    }
}
