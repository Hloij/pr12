using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pr12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckPage : ContentPage
    {
       

        public CheckPage(Peaple peaple, double time)
        {
            InitializeComponent();
           FirstName.Text = peaple.FirstName;
            MidleName.Text = peaple.MidleName;
            LastName.Text = peaple.LastName;
            Time.Text = Convert.ToString(peaple.Time);
            STime.Text = Convert.ToString(time);

        }

    }
}