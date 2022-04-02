using Metrology.Definitions;
using Metrology.Models;

namespace Metrology.ViewModels.Add
{
    public class AddOrganizationViewModel : ViewModelInteraction
    {
        public AddOrganizationViewModel()
        {
            OrganizationModel = new Organization();
        }
        private Organization _organizationModel { get; set; }

        public Organization OrganizationModel
        {
            get { return _organizationModel; }
            set
            {
                _organizationModel = value;

            }
        }



        private RelayCommand _saveRole { get; set; }

        public RelayCommand SaveOrganization
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
            var organization = OrganizationModel;
            db.Organizations.Add(organization);
            db.SaveChanges();
            Close();
        }
    }
}
