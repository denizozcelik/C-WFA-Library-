using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Obtions
{
    public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).HasColumnName("Veri yaratma tarihi").IsOptional().HasColumnType("datetime2");

            Property(x => x.Status).HasColumnName("Veri durumu").IsOptional();

            Property(x => x.ModifiedDate).HasColumnType("datetime2").HasColumnName("Degistirme tarihi").IsOptional();
        }
    }
}
