using EvoJiuJitsu.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Interfaces
{
    public interface IAtletaService : IDisposable
    {
        Task Adicionar(Atleta atleta);
        
        Task Atualizar(Atleta atleta);

        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
