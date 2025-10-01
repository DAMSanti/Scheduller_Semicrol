using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Periodicidad {
    Unico,
    Recurrente
}

public class FechaSolicitada {
    public DateTimeOffset Fecha { get; set; }
    public Boolean Activado { get; set; }
    public DateTimeOffset FechaInicio { get; set; }
    public DateTimeOffset FechaFin {  get; set; }
    public DateTimeOffset? FechaReemplazo { get; set; }
    public Periodicidad Periodicidad { get; set; }
    public TimeSpan? Offset { get; set; }
}

public class FechaResuelta {
    public DateTimeOffset NuevaFecha { get; set; }
    public string Descripcion { get; set; }
}
