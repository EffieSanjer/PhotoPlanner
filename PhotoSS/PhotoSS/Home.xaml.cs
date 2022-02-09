using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoSS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        string user_name = "Елена";
        string user_ph_count = "2";

        List<Test> tests = new List<Test>(); 
        
        public Home()
        {
            tests.Add(new Test("image2.jpg", "Марина", "21.02.2022", "Element Studio"));
            tests.Add(new Test("image1.jpg", "Ольга", "21.02.2022", "Element Studio"));
            //Device.SetFlags("CollectionView_Experimental");
            InitializeComponent();
            welcome_name.Text = "Добро пожаловать, " + user_name;
            today_label.Text = "Сегодня: " + DateTime.Today.ToString("dd.MM.yyyy");
            photo_count.Text = "Запланировано съемок: " + user_ph_count;


            BindingContext = tests;
        }

    }
}