using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EditPageModel
    {
        public KsiazkaModel KsiazkaModel { get; set; }
        public List<AutorModel> AutorModelList { get; set; }

        public EditPageModel()
        {
        
        }

        public EditPageModel(KsiazkaModel KsiazkaModel, List<AutorModel> AutorModelList)
        {
            this.KsiazkaModel = KsiazkaModel;
            this.AutorModelList = AutorModelList;
        }
    }
}