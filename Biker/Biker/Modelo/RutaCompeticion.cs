namespace Biker.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RutaCompeticion")]
    public partial class RutaCompeticion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompeticionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RutaID { get; set; }

        public int? Orden { get; set; }

        public virtual Competicion Competicion { get; set; }

        public virtual Ruta Ruta { get; set; }
    }
}
