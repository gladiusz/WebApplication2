using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class KsiazkaRepository
    {
        static List<KsiazkaModel> ksiazki = new List<KsiazkaModel>();

        public List<KsiazkaModel> GetList()
        {
            return ksiazki;
        }

        public KsiazkaModel Get(Guid id)
        {
            return ksiazki.SingleOrDefault(a => a.Id == id);
        }

        public void Delete(Guid id)
        {
            ksiazki.RemoveAll(a=>a.Id == id);
        } 

        public void Add(KsiazkaModel ksiazka)
        {
            ksiazka.Id = Guid.NewGuid();
            ksiazki.Add(ksiazka);
        }

    }
}