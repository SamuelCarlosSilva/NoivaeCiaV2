// See https://aka.ms/new-console-template for more information
using NoivaeCiaV2;

Empresa empresa = new Empresa();
Console.WriteLine("Bem-vindo ao NoivaeCia!!");

Console.WriteLine("Para agendar sua cerimônia, digite a quantidade de pessoas que irão comparecer: ");

Console.WriteLine(empresa.RealizarAgendamento(int.Parse(Console.ReadLine())));


