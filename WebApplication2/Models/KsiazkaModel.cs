using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class KsiazkaModel
    {
        public Guid Id { get; set; }
        public Guid AutorId { get; set; }
        public enum OkladkaTyp { brakInfo, twarda, miekka };
        [Required(ErrorMessage = "Podaj Tytul")]
        [StringLength(200, ErrorMessage = "Adres max 200 znaków")]
        public string Tytul { get; set; }
        public int IloscStron { get; set; }
        public OkladkaTyp Okladka { get; set; }
    }
}