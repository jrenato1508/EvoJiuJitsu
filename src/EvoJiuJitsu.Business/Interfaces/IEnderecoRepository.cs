using EvoJiuJitsu.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {

        Task<Endereco> ObterAtletaEnderecoPorAtleta(Guid id);
    }
}
