namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TechnicSet")]
    public partial class TechnicSet
    {
        public int Id { get; set; }

        public int? tractors { get; set; }

        public int? combine { get; set; }

        public int? plow { get; set; }

        public int? haymaker { get; set; }

        public int LPH_Id { get; set; }

        public virtual LPHSet LPHSet { get; set; }
    }
}
