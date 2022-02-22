using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhotoSS
{
    class LocationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Location> locations;
        private Location selected;

        bool initialized = false;   // была ли начальная инициализация
        private bool isBusy;    // идет ли загрузка с сервера
        LocationService service = new LocationService();

        public ICommand addLocation;
        public ICommand delLocation;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }
        public bool IsLoaded
        {
            get { return !isBusy; }
        }
        public LocationViewModel()
        {
            Locations = new ObservableCollection<Location>();
            //Locations.Add(); считывание из БД
            IsBusy = false;
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
        public ICommand AddLocation
        {
            get
            {
                if (addLocation == null)
                {
                    addLocation = new AddLocationCommand(this);
                }
                return addLocation;
            }

        }
        public ICommand DelLocation
        {
            get
            {
                if (delLocation == null)
                {
                    delLocation = new DeleteLocationCommand(this);
                }
                return delLocation;
            }

        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public async Task GetLocations()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<Location> locations = await service.GetLocations();

            // очищаем список
            //Friends.Clear();
            while (Locations.Any())
                Locations.RemoveAt(Locations.Count - 1);

            // добавляем загруженные данные
            foreach (Location f in locations)
                Locations.Add(f);
            IsBusy = false;
            initialized = true;
        }
    }
    
    class PeopleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<People> people;
        private People selected;

        bool initialized = false;   // была ли начальная инициализация
        private bool isBusy;    // идет ли загрузка с сервера
        PeopleService service = new PeopleService();

        public ICommand addPerson;
        //public ICommand delLocation;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }
        public bool IsLoaded
        {
            get { return !isBusy; }
        }


        public PeopleViewModel()
        {
            People = new ObservableCollection<People>();
            IsBusy = false;
            //Locations.Add(); считывание из БД
            //AddPersonCommand = new AddPersonCommand(AddPerson);
            Selected = new People(); //авторизованный пользователь?  
        }

        public ObservableCollection<People> People
        {
            get { return people; }
            set
            {
                if (people != value)
                {
                    people = value;
                    OnPropertyChanged("People");

                }
            }
        }
        public People Selected
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
        public ICommand AddPerson
        {
            get
            {
                if (addPerson == null)
                {
                    addPerson = new AddPersonCommand(this);
                }
                return addPerson;
            }

        }
        //public ICommand DelLocation
        //{
        //    get
        //    {
        //        if (delLocation == null)
        //        {
        //            delLocation = new DeleteLocationCommand(this);
        //        }
        //        return delLocation;
        //    }

        //}
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public async Task GetPeople()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<People> people = await service.GetPeople();

            // очищаем список
            //Friends.Clear();
            while (People.Any())
                People.RemoveAt(People.Count - 1);

            // добавляем загруженные данные
            foreach (People f in people)
                People.Add(f);
            IsBusy = false;
            initialized = true;
        }
    }

    class PhotoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Photoshoot> photoshoots;
        private Photoshoot selected;

        bool initialized = false;   // была ли начальная инициализация
        private bool isBusy;    // идет ли загрузка с сервера
        PhotoService service = new PhotoService();

        public ICommand addPhotoshoot;
        public ICommand delPhotoshoot;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }
        public bool IsLoaded
        {
            get { return !isBusy; }
        }

        public PhotoViewModel()
        {
            Photoshoots = new ObservableCollection<Photoshoot>();
            //Locations.Add(); считывание из БД
            IsBusy = false;
            Selected = new Photoshoot(); //Выбранная съемка
        }

        public ObservableCollection<Photoshoot> Photoshoots
        {
            get { return photoshoots; }
            set
            {
                if (photoshoots != value)
                {
                    photoshoots = value;
                    OnPropertyChanged("Photoshoots");

                }
            }
        }
        public Photoshoot Selected
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
        public ICommand AddPhotoshoot
        {
            get
            {
                if (addPhotoshoot == null)
                {
                    addPhotoshoot = new AddPhotoCommand(this);
                }
                return addPhotoshoot;
            }

        }
        public ICommand DelPhotoshoot
        {
            get
            {
                if (delPhotoshoot == null)
                {
                    delPhotoshoot = new DeletePhotoCommand(this);
                }
                return delPhotoshoot;
            }

        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public async Task GetPhotoshoots()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<Photoshoot> photoshoots = await service.GetPhotoshoots();

            // очищаем список
            //Friends.Clear();
            while (Photoshoots.Any())
                Photoshoots.RemoveAt(Photoshoots.Count - 1);

            // добавляем загруженные данные
            foreach (Photoshoot f in photoshoots)
                Photoshoots.Add(f);
            IsBusy = false;
            initialized = true;
        }
    }

}