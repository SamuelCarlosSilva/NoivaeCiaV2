using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Agendamento
    {
        public DateTime Data;
        private Espaco Espaco;


        public Agendamento(DateTime data, Espaco espaco)
        {
            this.Data = data;
            this.Espaco = espaco;
        }

        public override String ToString() {
            return "Espaço agendado: " + this.Espaco.ToString() +" "+ "Data escolhida: "+this.Data.ToString();
        }
    }
}
