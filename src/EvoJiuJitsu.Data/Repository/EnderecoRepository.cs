using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(EvoDbcontext db) : base(db){}

        public async Task<Endereco> ObterAtletaEnderecoPorAtleta(Guid AtletaId)
        {
            return await _db.Enderecos.AsNoTracking().FirstOrDefaultAsync(a =>a.AtletaId == AtletaId);
        }
    }
}
