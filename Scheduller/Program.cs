using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


public class ProximaFecha
{
    public static DateTimeOffset ObtenProximaFecha(FechaSolicitada FechaInicial)
    {
        if (FechaInicial.Fecha >= FechaInicial.FechaInicio && FechaInicial.Fecha <= FechaInicial.FechaFin)
        {
            return FechaInicial.Periodicidad switch { 
                Periodicidad.Unico => FechaInicial.Fecha.AddDays(1),
                Periodicidad.Recurrente => FechaInicial.Fecha.AddDays(3)
            };
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ObtenProximaFecha(new FechaSolicitada()));
    }
}