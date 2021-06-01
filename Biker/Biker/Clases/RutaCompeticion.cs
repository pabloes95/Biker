using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo
{
    partial class RutaCompeticion
    {
        public RutaCompeticion() { }
        public RutaCompeticion(Competicion competicion)
        {
            Ruta rutaInicializacion;

            if (!Form1.RutasCompeticiones.Any(c => c.Competicion == competicion && c.Ruta == Form1.Rutas.FirstOrDefault()))
            {
                Competicion = competicion;
                rutaInicializacion = Form1.Rutas.FirstOrDefault();
            }
            rutaInicializacion = Form1.Rutas.Where(r => !competicion.RutaCompeticions.Select(c => c.Ruta).Contains(r)).FirstOrDefault();
            Competicion = competicion;
            Ruta = rutaInicializacion;
        }
    }
}
