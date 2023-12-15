using Exammvmdb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exammvmdb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EjercicioView : ContentPage
    {
        public EjercicioView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelEjercicio();

        }
    }
}