using FlagData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunFlacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFlags : ContentPage
    {
        public AllFlags()
        {
            BindingContext = DependencyService.Get<FunFlactsViewModel>();
            InitializeComponent();
        }

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            DependencyService.Get<FunFlactsViewModel>().CurrentFlag = (Flag)e.Item;
            await this.Navigation.PushAsync(new FlagDetailsPage());
        }
    }
}