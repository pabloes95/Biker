using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo
{
    partial class RutaCorredor
    {
        public RutaCorredor() { }
        public RutaCorredor(Corredor corredor)
        {
            Ruta rutaInicializacion;
            if (!Form1.Carreras.Any(c => c.Corredor == corredor && c.Ruta == Form1.Rutas.FirstOrDefault()))
            {
                Corredor = corredor;
                rutaInicializacion = Form1.Rutas.FirstOrDefault();
            }
            else
            {
                rutaInicializacion = Form1.Rutas.Where(r => !corredor.RutaCorredors.Select(c => c.Ruta).Contains(r)).FirstOrDefault();
            }
            Corredor = corredor;
            Ruta = rutaInicializacion;
        }
    }
}
