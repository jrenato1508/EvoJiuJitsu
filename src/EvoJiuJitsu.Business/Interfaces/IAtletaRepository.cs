using EvoJiuJitsu.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Interfaces
{
    public interface IAtletaRepository : IRepository<Atleta>
    {
        Task<IEnumerable<Atleta>> ObterAtletasOrdemAlfabetica();
    }
}
