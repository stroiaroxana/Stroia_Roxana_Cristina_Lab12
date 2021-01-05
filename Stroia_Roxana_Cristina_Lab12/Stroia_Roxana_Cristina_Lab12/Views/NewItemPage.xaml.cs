using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Stroia_Roxana_Cristina_Lab12.Models;
using Stroia_Roxana_Cristina_Lab12.ViewModels;

namespace Stroia_Roxana_Cristina_Lab12.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}