using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stroia_Roxana_Cristina_Lab12.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stroia_Roxana_Cristina_Lab12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntryPage : ContentPage
    {
        public ListEntryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing(); listView.ItemsSource = await App.Database.GetShopListsAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = new ShopList()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPage
                {
                    BindingContext = e.SelectedItem as ShopList
                });
            }
        }
        async void OnSaveButtonClicked(object sender, EventArgs e) 
        { 
            var slist = (ShopList)BindingContext; slist.Date = DateTime.UtcNow; 
            await App.Database.SaveShopListAsync(slist); 
            await Navigation.PopAsync(); 
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e) { 
            var slist = (ShopList)BindingContext; 
            await App.Database.DeleteShopListAsync(slist); 
            await Navigation.PopAsync(); 
        }
    }

}