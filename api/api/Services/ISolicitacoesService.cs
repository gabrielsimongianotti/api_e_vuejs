using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface ISolicitacoesService
    {
        Solicitacoes Create(Solicitacoes solicitacoes);
        Solicitacoes FindById(long id);
        List<Solicitacoes> FindAll();
        Solicitacoes Update(Solicitacoes solicitacoes);
        void Delete(long id);
    }
}
