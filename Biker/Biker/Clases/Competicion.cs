using Biker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo
{
    partial class Competicion : IElementoNuloUI
    {
        public int NumeroRutas
        {
            get
            {
                return RutaCompeticions.Count;
            }
        }

        public List<Ruta> ObtenerRutas()
        {
            return RutaCompeticions.Select(rc => rc.Ruta).ToList();
        }
        public IElementoNuloUI ObtenerElementoNuloUI()
        {
            return new Competicion() { Nombre = "", CompeticionID = -1};
        }

        internal bool ParticipaCorredor(Corredor corredor)
        {
            return corredor.CorredorID < 0 ? true : RutaCompeticions.Any(rc => rc.Ruta.RutaCorredors.Any(rutaCorredor => rutaCorredor.Corredor == corredor));
        }

        internal bool ContieneRuta(Ruta ruta)
        {
            return ruta.RutaID < 0 ? true : RutaCompeticions.Any(rc => rc.Ruta == ruta);
        }
    }
}
