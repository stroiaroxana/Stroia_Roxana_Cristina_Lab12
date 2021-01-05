using System.ComponentModel;
using Xamarin.Forms;
using Stroia_Roxana_Cristina_Lab12.ViewModels;

namespace Stroia_Roxana_Cristina_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}