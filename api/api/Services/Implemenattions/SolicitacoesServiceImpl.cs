using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.Model.Context;

namespace api.Services.Implemenattions
{
    public class SolicitacoesServiceImpl : ISolicitacoesService
    {
        private SQLContext _context;
        public SolicitacoesServiceImpl(SQLContext context){
            _context = context;
        }
        public Solicitacoes Create(Solicitacoes solicitacoes)
        {
            try
            {
                _context.Add(solicitacoes);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return solicitacoes;
        }

        public void Delete(long id)
        {
            var result = _context.Solicitacoes.SingleOrDefault(s => s.id.Equals(id));
            try
            {
                if (result != null) _context.Solicitacoes.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitacoes> FindAll()
        {
            return _context.Solicitacoes.ToList();
        }

        public Solicitacoes FindById(long id)
        {
            return _context.Solicitacoes.SingleOrDefault(s => s.id.Equals(id));
        }

        public Solicitacoes Update(Solicitacoes solicitacoes)
        {
            if (!Exist(solicitacoes.id)) return new Solicitacoes();
            var result = _context.Solicitacoes.SingleOrDefault(s => s.id.Equals(solicitacoes.id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(solicitacoes);
                _context.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
            return solicitacoes;
        }

        private bool Exist(long id)
        {
            return _context.Solicitacoes.Any(s => s.id.Equals(id));
        }
    }
}
