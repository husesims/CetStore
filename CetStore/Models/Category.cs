using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
