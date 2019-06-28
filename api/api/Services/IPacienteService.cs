using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IPacienteService
    {
        Paciente Create(Paciente paciente);
        Paciente FindById(long cartao);
        List<Paciente> FindAll();
        Paciente Update(Paciente paciente);
        void Delete(long cartao);
    }
}
