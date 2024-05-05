using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Agendamento
    {
        private DateTime data;
        private Espaco espaco;


        public Agendamento(DateTime data, Espaco espaco)
        {
            this.data = data;
            this.espaco = espaco;
        }
    }
}
