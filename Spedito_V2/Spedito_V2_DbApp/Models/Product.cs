using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedito_V2_DbApp.Models
{
    public class Product : BaseEntity
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string AdditionalInfo { get; set; }
        public string SmallImage { get; set; }
        public string BigImage { get; set; }
        public string Price { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsDealOfWeek { get; set; }
        public bool IsSpecialDeal { get; set; }
        public ProductCategory Category { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }

    }
}
