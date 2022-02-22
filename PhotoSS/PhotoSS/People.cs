using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;

namespace PhotoSS
{
    class People : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string surname;
        private bool is_client;
        private string phone;
        private string email;
        private string social_media;
        private string password;
        private string price; //JSON

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
        public bool IsClient
        {
            get { return is_client; }
            set
            {
                if (is_client != value)
                {
                    is_client = value;
                    OnPropertyChanged("IsClient");
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
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged("Surname");
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
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string SocialMedia
        {
            get { return social_media; }
            set
            {
                if (social_media != value)
                {
                    social_media = value;
                    OnPropertyChanged("SocialMedia");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        public string Price
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

        //public override bool Equals(object obj)
        //{
        //    People person = obj as People;
        //    return this.Id == person.Id;
        //}
    }
}
