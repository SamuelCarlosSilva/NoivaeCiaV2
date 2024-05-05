using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Espaco
    {
        private char Id;
        private int Capacidade;
        private List<Agendamento>? Agendamentos { get; set; }


        public Espaco(char Id, int Capacidade) { 
            this.Id = Id;
            this.Capacidade = Capacidade;
        }
    }
}
