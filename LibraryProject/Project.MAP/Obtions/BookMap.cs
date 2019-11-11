using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Obtions
{
    public class BookMap : BaseMap<Book>
    {
        public BookMap()
        {
            ToTable("Kitaplar");
            Property(x => x.Title).HasColumnName("Kitap Adi").IsRequired();
            
        }
    }
}
