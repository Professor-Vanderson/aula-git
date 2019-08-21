using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste.Model
{
    public class Classe
    {
        public Classe()
        {
            this.PROFISSIONAL = new HashSet<PROFISSIONAL>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<PROFISSIONAL_CBOS> PROFISSIONAL_s { get; set; }
    }
}
