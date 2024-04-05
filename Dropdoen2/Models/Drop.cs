using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dropdoen2.Models
{
    public class Drop
    {
        public int Id { get; set; }
        public List<SelectListItem> Gender { get; set; }
      
    }

}