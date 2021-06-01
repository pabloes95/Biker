using Biker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biker.Modelo
{
    partial class Categoria : IElementoNuloUI
    {
        public IElementoNuloUI ObtenerElementoNuloUI()
        {
            return new Categoria() { Nombre = "", CategoriaID = -1 };

        }
    }
}
