using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoSS
{
    public partial class App : Application
    {
        public IAppContext AppContext { get; }
        public Service Service { get; }

        public App(IAppContext context)
        {
            InitializeComponent();

            // Stores the app context
            AppContext = context;
            Service = new Service(context);

            MainPage = new MainPage(Service);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
