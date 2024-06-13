using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedito_V2_DbApp.Models
{
    public class ProductReview : BaseEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
