using AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationCore.Interfaces.Repository
{
    public interface IMembroRepository : IBaseRepository<Membro>
    {
        IEnumerable<Membro> ObterPorProfissao(string profissao);
    }
}
