using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Obtions
{
    public class AuthorMap : BaseMap<Author>
    {
        public AuthorMap()
        {
            ToTable("Yazarlar");
            Property(x => x.FirstName).HasColumnName("Yazar Ismi").IsRequired().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("Yazar Soyismi").HasMaxLength(50);
        }
    }
}
