using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceFuncionario : ServiceBase<Funcionario>, IServiceFuncionario
    {
        private readonly IRepositoryFuncionario repositoryFuncionario;

        public ServiceFuncionario(IRepositoryFuncionario repositoryFuncionario)
            : base(repositoryFuncionario)
        {
            this.repositoryFuncionario = repositoryFuncionario;
        }
    }
}