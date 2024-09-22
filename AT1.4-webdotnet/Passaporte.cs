using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._4_webdotnet
{
    internal class Passaporte
    {
        // Chave primária e estrangeira
        public int PessoaId { get; set; }

        // Passaporte se vincula somente a uma Pessoa
        public Pessoa Pessoa { get; set; }
    }
}
