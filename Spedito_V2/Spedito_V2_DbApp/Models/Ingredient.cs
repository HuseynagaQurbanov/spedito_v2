using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedito_V2_DbApp.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public string AdditionalSeconds { get; set; }
        public string Photo { get; set; }
    }
}
