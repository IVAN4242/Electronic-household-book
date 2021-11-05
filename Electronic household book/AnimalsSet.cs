namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnimalsSet")]
    public partial class AnimalsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnimalsSet()
        {
            LPHSet = new HashSet<LPHSet>();
        }

        public int Id { get; set; }

        public int? cattle { get; set; }

        public int? pigs { get; set; }

        public int? sheep { get; set; }

        public int? goats { get; set; }

        public int? rabbits { get; set; }

        public int? horses { get; set; }

        public int? birds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LPHSet> LPHSet { get; set; }
    }
}
