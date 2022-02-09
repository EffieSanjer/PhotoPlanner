using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PhotoSS
{
    class Test : INotifyPropertyChanged 
    {
        public string image;
        public string name;
        public string date;
        public string studio;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public string Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged("Image");
                }
            }
        } 
        public string Studio
        {
            get { return studio; }
            set
            {
                if (studio != value)
                {
                    studio = value;
                    OnPropertyChanged("Studio");
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
        public string Date
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

        public Test(string img, string name, string studio, string date)
        {
            Image = img;
            Name = name;
            Studio = studio;
            Date = date;
        }
    }
}
