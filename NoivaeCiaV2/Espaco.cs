using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Espaco
    {
        private char Id { get; set; }
        public int Capacidade { get; set; }
        public List<Agendamento>? Agendamentos { get; set; }


        public Espaco(char Id, int Capacidade) { 
            this.Id = Id;
            this.Capacidade = Capacidade;
        }
    }
}
