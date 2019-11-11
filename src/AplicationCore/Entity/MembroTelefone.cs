using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationCore.Entity
{
    public class MembroTelefone
    {

        public MembroTelefone()
        {

        }

        public int MembroTelefoneId { get; set; }

        public string TipoTelefone { get; set; }

        public string Numero { get; set; }

        public int MembroId { get; set; }
    }
}
