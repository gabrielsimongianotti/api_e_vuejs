using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.Model.Context;

namespace api.Services.Implemenattions
{
    
    public class MedicoServiceImpl : IMedicoService
    {
        private SQLContext _context;
        public MedicoServiceImpl(SQLContext context) {
            _context = context;
        }
        public Medico Create(Medico medico)
        {
            try
            {
                _context.Add(medico);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return medico;
        }

        public void Delete(long crm)
        {
            var result = _context.Medico.SingleOrDefault(m => m.crm.Equals(crm));
            try
            {
                if (result != null) _context.Medico.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Medico> FindAll()
        {
            return _context.Medico.ToList();
        }


        public Medico FindById(long crm)
        {
            return _context.Medico.SingleOrDefault(p => p.crm.Equals(crm));
        }

        public Medico Update(Medico medico)
        {
            if (!Exist(medico.crm)) return new Medico();
            var result = _context.Medico.SingleOrDefault(m => m.crm.Equals(medico.crm));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(medico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return medico;
        }

        private bool Exist(long? crm)
        {
            return _context.Medico.Any(m => m.crm.Equals(crm));
        }
    }
}
