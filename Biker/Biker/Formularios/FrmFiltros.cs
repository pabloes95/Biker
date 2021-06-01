using Biker.Interfaces;
using Biker.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biker.Formularios
{
    public partial class FrmFiltros : Form
    {
        public FrmFiltros(BikerContext bikerContext)
        {
            InitializeComponent();
            this.BikerContext = bikerContext;
        }

        public BikerContext BikerContext { get; private set; }

        private void FrmFiltros_Load(object sender, EventArgs e)
        {
            corredorBindingSource.DataSource = null;

            EstablecerDataSourceCombosRuta();
            EstablecerDataSourceCombosCompeticion();
            EstablecerDataSourceCombosCategoria();
            EstablecerDataSourceCombosCorredores();
            SeleccionarElementosNulos();
            SetUnboundCloumnDataSet();
        }

        private void SeleccionarElementosNulos()
        {
            CbxRuta.SelectedValue  = CbxRutaCompeticion.SelectedValue = CbxCompeticion.SelectedValue = CbxCorredores.SelectedValue = CbxCategoria.SelectedValue = -1;
        }

        private void EstablecerDataSourceCombosCorredores()
        {
            var corredores = BikerContext.Corredors.ToList();
            corredorBindingSourceCombo.DataSource = AñadirElemetoNulo(corredores);

        }

        private void SetUnboundCloumnDataSet()
        {
            CarrerasTotales.DataPropertyName = nameof(Corredor.NumeroCarreras);
            NumeroRutas.DataPropertyName = nameof(Competicion.NumeroRutas);
        }

        private void EstablecerDataSourceCombosCategoria()
        {
            var categorias = BikerContext.Categorias.ToList();
            categoriaBindingSource.DataSource = AñadirElemetoNulo(categorias);
        }

        private void EstablecerDataSourceCombosCompeticion()
        {
            var competiciones = BikerContext.Competicions.ToList();
            competicionBindingSource.DataSource = AñadirElemetoNulo(competiciones);
        }

        private void EstablecerDataSourceCombosRuta()
        {
            var rutas = AñadirElemetoNulo(BikerContext.Rutas.ToList());
            rutaBindingSource.DataSource = rutas;
            rutaBindingSourceCompeticion.DataSource = rutas;
        }

        private List<T> AñadirElemetoNulo<T>(List<T> lista) where T : IElementoNuloUI, new()
        {
            var elementoNulo = new T().ObtenerElementoNuloUI();
            lista.Add((T)elementoNulo);
            return lista;
        }

        private T ObtenerElementoSeleccionado<T>(ComboBox comboBox)
        {
            T elementoSeleccinoado = (T)comboBox.SelectedItem;
            if (elementoSeleccinoado == null)
            {
                return default(T);
            }
            return elementoSeleccinoado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var competicionSeleccionada = ObtenerElementoSeleccionado<Competicion>(CbxCompeticion);
            var rutaSeleccionada = ObtenerElementoSeleccionado<Ruta>(CbxRuta);
            var categoriaSeleccionada = ObtenerElementoSeleccionado<Categoria>(CbxCategoria);
            corredorBindingSource.DataSource = BikerContext.Corredors.ToList().Where(c => c.HaRealizadoRuta(rutaSeleccionada) && c.ParticipaEnConmpeticion(competicionSeleccionada) && c.TieneCategoria(categoriaSeleccionada));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var corredorSeleccionado = ObtenerElementoSeleccionado<Corredor>(CbxCorredores);
            var rutaSeleccionada = ObtenerElementoSeleccionado<Ruta>(CbxRutaCompeticion);
            competicionBindingSourceGrid.DataSource = BikerContext.Competicions.ToList().Where(c => c.ParticipaCorredor(corredorSeleccionado) && c.ContieneRuta(rutaSeleccionada));

        }
    }
}
