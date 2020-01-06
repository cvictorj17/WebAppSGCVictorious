using AplicationCore.Entity;
using AplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class MembroRepository : EFRepository<Membro>, IMembroRepository
    {
        public MembroRepository(ContextVictorious dbContext): base(dbContext)
        {

        }

        public IEnumerable<Membro> ObterPorProfissao(string profissao)
        {
            return Buscar(x => x.Profissao == profissao);
        }
    }
}
