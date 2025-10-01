using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller.Servicios {
    internal class Servicio {

        public FechaResuelta ProximaFecha(FechaSolicitada fechaSolicitada) {
            if (fechaSolicitada == null) {
                throw new Exception("Error");
            }

            if (!fechaSolicitada.Activado) {
                return new FechaResuelta {
                    NuevaFecha = fechaSolicitada.Fecha,
                    Descripcion = "Desactivado: No se ha realizado ninguna modificación"
                };
            }

            switch (fechaSolicitada.Periodicidad) {
                case Periodicidad.Unico:
                    return CalculaUnico(fechaSolicitada);
                case Periodicidad.Recurrente:
                    return CalculaUnico(fechaSolicitada);
                default:
                    throw new Exception("No se reconoce este tipo de Periodicidad.");
            }
        }

        private FechaResuelta CalculaUnico(FechaSolicitada fechaSolicitada) {
            if (fechaSolicitada.FechaReemplazo != null) {
                return new FechaResuelta {
                    NuevaFecha = fechaSolicitada.FechaReemplazo.Value,
                    Descripcion = $"Cambio Único: Se ha cambiado la fecha a {fechaSolicitada.FechaReemplazo}"
                };
            }

            if (fechaSolicitada.Offset != null) {
                var nuevaFecha = fechaSolicitada.Fecha.Add(fechaSolicitada.Offset.Value);
                return new FechaResuelta {
                    NuevaFecha = nuevaFecha,
                    Descripcion = $"Cambio Único: Se ha cambiado la fecha a {nuevaFecha}"
                };
            }

            throw new Exception("El calculo unico requiere de fecha de reemplazo o un offset de dias.");
        }
    }
}
