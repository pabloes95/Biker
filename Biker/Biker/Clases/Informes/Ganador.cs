using Biker.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo.Informes
{
    class Ganador
    {
        public Ganador(Corredor corredor, Competicion competicion)
        {
            this.Corredor = corredor;
            this.Competicion = competicion;
        }

        public Corredor Corredor { get; }
        public Competicion Competicion { get; }

        public string Nombre
        {
            get
            {
                return $"{Corredor.Nombre} {Corredor.Apellidos}";
            }
        }

        public string NombreCompeticion
        {
            get
            {
                return Competicion.Nombre;
            }
        }

        public string Premio
        {
            get
            {
                return Competicion.Premio;
            }
        }

        public string DistanciaTotal
        {
            get
            {
                return Competicion.RutaCompeticions.Sum(rc=> rc.Ruta.Distancia).ToString();
            }
        }

        public string TiempoTotal
        {
            get
            {
                var timeSpan = new TimeSpan(Competicion.RutaCompeticions.Sum(rc => rc.Ruta.RutaCorredors.Where(carrera => carrera.Corredor == Corredor).Sum(carrera => carrera.Tiempo.Value.Ticks)));
                return timeSpan.ToString();
            }
        }




    }
}
