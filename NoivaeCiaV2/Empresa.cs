﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoivaeCiaV2
{
    internal class Empresa
    {
        private Espaco[] Espacos = new Espaco[8];

        public Empresa()
        {
            Espaco EspacoA = new Espaco('A', 100);
            Espaco EspacoB = new Espaco('B', 100);
            Espaco EspacoC = new Espaco('C', 100);
            Espaco EspacoD = new Espaco('D', 100);
            Espaco EspacoE = new Espaco('E', 200);
            Espaco EspacoF = new Espaco('F', 200);
            Espaco EspacoG = new Espaco('G', 50);
            Espaco EspacoH = new Espaco('H', 500);

            Espacos[0] = EspacoA;
            Espacos[1] = EspacoB;
            Espacos[2] = EspacoC;
            Espacos[3] = EspacoD;
            Espacos[4] = EspacoE;
            Espacos[5] = EspacoF;
            Espacos[6] = EspacoG;
            Espacos[7] = EspacoH;  
        }

       public string RealizarAgendamento(int qtdPessoas)
        {
            Espaco EspacoAgendado = EncontrarEspacoPorTamanho(TamanhoEspaco(qtdPessoas));
            DateTime DataEncontrada = EncontrarData(EspacoAgendado);

            Agendamento AgendamentoAtual = new Agendamento(DataEncontrada, EspacoAgendado);

            EspacoAgendado.Agendamentos.Add(AgendamentoAtual);

            return AgendamentoAtual.ToString();
        }
      
        public int TamanhoEspaco(int qtdPessoas)

        {
            int numeroProximoMaior = int.MaxValue;
            int diferencaMinima = int.MaxValue; 

            foreach (Espaco espaco in Espacos)
            {
                if (espaco.Capacidade >= qtdPessoas && espaco.Capacidade - qtdPessoas < diferencaMinima)
                {
                    diferencaMinima = espaco.Capacidade - qtdPessoas;
                    numeroProximoMaior = espaco.Capacidade;
                }
            }
            return numeroProximoMaior;
        }

       public Espaco EncontrarEspacoPorTamanho(int tamanhoEspaco)
        {
            for (int i = 0; i < Espacos.Length; i++)
            {
                if (Espacos[i].Capacidade == tamanhoEspaco)
                {
                    return Espacos[i];
                }
            }
            return Espacos[0];
        }

       public DateTime EncontrarData(Espaco Espaco)
        {
           Data data = new Data();
            bool DataInvalida = true;
            data.Hoje = Data.AdicionarMes(data.Hoje);

            if(Espaco.Agendamentos.Count > 0)
            {
                Agendamento ultimoAgendamento = Espaco.Agendamentos[Espaco.Agendamentos.Count - 1];
                if (ultimoAgendamento == null)
                {
                    if (Data.ehSexta(data.Hoje))
                    {
                        return data.Hoje;
                    }
                    else if (Data.ehSabado(data.Hoje))
                    {
                        return data.Hoje;
                    }
                    else
                    {
                        return data.Hoje;
                    }
                }


                while (DataInvalida)
                {
                    if (ultimoAgendamento.Data == data.Hoje)
                    {
                        data.Hoje = Data.AdicionarDia(data.Hoje);
                    }
                    else
                    {
                        DataInvalida = false;
                    }
                }

                DataInvalida = true;
            }
         
            while (DataInvalida)
            {
                if (!Data.ehSexta(data.Hoje) && !Data.ehSabado(data.Hoje))
                {
                    data.Hoje = Data.AdicionarDia(data.Hoje);
                }
                else
                {
                    DataInvalida = false;
                }
            }
            return data.Hoje;
        }

    }




}
