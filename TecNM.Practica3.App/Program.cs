using System;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;


namespace TecNM.Practica3.App;

public static class Program{
    public static void Main(string[] args){

       
        float salario = 0;

        
        Console.WriteLine("Escribe tu salario: ");
        //castea
        Single.TryParse(System.Console.ReadLine(), out salario);

        
        var sal = new Salario {SalarioO = salario};

        var service = new ISRServices();
        var managers = new ISRManagers(service);

        ISR isr = managers.GetISR(sal);
        Console.WriteLine($"ISR {isr.index} ");
    }
}
