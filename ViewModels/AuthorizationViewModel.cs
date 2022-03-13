using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
using Metrology.Definitions;
using Metrology.Models;
using System.Linq;
using Metrology.Services;
using Metrology.Views;

namespace Metrology.ViewModels
{
    public class AuthorizationViewModel: ViewModelInteraction
    {

        
        private string _login { get; set; }
        private string _password { get; set; }
        private string _message { get; set; }
        public string Login { get { return _login;} set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password { get { return _password;} set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            } }
        public string Message { get { return _message; } 
            set {
                _message = value;
                OnPropertyChanged(nameof(Message));
            } }

        private RelayCommand loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return loginCommand ??
                       (loginCommand = new RelayCommand(obj => Authorization()));
            }
        }      

        private void Authorization ()
        {
         
            if (Login == null && Password==null)
            {
                return;
            }

            using ApplicationContext db = new ApplicationContext();
            var users = db.Users.ToList();


            var loggedUser = db.Users.Where(x => x.Login == Login && x.Password == LoginService.GetHashedPassword(Password)).ToList().FirstOrDefault();
            var password = db.Users.ToList().FirstOrDefault().Password;
            var password1 = LoginService.GetHashedPassword("admin");
            var a = password = password1;


            if (loggedUser == null)
            {
                Message = "Не верный логин или пароль";
                return;
            }

            LoginService.CurrentUser = loggedUser;
            var windowService= new WindowService();
            windowService.ShowMainWindow();
            Close();

        }

        
    }
}
