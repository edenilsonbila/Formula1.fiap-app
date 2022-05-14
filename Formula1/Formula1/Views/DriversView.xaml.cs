using Formula1.Data;
using Formula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversView : ContentPage
    {
        private DriverRepository driverRepository;
        public DriversView()
        {
            InitializeComponent();
            driverRepository = new DriverRepository();
            DriversList.ItemsSource = driverRepository.FindAll();
        }

        private void DriversList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Obtem o item clicado na tela
            Driver driverSelected = e.Item as Driver;
            Navigation.PushAsync(new DriverDetailsView(driverSelected));
        }
    }
}