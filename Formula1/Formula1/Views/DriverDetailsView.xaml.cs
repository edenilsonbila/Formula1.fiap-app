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
    public partial class DriverDetailsView : ContentPage
    {
        public DriverDetailsView(Driver model)
        {
            InitializeComponent();

            this.BindingContext = model;
        }
    }
}