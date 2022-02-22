using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;

namespace PhotoSS
{
    class Photoshoot : INotifyPropertyChanged
    {
        Dictionary<int, string> statuses = new Dictionary<int, string>()
        {
            {0, "В обработке" },
            {1, "Подготовка" },
            {2, "Проведена" },
            {3, "Завершена" },
            {4, "Отменена" }
        };

        private int id;
        private People client;
        private People photograph;
        private Location location;
        private int status;
        private DateTime datetime;
        private string theme;
        private Category category;
        private string description;
        private string references; //path/to/folder
        private string photos; //path/to/results
        private string props; //JSON
        private double price;
        private string note; //???

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public People Client
        {
            get { return client; }
            set
            {
                if (client != value)
                {
                    client = value;
                    OnPropertyChanged("Client");
                }
            }
        }
        public People Photograph
        {
            get { return photograph; }
            set
            {
                if (photograph != value)
                {
                    photograph = value;
                    OnPropertyChanged("Photograph");
                }
            }
        }
        public Location Location
        {
            get { return location; }
            set
            {
                if (location != value)
                {
                    location = value;
                    OnPropertyChanged("Location");
                }
            }
        }
        public int Status  //From dict
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged("Status");
                }
            }
        }
        public DateTime Datetime
        {
            get { return datetime; }
            set
            {
                if (datetime != value)
                {
                    datetime = value;
                    OnPropertyChanged("Datetime");
                }
            }
        }
        public string Theme
        {
            get { return theme; }
            set
            {
                if (theme != value)
                {
                    theme = value;
                    OnPropertyChanged("Theme");
                }
            }
        }
        public Category Category
        {
            get { return category; }
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged("Category");
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public string References
        {
            get { return references; }
            set
            {
                if (references != value)
                {
                    references = value;
                    OnPropertyChanged("References");
                }
            }
        }
        public string Photos
        {
            get { return photos; }
            set
            {
                if (photos != value)
                {
                    photos = value;
                    OnPropertyChanged("Photos");
                }
            }
        }
        public string Props
        {
            get { return props; }
            set
            {
                if (props != value)
                {
                    props = value;
                    OnPropertyChanged("Props");
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        public string Note
        {
            get { return note; }
            set
            {
                if (note != value)
                {
                    note = value;
                    OnPropertyChanged("Note");
                }
            }
        }

    }

    class Category : INotifyPropertyChanged
    {
        private int id;
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

    }
}
