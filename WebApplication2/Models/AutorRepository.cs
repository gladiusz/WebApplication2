using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AutorRepository
    {
        static List<AutorModel> autorzy = new List<AutorModel>();

        public List<AutorModel> GetList()
        {
            return autorzy;
        }
        public AutorModel Get(Guid id)
        {
            return autorzy.SingleOrDefault(a => a.Id == id);
        }

        public void Add(AutorModel autor)
        {
            autor.Id = Guid.NewGuid();
            autorzy.Add(autor);
        }
    }
}