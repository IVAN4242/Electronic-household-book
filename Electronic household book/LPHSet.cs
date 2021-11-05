namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LPHSet")]
    public partial class LPHSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LPHSet()
        {
            MembersSet = new HashSet<MembersSet>();
            TechnicSet = new HashSet<TechnicSet>();
        }

        public int Id { get; set; }

        public int personal_account { get; set; }

        [Required]
        public string addres { get; set; }

        public DateTime date_creatoin { get; set; }

        public DateTime? date_deletion { get; set; }

        public int Animals_Id { get; set; }

        public int Lands_Id { get; set; }

        public virtual AnimalsSet AnimalsSet { get; set; }

        public virtual LandsSet LandsSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersSet> MembersSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnicSet> TechnicSet { get; set; }
    }
}
