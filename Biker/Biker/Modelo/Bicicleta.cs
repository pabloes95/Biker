namespace Biker.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bicicleta")]
    public partial class Bicicleta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BicicletaID { get; set; }

        public int? tipo { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public int? CorredorID { get; set; }

        public virtual Corredor Corredor { get; set; }

        public virtual Tipo Tipo1 { get; set; }
    }
}
