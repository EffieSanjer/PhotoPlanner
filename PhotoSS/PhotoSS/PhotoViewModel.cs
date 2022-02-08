using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace PhotoSS
{
    class PhotoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Location> locations;
        private Location selected;

        public PhotoViewModel()
        {
            Locations = new ObservableCollection<Location>();
            //Locations.Add(); считывание из БД
            
            Selected = new Location(); //Выбранная на карте локация
        }

        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set
            {
                if (locations != value)
                {
                    locations = value;
                    OnPropertyChanged("Locations");

                }
            }
        }
        public Location Selected
        {
            get { return selected; }
            set
            {
                if (selected != value)
                {
                    selected = value;
                    OnPropertyChanged("Selected");

                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
