namespace Electronic_household_book
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersSet")]
    public partial class UsersSet
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string surname { get; set; }

        public string patronymic { get; set; }

        public int role { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }
    }
}
