namespace Biker.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RutaCorredor")]
    public partial class RutaCorredor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CorredorID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RutaID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public bool? Completada { get; set; }

        public TimeSpan? Tiempo { get; set; }

        public decimal? Distancia { get; set; }

        public virtual Corredor Corredor { get; set; }

        public virtual Ruta Ruta { get; set; }
    }
}
