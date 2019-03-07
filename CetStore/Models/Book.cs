using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0,10000)]
        public Decimal Price { get; set; }
    }
}
