using Project.BLL.RepositoryPattern.BaseRepository;
using Project.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.RepositoryClasses
{
    public class BookRepository : RepositoryBase<Book>
    {
        public readonly DataView DefaultView;
        public object filter;
    }
}
