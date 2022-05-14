using Formula1.Data;
using Formula1.Models;
using Formula1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Formula1.ViewModel
{
    public class DriversViewModel : BaseViewModel
    {
        #region properties
        private ObservableCollection<Driver> drivers;

        public ObservableCollection<Driver> Drivers
        {
            get { return drivers; }
            set { SetProperty(ref drivers, value); }
        }

        private DriverRepository _driverRepository;

        private Driver selectedDriver;

        public Driver SelectedDriver
        {
            get { return selectedDriver; }
            set { SetProperty(ref selectedDriver, value); }
        }

        #endregion

        #region commands
        public ICommand DriverSelectedCommand => new Command<Driver>(async (Driver driver) =>
        {
            var vm = new DriverDetailsViewModel(driver);
            await App.Current.MainPage.Navigation.PushAsync(new DriverDetailsView(vm));
        });
        #endregion
        //public ICommand TesteClickedCommand => new Command<Driver>(Teste);

        //public void Teste(Driver obj)
        //{
        //    App.Current.MainPage.DisplayAlert("Teste", "Clicked", "OK");
        //}

        public DriversViewModel()
        {
            _driverRepository = new DriverRepository();
            Drivers = new ObservableCollection<Driver>(_driverRepository.FindAll());
        }
    }
}
