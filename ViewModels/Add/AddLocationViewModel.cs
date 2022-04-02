using Metrology.Definitions;
using Metrology.Models;

namespace Metrology.ViewModels.Add
{
    public class AddLocationViewModel : ViewModelInteraction
    {
        public AddLocationViewModel()
        {
            LocationModel = new Location();
        }
        private Location _locationModel { get; set; }

        public Location LocationModel
        {
            get { return _locationModel; }
            set
            {
                _locationModel = value;

            }
        }



        private RelayCommand _savelocation { get; set; }

        public RelayCommand SaveLocation
        {
            get
            {
                return _savelocation ??
                       (_savelocation = new RelayCommand(obj => OnSaveLocation()));
            }
        }

        private void OnSaveLocation()
        {
            using ApplicationContext db = new ApplicationContext();
            var locationModel = LocationModel;
            db.Location.Add(locationModel);
            db.SaveChanges();
            Close();
        }
    }
}
