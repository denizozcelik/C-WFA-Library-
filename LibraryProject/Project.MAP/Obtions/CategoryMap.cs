using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Obtions
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategoriler");
            Property(x => x.CategoryName).HasColumnName("Kategori Adi").IsRequired();
            Property(x => x.Description).HasColumnName("Acicklama").IsOptional();
        }
    }
}
