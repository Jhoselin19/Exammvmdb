using Exammvmdb.Models;
using Exammvmdb.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

using System.Linq;

namespace Exammvmdb.ViewModels
{
    public class ViewModelEjercicio : BaseViewModel
    {
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set { SetValue(ref this.firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Ejercicio> people;
        public List<Ejercicio> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }


        public ViewModelEjercicio()
        {
            SearchCommand = new Command(() =>
            {
                EjercicioService service = new EjercicioService();
                People = service.GetByText(Filter);
            });

            InsertCommand = new Command(() =>
            {
                EjercicioService service = new EjercicioService();
                int newPersonId = service.Get().Count + 1;
                service.Create(new Ejercicio { FirstName = FirstName, LastName = LastName });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }

    }
}
