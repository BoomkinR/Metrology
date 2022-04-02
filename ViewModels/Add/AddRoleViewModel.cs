using Metrology.Definitions;
using Metrology.Models;

namespace Metrology.ViewModels.Add
{
    public class AddRoleViewModel : ViewModelInteraction
    {
        public AddRoleViewModel()
        {
            RoleModel = new Role();
        }
        private Role _roleModel { get; set; }

        public Role RoleModel
        {
            get { return _roleModel; }
            set
            {
                _roleModel = value;

            }
        }


       
        private RelayCommand _saveRole { get; set; }

        public RelayCommand SaveRole
        {
            get
            {
                return _saveRole ??
                       (_saveRole = new RelayCommand(obj => OnSaveUser()));
            }
        }

        private void OnSaveUser()
        {
            using ApplicationContext db = new ApplicationContext();
            var role = RoleModel;
            db.Role.Add(role);
            db.SaveChanges();
            Close();
        }



    }
}