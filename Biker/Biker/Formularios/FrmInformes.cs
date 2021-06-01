using Biker.Modelo;
using Biker.Modelo.Informes;
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
    public partial class FrmInformes : Form
    {
        public FrmInformes(BikerContext bikerContext)
        {
            InitializeComponent();
            this.BikerContext = bikerContext;
        }

        public BikerContext BikerContext { get; private set; }
      

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            CargarDataSources();
        }

        private void CargarDataSources()
        {
            ganadorBindingSource.DataSource = ObtenerGanadores();
        }

        private IEnumerable<Ganador> ObtenerGanadores()
        {
            var ganadores = new List<Ganador>();
            foreach (var competicion in Form1.Competiciones)
            {
                Corredor corredor = ObtenerCorredorMasRapidoTodasRutas(competicion);
                ganadores.Add(new Ganador(corredor, competicion));
            }
            return ganadores;
        }

        private static Corredor ObtenerCorredorMasRapidoTodasRutas(Competicion competicion)
        {
            var rutasCompeticion = competicion.RutaCompeticions.Select(rc => rc.Ruta);
            var corredoresTiempos = ObtenerTiemposCorredores(rutasCompeticion);
            var corredoresTodasRutasCompletadas = ObtenerCorredoresConTodasRutasCompletadas(rutasCompeticion);
            return ObtenerCorredorMasRapido(corredoresTiempos, corredoresTodasRutasCompletadas);
        }

        private static Corredor ObtenerCorredorMasRapido(Dictionary<Corredor, TimeSpan> corredoresTiempos, List<Corredor> corredoresTodasRutasCompletadas)
        {
            if (corredoresTodasRutasCompletadas.Count < 1)
            {
                return corredoresTiempos.OrderBy(ct => ct.Value.Ticks).FirstOrDefault().Key;
            }
            return corredoresTiempos.Where(ct => EstaEnLista(corredoresTodasRutasCompletadas, ct)).OrderBy(ct => ct.Value.Ticks).FirstOrDefault().Key;
        }

        private static bool EstaEnLista(List<Corredor> corredoresTodasRutasCompletadas, KeyValuePair<Corredor, TimeSpan> ct)
        {
            return corredoresTodasRutasCompletadas.Contains(ct.Key);
        }

        private static Dictionary<Corredor, TimeSpan> ObtenerTiemposCorredores(IEnumerable<Ruta> rutasCompeticion)
        {
            var corredoresTiempos = new Dictionary<Corredor, TimeSpan>();
            foreach (var corredor in Form1.Corredores)
            {
                var TiempoTotal = new TimeSpan(rutasCompeticion.Sum(r => r.RutaCorredors.Where(rc => rc.Corredor == corredor).Sum(rc => rc.Tiempo.Value.Ticks)));
                corredoresTiempos.Add(corredor, TiempoTotal);
            }
            return corredoresTiempos;
        }

        private static List<Corredor> ObtenerCorredoresConTodasRutasCompletadas(IEnumerable<Ruta> rutasCompeticion)
        {
            var corredores = new List<Corredor>();
            foreach (var corredor in Form1.Corredores)
            {
                if (CorredorHaCompletadoTodasLasRutas(rutasCompeticion, corredor))
                {
                    corredores.Add(corredor);
                }
            }
            return corredores;
        }

        private static bool CorredorHaCompletadoTodasLasRutas(IEnumerable<Ruta> rutasCompeticion, Corredor corredor)
        {
            var carreras = rutasCompeticion.SelectMany(rc => rc.RutaCorredors).Where(r => r.Corredor == corredor);
            return carreras.All(r=> r.Completada.GetValueOrDefault()) && carreras.Count() == rutasCompeticion.Count();
        }
    }
}
