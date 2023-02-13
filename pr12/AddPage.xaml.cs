using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pr12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            App.peaples.Add(new Peaple { FirstName = FirstName.Text, LastName = LastName.Text, MidleName = MidleName.Text, Time = Convert.ToDouble(Time.Text) });   
            await Navigation.PopAsync();

        }
    }
}