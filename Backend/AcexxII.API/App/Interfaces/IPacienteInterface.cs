using AcexxII.API.Models;

namespace AcexxII.API.Repositories
{
    public interface IPacienteInterface
    {

        Task RegisterPaciente(UserPaciente paciente);
        
    }
}
