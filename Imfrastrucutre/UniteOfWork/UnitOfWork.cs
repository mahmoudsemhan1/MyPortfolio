using core.InterFaces;
using Imfrastrucutre.Repositry;
using System;
using System.Collections.Generic;
using System.Text;


namespace Imfrastrucutre.UniteOfWork
{
    public class UnitOfWorK<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        private  IGenricRepository<T> _Entity;

        public UnitOfWorK(DataContext context)
        { 
            _context = context;
        }
        public IGenricRepository<T> Entity 
            {
            get
            {
                return _Entity ?? (_Entity = new GenericRepository<T>(_context));

            }

             }

        
        public void Save()
    {
        _context.SaveChanges();
    }
}
}
