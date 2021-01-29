using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apihorasdesenvolvedor.Dominio.Interfaces.Servico.DesenvolvedorXProjeto
{
    public interface IDesenvolvedorXProjetoService
    {
        Task<DesenvolvedorXProjetoEntity> Get(int id);
        Task<IEnumerable<DesenvolvedorXProjetoEntity>> GetAll();
        Task<DesenvolvedorXProjetoEntity> Post(DesenvolvedorXProjetoEntity desenvolvedorXProjeto);
        Task<DesenvolvedorXProjetoEntity> Put(DesenvolvedorXProjetoEntity desenvolvedorXProjeto);
        Task<bool> Delete(int id);
    }
}
