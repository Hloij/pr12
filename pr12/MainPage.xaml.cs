using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pr12
{
    
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            App.peaples.Add(new Peaple { FirstName = "Бандуркин", LastName = "Дмитрий", MidleName = "Дмитриевич", Time = 8 });
            App.peaples.Add( new Peaple { FirstName = "Константинов", LastName = "Кирилл", MidleName = "Александрович", Time = 10 });
            App.peaples.Add(new Peaple { FirstName = "Сомов", LastName = "Михаил", MidleName = "Алексеич", Time = 5.9 });
            Stuents.ItemsSource = App.peaples;
        }
       
        private double St()
        {
            double Stime=0;
            for (int i = 0; i < App.peaples.Count; i++)
            {
                Stime += App.peaples[i].Time;
            }
            Stime /= App.peaples.Count;
            return Stime;
        }

        int i = 0;
        private async void Stuents_ItemTapped(object sender, ItemTappedEventArgs e)
        {
             
            Peaple selected;
            if (e.Item != null)
            {
                if (i == 1)
                {
                    selected = (Peaple)e.Item;
                    double Stime = St();
                    await Navigation.PushAsync(new CheckPage(selected, Stime));
                    i = 0;
                }
                else 
                { 
                    i++;
                }   
            }
        }

        private void Remove_Clicked(object sender, EventArgs e)
        {
            Peaple selected=Stuents.SelectedItem as Peaple;
            if(selected!=null)
            {
                App.peaples.Remove(selected);
            }
         
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            // peaples.Add(new Peaple { FirstName = "Константинов", LastName = "Кирилл", MidleName = "Александрович", Time = 10f });
            await Navigation.PushAsync(new AddPage());
            //  await Navigation.PushAsync(new AddPage());
           
        }
    }
}
