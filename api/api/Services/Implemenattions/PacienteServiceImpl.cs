using api.Model;
using api.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services.Implemenattions
{
    public class PacienteServiceImpl : IPacienteService
    {
        private SQLContext _context;

        public PacienteServiceImpl(SQLContext context)
        {
            _context = context;
        }

        Paciente IPacienteService.Create(Paciente paciente)
        {
            try
            {
                _context.Add(paciente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paciente;
        }

        void IPacienteService.Delete(long cartao)
        {
            var result = _context.Paciente.SingleOrDefault(p => p.cartao.Equals(cartao));
            try
            {
                if (result != null) _context.Paciente.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<Paciente> IPacienteService.FindAll()
        {
            return _context.Paciente.ToList();
        }

        Paciente IPacienteService.FindById(long cartao)
        {
            return _context.Paciente.SingleOrDefault(p => p.cartao.Equals(cartao));
        }

        Paciente IPacienteService.Update(Paciente paciente)
        {
            if(!Exist(paciente.cartao)) return new Paciente();
            var result = _context.Paciente.SingleOrDefault(p => p.cartao.Equals(paciente.cartao));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(paciente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paciente;
        }

        private bool Exist(long cartao)
        {
            return _context.Paciente.Any(p => p.cartao.Equals(cartao));
        }
    }
}
