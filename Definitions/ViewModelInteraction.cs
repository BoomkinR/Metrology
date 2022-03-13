using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Metrology.Definitions
{
    public class ViewModelInteraction: INotifyPropertyChanged, IWindowInteraction
    {
        public Action Close { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        protected void CloseWindow()
        {
            Close?.Invoke();
        }
        private RelayCommand closeCommand;

        public RelayCommand CloseCommand
        {
            get
            {
                return closeCommand ??
                       (closeCommand = new RelayCommand(obj => Close()));
            }
        }


    }
}