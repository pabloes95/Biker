using Biker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo
{
    partial class Corredor : IElementoNuloUI
    {
        public bool HaRealizadoRuta(Ruta ruta)
        {
            return ruta.RutaID < 0 ? true : RutaCorredors.Any(rc => rc.Ruta == ruta);
        }

        public bool ParticipaEnConmpeticion(Competicion competicion)
        {
            return competicion.CompeticionID < 0 ? true : RutaCorredors.Any(rc => rc.Ruta.RutaCompeticions.Any(rutaCompeticion => rutaCompeticion.Competicion == competicion));
        }

        public bool TieneCategoria(Categoria categoria)
        {
            return categoria.CategoriaID < 0 ? true : Categoria1 == categoria;
        }

        public IElementoNuloUI ObtenerElementoNuloUI()
        {
            return new Corredor() { Nombre = "", CorredorID = -1};
        }

        public int NumeroCarreras
        {
            get
            {
                return RutaCorredors.Count;
            }
        }


    }
}
