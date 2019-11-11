using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Models
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public int? CategoryID { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
