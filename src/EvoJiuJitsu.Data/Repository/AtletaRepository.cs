﻿using EvoJiuJitsu.Business.Interfaces;
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
    public class AtletaRepository : Repository<Atleta>, IAtletaRepository
    {
        public AtletaRepository(EvoDbcontext db) : base(db) {}

        public async Task<IEnumerable<Atleta>> ObterAtletasOrdemAlfabetica()
        {
            return await _db.Atletas.AsNoTracking()
                                    .OrderBy(x => x.Nome)
                                    .ToListAsync();
        }
    }
}
