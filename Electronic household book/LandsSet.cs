namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LandsSet")]
    public partial class LandsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LandsSet()
        {
            LPHSet = new HashSet<LPHSet>();
        }

        public int Id { get; set; }

        [Required]
        public string number { get; set; }

        public double square { get; set; }

        public bool owner { get; set; }

        [Required]
        public string fio_owner { get; set; }

        [Required]
        public string fio_user { get; set; }

        public double price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LPHSet> LPHSet { get; set; }
    }
}
