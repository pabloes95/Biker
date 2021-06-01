using Biker.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biker.Modelo.Informes
{
    class Rapido
    {
        public Rapido(Corredor corredor, Ruta ruta)
        {
            this.Corredor = corredor;
            this.Ruta = ruta;
        }

        public Corredor Corredor { get; }
        public Ruta Ruta { get; }
    }
}
