using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewsModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }


}
