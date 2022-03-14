using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Metrology.Definitions;
using Metrology.Models;
using Metrology.Services;

namespace Metrology.ViewModels
{
    public class AddUserViewModel: ViewModelInteraction
    {
        public AddUserViewModel()
        {
            LoadRoles();
            UserModel = new User()
            {
                BirthDay = DateTime.Today.AddYears(-18)
            };
        }
        private User _userModel { get; set; }

        public User UserModel
        {
            get { return _userModel; }
            set
            {
                _userModel = value;
                
            }
        }
        private List<Role> _roleList { get; set; }
        public List<Role> RoleList
        {
            get { return _roleList;}
            set
            {
                _roleList = value;
                OnPropertyChanged(nameof(RoleList));
            } }
        
        private Role _selectedRole { get; set; }

        public Role SelectedRole
        {
            get
            {
                return _selectedRole;
            }
            set
            {
                _selectedRole = value;
                OnPropertyChanged(nameof(_selectedRole));
            }
        }
        
        private RelayCommand _saveUser { get; set; }

        public RelayCommand SaveUser
        {
            get
            {
                return _saveUser ??
                       (_saveUser = new RelayCommand(obj => OnSaveUser()));
            }
        }      

        private void OnSaveUser()
        {
            using ApplicationContext db = new ApplicationContext();
            var user = UserModel;
            user.Password = LoginService.GetHashedPassword(user.Password);
            db.Users.Add(user);
            db.SaveChanges();
            Close();
        }
        private void LoadRoles()
        {
            using ApplicationContext db = new ApplicationContext();
            RoleList = db.Role.ToList();
        }


    }
}