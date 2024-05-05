using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Data
    {
        public DateTime Hoje { get; set; }

        public Data()
        {
            this.Hoje = DateTime.Today;
        }

        public static DateTime AdicionarDia(DateTime data)
        {
            return data.AddDays(1);
        }

        public static DateTime AdicionarSemana(DateTime data)
        {
            return data.AddDays(7);
        }
        public static DateTime AdicionarMes(DateTime data)
        {
            return data.AddDays(30);
        }

        public static bool ehSexta(DateTime dia) {
            return dia.DayOfWeek == DayOfWeek.Friday;
        }

        public static bool ehSabado(DateTime dia)
        {
            return dia.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}
