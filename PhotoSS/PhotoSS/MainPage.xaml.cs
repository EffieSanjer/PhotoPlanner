using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PhotoSS
{
    public partial class MainPage : ContentPage
    {
        //People Model { get; set; }
        PeopleViewModel viewModel;
        public MainPage(/*People model, PeopleViewModel viewModel*/)
        {
            InitializeComponent();
            //Model = model;
            //ViewModel = viewModel;
            viewModel = new PeopleViewModel();
            this.BindingContext = this;
        }
        protected override async void OnAppearing()
        {
            await viewModel.GetPeople();
            Title = Convert.ToString(viewModel.People[0].Name);
            base.OnAppearing();
        }
    }
}
