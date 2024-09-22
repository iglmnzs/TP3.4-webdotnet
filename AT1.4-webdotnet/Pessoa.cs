using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._4_webdotnet
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Passaporte Passaporte { get; set; }  //Pessoa tem um Passaporte
    }
}
