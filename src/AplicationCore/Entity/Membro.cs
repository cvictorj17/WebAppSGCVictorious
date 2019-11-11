using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationCore.Entity
{
    public class Membro
    {

        public Membro()
        {

        }

        public int MembroId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string CNH { get; set; }

        public string Profissao { get; set; }

        public int? CargoId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }
    }

}
