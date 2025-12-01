using Domin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domin
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string PicUrl { get; set; }

        [ForeignKey("prd")]
        public int ProductId { get; set; }
        public Prouduct prd { get; set; }

       
    }
}
