using Exammvmdb.DataContext;
using Exammvmdb.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace Exammvmdb.Services
{
    public class EjercicioService
    {
        private readonly AppDbContext _context;

        public EjercicioService() => _context = App.GetContext();


        public bool Create(Ejercicio item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Ejercicio> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Ejercicio> Get()
        {
            return _context.People.ToList();
        }


        public List<Ejercicio> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return _context.People.ToList();


            return _context.People.Where(x => x.FirstName.Contains(text) || x.LastName.Contains(text)).ToList();
        }



    }
}
