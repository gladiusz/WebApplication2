using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MainPageModel
    {
        public List<KsiazkaModel> KsiazkaModelList { get; set; }
        public AutorRepository Autor { get; set; }

        public MainPageModel(List<KsiazkaModel> KsiazkaModelList, AutorRepository Autor)
        {
            this.KsiazkaModelList = KsiazkaModelList;
            this.Autor = Autor;
        }
    }
}