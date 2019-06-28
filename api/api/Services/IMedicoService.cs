using api.Model;
using System.Collections.Generic;


namespace api.Services
{
    public interface IMedicoService
    {
        Medico Create(Medico medico);
        Medico FindById(long crm);
        List<Medico> FindAll();
        Medico Update(Medico medico);
        void Delete(long crm);
    }
}
