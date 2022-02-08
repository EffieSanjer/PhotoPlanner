using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;

namespace PhotoSS
{
    class People
    {
        private int id;
        private string fio;
        private bool is_client;
        private string phone;
        private string email;
        private string social_media;
        private string password;
        private string price; //JSON


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
