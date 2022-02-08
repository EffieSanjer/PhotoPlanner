using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;

namespace PhotoSS
{
    class Location : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string address;
        private string phone;
        private string social_media;
        private string note;
        private double latitude;
        private double longitude;

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
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }
        public string Social_media
        {
            get { return social_media; }
            set
            {
                if (social_media != value)
                {
                    social_media = value;
                    OnPropertyChanged("Social_media");
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
        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (latitude != value)
                {
                    latitude = value;
                    OnPropertyChanged("Latitude");
                }
            }
        }
        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (longitude != value)
                {
                    longitude = value;
                    OnPropertyChanged("Longitude");
                }
            }
        }
    }
}
