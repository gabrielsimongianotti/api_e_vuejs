using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IFrequenciasService
    {
        Frequencias Create(Frequencias frequencias);
        Frequencias FindById(long id);
        List<Frequencias> FindAll();
        Frequencias Update(Frequencias frequencias);
        void Delete(long id);
    }
}
