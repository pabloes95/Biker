using Biker.Formularios;
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

namespace Biker
{
    public partial class Form1 : Form
    {
        private static BikerContext _bikerContext;

        public static BikerContext BikerContext
        {
            get
            {
                if (_bikerContext == null)
                {
                    _bikerContext = new BikerContext();
                }
                return _bikerContext;
            }
        }


        public static IEnumerable<Ruta> Rutas { get
            {
                return BikerContext.Rutas.ToList();
            }
        }
        public static IEnumerable<RutaCompeticion> RutasCompeticiones
        {
            get
            {
                return BikerContext.RutaCompeticions.ToList();
            }
        }

        public static IEnumerable<RutaCorredor> Carreras
        {
            get
            {
                return BikerContext.RutaCorredors.ToList();
            }
        }

        public static IEnumerable<Competicion> Competiciones
        {
            get
            {
                return BikerContext.Competicions.ToList();
            }
        }

        public static IEnumerable<Corredor> Corredores
        {
            get
            {
                return BikerContext.Corredors.ToList();
            }
        }





        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnVerEditar_Click(object sender, EventArgs e)
        {
            using (var formVerEditar = new FrmVerEditar(Form1.BikerContext))
            {
                formVerEditar.ShowDialog(this);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            using (var formFiltros = new FrmFiltros(Form1.BikerContext))
            {
                formFiltros.ShowDialog(this);
            }
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            using (var formInformes = new FrmInformes(Form1.BikerContext))
            {
                formInformes.ShowDialog(this);
            }
        }
    }
}
