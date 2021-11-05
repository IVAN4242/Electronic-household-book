namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MembersSet")]
    public partial class MembersSet
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string surname { get; set; }

        public string patronymic { get; set; }

        public DateTime date_birth { get; set; }

        public string kinship { get; set; }

        public bool gender { get; set; }

        public bool senior { get; set; }

        public int LPH_Id { get; set; }

        public virtual LPHSet LPHSet { get; set; }
    }
}
