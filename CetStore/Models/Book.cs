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

        [Display(Name="Kitap Adı")]
        [Required(ErrorMessage ="Kitap Adı zorunlu")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Kitap adı 3 ile 100 karakter arasında olmalı")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0,10000)]
        public Decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
