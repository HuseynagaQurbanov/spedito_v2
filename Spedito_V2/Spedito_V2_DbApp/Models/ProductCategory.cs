using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedito_V2_DbApp.Models
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
