using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class KsiazkaModel
    {
        public enum OkladkaTyp { brakInfo, twarda, miekka };

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int IloscStron { get; set; }
        public OkladkaTyp Okladka { get; set; }
    }
}