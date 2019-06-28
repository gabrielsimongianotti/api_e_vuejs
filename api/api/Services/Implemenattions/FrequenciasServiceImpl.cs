using System;
using System.Collections.Generic;
using System.Linq;

using api.Model;
using api.Model.Context;

namespace api.Services.Implemenattions
{
    public class FrequenciasServiceImpl : IFrequenciasService
    {
        private SQLContext _context;

        public FrequenciasServiceImpl(SQLContext context)
        {
            _context = context;
        }
        public Frequencias Create(Frequencias frequencias)
        {
            try
            {
                _context.Add(frequencias);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return frequencias;
        }

        public void Delete(long id)
        {
            var result = _context.Frequencias.SingleOrDefault(f => f.id.Equals(id));
            try
            {
                if (result != null) _context.Frequencias.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Frequencias> FindAll()
        {
            return _context.Frequencias.ToList();
        }

        public Frequencias FindById(long id)
        {
            return _context.Frequencias.SingleOrDefault(f => f.id.Equals(id));
        }

        public Frequencias Update(Frequencias frequencias)
        {
            if (!Exist(frequencias.id)) return new Frequencias();
            var result = _context.Frequencias.SingleOrDefault(f => f.id.Equals(frequencias.id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(frequencias);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return frequencias;
        }

        private bool Exist(long id)
        {
            return _context.Frequencias.Any(f => f.id.Equals(id));
        }
    }
}
