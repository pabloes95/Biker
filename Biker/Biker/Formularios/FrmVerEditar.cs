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
    public partial class FrmVerEditar : Form
    {
        private BikerContext BikerContext;
        private bool cargado;
        public FrmVerEditar(BikerContext BikerContext)
        {
            InitializeComponent();
            this.BikerContext = BikerContext;

        }
        public List<Corredor> Corredores
        {
            get
            {
                return (List<Corredor>)corredorBindingSource.DataSource;
            }
            set
            {
                corredorBindingSource.DataSource = value;
            }
        }
        public List<RutaCorredor> Carreras
        {
            get
            {
                return (List<RutaCorredor>)rutaCorredorBindingSource.DataSource;
            }
            set
            {
                rutaCorredorBindingSource.DataSource = value;
            }
        }
        public List<Ruta> Rutas
        {
            get
            {
                return (List<Ruta>)rutaBindingSource.DataSource;
            }
            set
            {
                rutaBindingSource.DataSource = value;
            }
        }
        public List<Competicion> Competiciones
        {
            get
            {
                return (List<Competicion>)competicionBindingSource.DataSource;
            }
            set
            {
                competicionBindingSource.DataSource = value;
            }
        }
        public List<RutaCompeticion> RutaCompeticiones
        {
            get
            {
                return (List<RutaCompeticion>)rutaCompeticionBindingSource.DataSource;
            }
            set
            {
                rutaCompeticionBindingSource.DataSource = value;
            }
        }


        private void FrmVerEditar_Load(object sender, EventArgs e)
        {
            EstablecerDataSourceCorredores();
            EstablecerDataSourceRutas();
            EstablecerDataSourceCompeticion();
            EstablecerDataSourceCategoria();
            EstablecerDataSourceComboBoxRutas();
            cargado = true;
        }

        private void EstablecerDataSourceComboBoxRutas()
        {
            AgregarDataSourceRutasComboBox(rutaComboBoxCarrera);
            AgregarDataSourceRutasComboBox(rutaComboBoxCompeticion);
        }

      

        private void EstablecerDataSourceCompeticion()
        {
            Competiciones = BikerContext.Competicions.ToList();
        }

        private void EstablecerDataSourceRutas()
        {
            Rutas = BikerContext.Rutas.ToList();
            EstablecerDataSourceComboBoxRutas();
        }

        private void AgregarDataSourceRutasComboBox(DataGridViewComboBoxColumn dataGridViewComboBoxColumn)
        {
            dataGridViewComboBoxColumn.DataSource = new BindingList<Ruta>(BikerContext.Rutas.ToList());
            dataGridViewComboBoxColumn.DisplayMember = nameof(Ruta.Nombre);
            dataGridViewComboBoxColumn.ValueMember = nameof(Ruta.RutaID);
        }
       

        private void EstablecerDataSourceCorredores()
        {
            Corredores = BikerContext.Corredors.ToList();
        }

        private void EstablecerDataSourceCategoria()
        {
            categoriaDataGridViewTextBoxColumn.DataSource = new BindingList<Categoria>(BikerContext.Categorias.ToList());
            categoriaDataGridViewTextBoxColumn.DisplayMember = nameof(Categoria.Nombre);
            categoriaDataGridViewTextBoxColumn.ValueMember = nameof(Categoria.CategoriaID);
        }

       

       

        private void CargarRutasCompeticionSeleccionada()
        {
            var competicionSeleccionada = ObtenerElementoSeleccionado<Competicion>(GrvCompeticion);
            RutaCompeticiones = BikerContext.RutaCompeticions.ToList().Where(rc => rc.Competicion == competicionSeleccionada).ToList();
        }

        

        private void CargarRutasDeCorredorSeleccionado()
        {
            var corredorSeleccionado = ObtenerElementoSeleccionado<Corredor>(grvCorredores);
            Carreras = BikerContext.RutaCorredors.ToList().Where(rc => rc.Corredor == corredorSeleccionado).ToList();
        }

       

        private void AñadirCorredor()
        {
            BikerContext.Corredors.Add(new Corredor());
            BikerContext.SaveChanges();
            EstablecerDataSourceCorredores();
        }

        private void AñadirRuta()
        {
            BikerContext.Rutas.Add(new Ruta());
            BikerContext.SaveChanges();
            EstablecerDataSourceRutas();
        }

        private void AñadirCompeticion()
        {
            BikerContext.Competicions.Add(new Competicion());
            BikerContext.SaveChanges();
            EstablecerDataSourceCompeticion();
        }

        private void AñadirRutaCorredor()
        {
            var corredorSeleccionado = ObtenerElementoSeleccionado<Corredor>(grvCorredores);
            if (corredorSeleccionado == null)
            {
                return;
            }
            BikerContext.RutaCorredors.Add(new RutaCorredor(corredorSeleccionado));
            BikerContext.SaveChanges();
            CargarRutasDeCorredorSeleccionado();
        }

        private void AñadirRutaCompeticion()
        {
            var competicionSeleccionada = ObtenerElementoSeleccionado<Competicion>(GrvCompeticion);
            if (competicionSeleccionada == null)
            {
                return;
            }
            BikerContext.RutaCompeticions.Add(new RutaCompeticion(competicionSeleccionada));
            BikerContext.SaveChanges();
            CargarRutasCompeticionSeleccionada();
        }

        private T ObtenerElementoSeleccionado<T>(DataGridView dataGridView)
        {
            if (!(dataGridView.SelectedRows.Count > 0))
            {
                return default(T);
            }
            return (T)dataGridView.SelectedRows[0].DataBoundItem;
        }       



        #region eventos

        private void GrvCompeticion_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            if (!(GrvCompeticion.SelectedRows.Count > 0))
            {
                return;
            }
            CargarRutasCompeticionSeleccionada();
        }

        private void grvCorredores_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            if (!(grvCorredores.SelectedRows.Count > 0))
            {
                return;
            }
            CargarRutasDeCorredorSeleccionado();
        }

        private void BtnAñadirCorredor_Click(object sender, EventArgs e)
        {
            AñadirCorredor();
        }

        private void BtnAñadirCarrera_Click(object sender, EventArgs e)
        {
            AñadirRutaCorredor();
        }        

        private void BtnAñadirRuta_Click(object sender, EventArgs e)
        {
            AñadirRuta();
        }

        private void btnAñadirCompeticion_Click(object sender, EventArgs e)
        {
            AñadirCompeticion();
        }

        private void BtnAñadirRutaCompeticion_Click(object sender, EventArgs e)
        {
            AñadirRutaCompeticion();
        }


        #endregion

        private void grv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!cargado) return;
            BikerContext.SaveChanges();
        }
    }
}
