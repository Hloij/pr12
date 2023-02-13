using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pr12
{
    public partial class App : Application
    {
        static  public ObservableCollection<Peaple> peaples = new ObservableCollection<Peaple>();
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
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
