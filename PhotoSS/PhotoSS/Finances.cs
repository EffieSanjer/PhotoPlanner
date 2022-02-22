using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;

namespace PhotoSS
{
    class Finances : INotifyPropertyChanged
    {
        private int id;
        private Photoshoot photoshoot;
        private bool is_income;
        private People user;
        private string name;
        private DateTime date;
        private double cost;

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
        public Photoshoot Photoshoot
        {
            get { return photoshoot; }
            set
            {
                if (photoshoot != value)
                {
                    photoshoot = value;
                    OnPropertyChanged("Photoshoot");
                }
            }
        }
        public bool Is_income
        {
            get { return is_income; }
            set
            {
                if (is_income != value)
                {
                    is_income = value;
                    OnPropertyChanged("Is_income");
                }
            }
        }
        public People User
        {
            get { return user; }
            set
            {
                if (user != value)
                {
                    user = value;
                    OnPropertyChanged("User");
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
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }
        public double Cost
        {
            get { return cost; }
            set
            {
                if (cost != value)
                {
                    cost = value;
                    OnPropertyChanged("Cost");
                }
            }
        }

    }
}
