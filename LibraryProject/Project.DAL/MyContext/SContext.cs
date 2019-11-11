using Project.MAP.Obtions;
using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.MyContext
{
    public class SContext : DbContext
    {
        public SContext() : base("KutuphaneBaglantisi")
        {

        }

        private static SContext _dbInstance;
        public static SContext DBInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new SContext();
                }
                return _dbInstance;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Yazarlar { get; set; }
        public DbSet<Book> Kitaplar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}
