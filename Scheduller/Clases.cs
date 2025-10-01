using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public enum Periodicidad
    {
        Unico,
        Recurrente
    }

    public class FechaSolicitada
    {
        public DateTimeOffset Fecha { get; set; }
        public DateTimeOffset FechaInicio { get; set; }
        public DateTimeOffset FechaFin {  get; set; }
        public Periodicidad Periodicidad { get; set; }
        public int OffsetDias { get; set; }
}
