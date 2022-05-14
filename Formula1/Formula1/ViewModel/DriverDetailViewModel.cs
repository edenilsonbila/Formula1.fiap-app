using Formula1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Formula1.ViewModel
{
    public class DriverDetailsViewModel : BaseViewModel
    {
        #region properties        
        private Driver driver;
        public Driver Driver
        {
            get { return driver; }
            set { SetProperty(ref driver, value); }
        }
        #endregion        
        #region construtor
        public DriverDetailsViewModel()
        {
            driver = new Driver();
        }
        public DriverDetailsViewModel(Driver driver)
        {
            this.Driver = driver;
        }
        #endregion

        public ICommand OpenBrowserCommando => new Command<Driver>(async (Driver d) => {
            var uri = new Uri("https://www.f1.com.br");
            await Xamarin.Essentials.Browser.OpenAsync(uri);
        });
    }
}
